using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VRChatToolBox
{
    internal static class PicturesOrganizer
    {
        // 写真の移動処理（一括）
        internal static void OrganizePictures()
        {
            string savedPicturesFolder = ProgramSettings.Settings.DesignatedPicturesSavedFolder;
            string movedPicturesFolder = ProgramSettings.Settings.DesignatedPicturesMovedFolder;
            string NewFolderPath = "";
            string pictureName = "";
            string dateString = "";
            IEnumerable<string> pictures = Directory.EnumerateFiles(savedPicturesFolder, "*.png", SearchOption.TopDirectoryOnly);

            foreach(string picture in pictures)
            {
                dateString = File.GetCreationTime(picture).ToString("yyyyMM");
                pictureName = Path.GetFileName(picture);
                NewFolderPath = $"{movedPicturesFolder}\\{dateString}";
                // 写真の日付のフォルダがあるか
                if (!Directory.Exists(NewFolderPath)) Directory.CreateDirectory(NewFolderPath);
                // エラー回避？
                if (!File.Exists($"{NewFolderPath}\\{pictureName}")) File.Move(picture, $"{NewFolderPath}\\{pictureName}");
            }
        }

        // ワールド候補リストの取得
        internal static string[] GetWorldList(string pictureDate)
        {
            IEnumerable<string> editedLogFileList = Directory.EnumerateFiles($"{ProgramSettings.Settings.DesignatedEditedLogPath}\\{pictureDate}", 
                                                                             $"*{pictureDate}*.txt", SearchOption.TopDirectoryOnly);
            List<string> worldList = new List<string>();
            string[] contents;
            string SearchStr = "World";
            string worldName = "";

            foreach (string editedLogFile in editedLogFileList)
            {
                contents = File.ReadAllLines(editedLogFile);
                foreach(string line in contents)
                {
                    // 空行か、一致しなければ飛ばす
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    if (!Regex.IsMatch(line, SearchStr)) continue;

                    // World名を抜き出してAdd
                    worldName = line.Substring(line.IndexOf("W") + 7);
                    worldList.Add(worldName);
                }

            }

            return worldList.ToArray();
        }

        // 選択した写真のコピー
        internal static void MoveSelectedPicture(string picturePath)
        {
            string pictureName = Path.GetFileName(picturePath);
            string destPath = $"{ProgramSettings.Settings.DesignatedPicturesSelectedFolder}\\{pictureName}";
            // 既にあるなら移動させない
            if (File.Exists(destPath)) return;
            // なければフォルダを作る
            if (!Directory.Exists(ProgramSettings.Settings.DesignatedPicturesSelectedFolder))
                 Directory.CreateDirectory(ProgramSettings.Settings.DesignatedPicturesSelectedFolder);
            File.Copy(picturePath, destPath);
        }

        // 投稿した写真の移動
        internal static void MoveUpLoadedPicture(string picturePath)
        {
            string pictureName = Path.GetFileName(picturePath);
            string destPath = $"{ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder}\\{pictureName}";
            // 既にあるなら移動させない
            if (File.Exists(destPath)) return;
            // なければフォルダを作る
            if (!Directory.Exists(ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder))
                 Directory.CreateDirectory(ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder);
            File.Move(picturePath, destPath);
        }
    }
}
