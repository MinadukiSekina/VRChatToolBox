using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VRChatToolBox
{
    internal static class PicturesOrganizer
    {
        internal static void OrganizePictures()
        {
            string savedPicturesFolder = ProgramSettings.GetPicturesSavedFolder();
            string movedPicturesFolder = ProgramSettings.GetPicturesMovedFolder();
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
                if(!File.Exists($"{NewFolderPath}\\{pictureName}")) File.Move(picture, $"{NewFolderPath}\\{pictureName}");
            }
        }
    }
}
