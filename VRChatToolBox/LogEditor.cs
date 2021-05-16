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
            string[] Files = Directory.GetFiles("C:\\Users\\syaku\\AppData\\LocalLow\\VRChat\\vrchat", "*.txt", SearchOption.TopDirectoryOnly);
            string FilePath = "";
            string FileName = "";

            foreach (string item in Files)
            {
                // 元のログをexeと同一階層にある保管用フォルダ内にコピーする
                FileName = Path.GetFileName(item);
                FilePath = $"C:\\Users\\syaku\\Desktop\\VRCTB\\VRChatLog\\{File.GetCreationTime(item).ToString("yyyyMMdd")}\\{FileName}";
                if (File.Exists(FilePath)) { continue; }
                File.Copy(item, FilePath);

                // 移動したログファイルを元に編集したものを書き出し
                string[] FileContents = File.ReadAllLines(FilePath);
                string DirPath = $"C:\\Users\\syaku\\Desktop\\VRCTB\\VRChatEditLog\\{File.GetCreationTime(item).ToString("yyyyMMdd")}";
                string CreatePath = $"C:\\Users\\syaku\\Desktop\\VRCTB\\VRChatEditLog\\{File.GetCreationTime(item).ToString("yyyyMMdd")}\\{FileName}";
                string SearchStr = "Entering Room|OnPlayerJoined|Unregistering";
                string WriteStr = "";

                if (Directory.Exists(DirPath) == false) { Directory.CreateDirectory(DirPath); }

                using (StreamWriter SW = new StreamWriter(CreatePath))
                {
                    for (int i = 0; i <= FileContents.Length - 1; i++)
                    {
                        if (string.IsNullOrWhiteSpace(FileContents[i])) { continue; }
                        if (Regex.IsMatch(FileContents[i], SearchStr))
                        {
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
}
