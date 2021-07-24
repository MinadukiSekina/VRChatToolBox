using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace VRChatToolBox
{
  internal static class LogEditor
    {
        // VRChatログのコピーと編集したログの作成
       internal static void CopyAndEdit()
        {
            IEnumerable<string> Files = Directory.EnumerateFiles(ProgramSettings.Settings.DesignatedLogPath, "*.txt", SearchOption.TopDirectoryOnly);

            string LogMovedPath  = ProgramSettings.Settings.DesignatedMovedLogPath;
            string EditedLogPath = ProgramSettings.Settings.DesignatedEditedLogPath;
            string DateString    = "";
            string TimeString    = "";
            string DirPath       = "";
            string FilePath      = "";
            string FileName      = "";

            string[] FileContents;
            string CreatePath = "";
            string SearchStr  = "Entering Room|OnPlayerJoined|Unregistering";
            string rejectStr  = "Exception";
            string WriteStr   = "";

            foreach (string item in Files)
            {
                // 元のログをexeと同一階層にある保管用フォルダ内にコピーする
                FileName   = Path.GetFileName(item);
                DateString = File.GetCreationTime(item).ToString("yyyyMMdd");
                TimeString = File.GetCreationTime(item).ToString("HHmmss");
                DirPath    = $"{LogMovedPath}\\{DateString}";
                FilePath   = $"{DirPath}\\{FileName}";

                // 既にファイルがあれば、処理済みと判断
                if (File.Exists(FilePath)) continue;
                // コピー前にフォルダを作る
                if (!Directory.Exists(DirPath)) Directory.CreateDirectory(DirPath);

                File.Copy(item, FilePath);

                // 移動したログファイルを読み込み
                FileContents = File.ReadAllLines(FilePath);

                // フォルダのパスの設定しなおし
                DirPath = $"{EditedLogPath}\\{DateString}";

                // コピーしたログを元に編集
                CreatePath = $"{DirPath}\\EditedLog_{DateString}_{TimeString}.txt";
                WriteStr   = "";

                // 一応存在確認はした方が早いらしい？
                if (!Directory.Exists(DirPath))  Directory.CreateDirectory(DirPath); 

                using (StreamWriter SW = new StreamWriter(CreatePath))
                {
                    for (int i = 0; i < FileContents.Length; i++)
                    {
                        // 空行か、エラー行か、一致しなければ飛ばす
                        if (string.IsNullOrWhiteSpace(FileContents[i])) continue;
                        if ( Regex.IsMatch(FileContents[i], rejectStr)) continue;
                        if (!Regex.IsMatch(FileContents[i], SearchStr)) continue;

                        // 力技でゴリ押し
                        WriteStr = FileContents[i].Replace("Log        -  [Behaviour] Entering Room", "World");
                        WriteStr = WriteStr.Replace("Log        -  [Behaviour] OnPlayerJoined", "Join :");
                        WriteStr = WriteStr.Replace("Log        -  [Behaviour] Unregistering", "Exit :");
                        SW.Write(WriteStr);
                        SW.WriteLine();
                        
                    }
                }

            }

        }
   
        // 投稿後のメタデータの移動
        internal static void MoveMetaDataFile(string filePath)
        {
            // 万が一メタデータが無ければ返す
            if (!File.Exists(filePath)) return;

            string fileName = Path.GetFileName(filePath);
            string destPath = $"{ProgramSettings.Settings.DesignatedUpLoadedInfoPath}\\{fileName}";

            // 既にあれば移動しない
            if (File.Exists(destPath)) return;
    
            // なければフォルダを作る
            if (!Directory.Exists(ProgramSettings.Settings.DesignatedUpLoadedInfoPath))
                 Directory.CreateDirectory(ProgramSettings.Settings.DesignatedUpLoadedInfoPath);

            File.Move(filePath, destPath);

        }

        // ワールド候補リストの取得
        internal static string[] GetWorldList(string[] dateAndTime, ref string resultName)
        {
            // フォルダが無ければすぐに戻す
            string targetDir = $"{ProgramSettings.Settings.DesignatedEditedLogPath}\\{dateAndTime[0]}";
            if (!Directory.Exists(targetDir)) return new string[] { };

            IEnumerable<string> editedLogFileList = Directory.EnumerateFiles(targetDir, $"*{dateAndTime[0]}*.txt", SearchOption.TopDirectoryOnly);

            List<string> worldList = new List<string>();
            string[] contents;
            string SearchStr = "World";
            string worldName = "";

            foreach (string editedLogFile in editedLogFileList)
            {
                contents = File.ReadAllLines(editedLogFile);
                for (int i = 0; i < contents.Length; i++)
                {
                    // 空行か、一致しなければ飛ばす
                    if (string.IsNullOrWhiteSpace(contents[i])) continue;
                    if (!Regex.IsMatch(contents[i], SearchStr)) continue;

                    // World名を抜き出してAdd
                    worldName = contents[i].Substring(contents[i].IndexOf('W') + 7);
                    worldList.Add(worldName);

                    // 時刻の指定があれば、撮影時間からワールドを推測
                    if (string.IsNullOrWhiteSpace(dateAndTime[1])) continue;

                    string[] line = contents[i].Split(' ');
                    long worldDateTime = long.Parse(line[0].Replace(".", "") + line[1].Replace(":", ""));
                    long photoDateTime = long.Parse(dateAndTime[0] + dateAndTime[1]);
                    if (worldDateTime <= photoDateTime) resultName = worldName;
                }

            }

            // 重複は除いて配列化
            return worldList.Distinct().ToArray();
        }

        // ワールド・Join履歴・Exit履歴の取得
        internal static void GetListFromEditedLog(string dateString, ref string[] worldArray, ref string[][] joinArray, ref string[][] exitArray)
        {
            // フォルダが無ければすぐに戻す
            string targetDir = $"{ProgramSettings.Settings.DesignatedEditedLogPath}\\{dateString}";
            if (!Directory.Exists(targetDir)) return;

            IEnumerable<string> editedLogFileList = Directory.EnumerateFiles(targetDir, $"*{dateString}*.txt", SearchOption.TopDirectoryOnly);

            // 戻すリストを準備
            List<string> worldList   = new List<string>();
            List<string[]> joinList  = new List<string[]>();
            List<string[]> exitList  = new List<string[]>();

            // 一時保存用
            List<string> tmpJoin = new List<string>();
            List<string> tmpExit = new List<string>();

            int worldCount = 0;

            foreach (string editedLogFile in editedLogFileList)
            {
                foreach(string line in File.ReadLines(editedLogFile))
                { 
                    // 空行なら飛ばす
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    // ワールド単位で追加
                    if (Regex.IsMatch(line, "World"))
                    {
                        worldList.Add(line);
                        if (worldCount > 0)
                        {
                            joinList.Add(tmpJoin.ToArray());
                            exitList.Add(tmpExit.ToArray());
                            tmpJoin = new List<string>();
                            tmpExit = new List<string>();
                        }
                        worldCount++;
                        continue;
                    }
                    // Join履歴の追加
                    if (Regex.IsMatch(line, "Join"))
                    {
                        tmpJoin.Add(line);
                        continue;
                    }
                    // Exit履歴の追加
                    if (Regex.IsMatch(line, "Exit"))
                    {
                        tmpExit.Add(line);
                        continue;
                    }
                }

                // 最後に忘れず追加と初期化：ワールドとJoin・Exitの履歴がずれるため
                if (worldCount > 0)
                {
                    joinList.Add(tmpJoin.ToArray());
                    exitList.Add(tmpExit.ToArray());
                    tmpJoin = new List<string>();
                    tmpExit = new List<string>();
                    worldCount = 0;
                }
            }

            // 結果を返す
            worldArray = worldList.ToArray();
            joinArray  = joinList.ToArray();
            exitArray  = exitList.ToArray();
        }

    }
}
