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
       internal static void CopyAndEdit()
        {
            IEnumerable<string> Files = Directory.EnumerateFiles(ProgramSettings.Settings.DesignatedLogPath, "*.txt", SearchOption.TopDirectoryOnly);
            string LogMovedPath = ProgramSettings.Settings.DesignatedMovedLogPath;
            string EditedLogPath = ProgramSettings.Settings.DesignatedEditedLogPath;
            string DateString = "";
            string TimeString = "";
            string DirPath = "";
            string FilePath = "";
            string FileName = "";

            string[] FileContents;
            string CreatePath = "";
            string SearchStr = "";
            string WriteStr = "";

            foreach (string item in Files)
            {
                // 元のログをexeと同一階層にある保管用フォルダ内にコピーする
                FileName = Path.GetFileName(item);
                DateString = File.GetCreationTime(item).ToString("yyyyMMdd");
                TimeString = File.GetCreationTime(item).ToString("HHmmss");
                DirPath = $"{LogMovedPath}\\{DateString}";
                FilePath = $"{DirPath}\\{FileName}";

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
                SearchStr = "Entering Room|OnPlayerJoined|Unregistering";
                WriteStr = "";

                // 一応存在確認はした方が早いらしい？
                if (!Directory.Exists(DirPath))  Directory.CreateDirectory(DirPath); 

                using (StreamWriter SW = new StreamWriter(CreatePath))
                {
                    for (int i = 0; i <= FileContents.Length - 1; i++)
                    {
                        // 空行か、一致しなければ飛ばす
                        if (string.IsNullOrWhiteSpace(FileContents[i])) continue;
                        if (!Regex.IsMatch(FileContents[i], SearchStr)) continue;

                        WriteStr = FileContents[i].Replace("Log        -  [Behaviour] Entering Room", "World");
                        WriteStr = WriteStr.Replace("Log        -  [Behaviour] OnPlayerJoined", "Join :");
                        WriteStr = WriteStr.Replace("Log        -  [Behaviour] Unregistering", "Exit :");
                        SW.Write(WriteStr);
                        SW.WriteLine();
                        
                    }
                }

            }

        }
    }
}
