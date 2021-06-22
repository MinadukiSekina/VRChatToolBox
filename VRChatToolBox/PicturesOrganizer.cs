using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace VRChatToolBox
{
    internal static class PicturesOrganizer
    {
        // 写真の移動処理（一括）
        internal static void OrganizePictures()
        {
            bool makeDayFolder = ProgramSettings.Settings.MakeDayFolder;
            string savedPicturesFolder = ProgramSettings.Settings.DesignatedPicturesSavedFolder;
            string movedPicturesFolder = ProgramSettings.Settings.DesignatedPicturesMovedFolder;
            string NewFolderPath = "";
            string pictureName   = "";
            string monthString   = "";
            string dateString    = "";
            string destPath      = "";

            IEnumerable<string> pictures = Directory.EnumerateFiles(savedPicturesFolder, "*.png", SearchOption.TopDirectoryOnly);

            foreach(string picture in pictures)
            {
                dateString    = File.GetCreationTime(picture).ToString("yyyyMMdd");
                monthString   = File.GetCreationTime(picture).ToString("yyyyMM");
                pictureName   = Path.GetFileName(picture);
                NewFolderPath = $"{movedPicturesFolder}\\{monthString}{(makeDayFolder? $"\\{dateString}":"")}";
                destPath      = $"{NewFolderPath}\\{pictureName}";
   
                // 写真の日付のフォルダがあるか
                if (!Directory.Exists(NewFolderPath)) Directory.CreateDirectory(NewFolderPath);
                
                // エラー回避？
                if (!File.Exists(destPath)) File.Move(picture, destPath);
                
                // サムネイル作成
                CreateThumbNail(destPath, $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.ThumbnailFolderName}\\{pictureName}");
            }
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
            // 万が一写真が無ければ返す
            if (!File.Exists(picturePath)) return;

            string pictureName = Path.GetFileName(picturePath);
            string destPath = $"{ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder}\\{pictureName}";

            // 既にあるなら移動させない
            if (File.Exists(destPath)) return;
         
            // なければフォルダを作る
            if (!Directory.Exists(ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder))
                 Directory.CreateDirectory(ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder);

            File.Move(picturePath, destPath);

        }

        // サムネイルの取得
        internal static Image GetThumbNail(string[] pictureStr)
        {
            string thumbNailFolder = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.ThumbnailFolderName}";
            string thumbNailPath   = $"{thumbNailFolder}\\{pictureStr[0]}";

            // サムネイルの作成
            CreateThumbNail(pictureStr[1], thumbNailPath);

            //　サムネイルの読み込み
            using (FileStream fileStream = File.OpenRead(thumbNailPath))
            {
                Image image = Image.FromStream(fileStream, false, false);
                return image;
            }

        }

        // サムネイル画像のキャッシュ
        internal static void CreateThumbNail(string originalPath, string destPath)
        {
            // 既にあるなら作らない
            if (File.Exists(destPath)) return;

            string thumbNailFolder = Path.GetDirectoryName(destPath);
            if (!Directory.Exists(thumbNailFolder)) Directory.CreateDirectory(thumbNailFolder);

            // イメージリストのアイコンサイズ
            int width  = ProgramSettings.ThumbWidth;
            int height = ProgramSettings.ThumbHeight;

            Bitmap canvas = new Bitmap(width, height);

            using (FileStream fileStream = File.OpenRead(originalPath))
            {
                using (Image original = Image.FromStream(fileStream, false, false))
                {
                    using (Graphics drawer = Graphics.FromImage(canvas))
                    {
                        drawer.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0, 0)), 0, 0, width, height);

                        float fWidth = (float)width / (float)original.Width;
                        float fHeight = (float)height / (float)original.Height;

                        float scale = Math.Min(fWidth, fHeight);
                        fWidth = original.Width * scale;
                        fHeight = original.Height * scale;

                        drawer.DrawImage(original, (width - fWidth) / 2, (height - fHeight) / 2, fWidth, fHeight);
                    }
                }
            }
            canvas.Save(destPath);
        }

        // サムネイル画像のキャッシュフォルダサイズを計算
        internal static string GetThumbNailFolderSize()
        {
            // フォルダパスの確認
            string thumbNailFolder = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.ThumbnailFolderName}";
            if (!Directory.Exists(thumbNailFolder)) return "0B";

            // 計算準備
            long folderSize = 0;
            DirectoryInfo directoryInfo = new DirectoryInfo(thumbNailFolder);

            // 写真のサイズを加算していく
            foreach (FileInfo pictureInfo in directoryInfo.GetFiles("*.png", SearchOption.AllDirectories))
            {
                folderSize += pictureInfo.Length;
            }

            if(folderSize == 0) return "0B";
            
            // 後で使うので最初に宣言
            int i;

            // 単位換算
            for(i = 1; folderSize >= 1024; i++)
            {
                folderSize /= 1024;
            }

            // 回数で単位を判断して返す
            switch (i)
            {
                case 1: return $"{folderSize}B";
                case 2: return $"{folderSize}KB";
                case 3: return $"{folderSize}MB";
                case 4: return $"{folderSize}GB";
                case 5: return $"{folderSize}TB";
                default: return $"{folderSize}TB";
            }
        }
    }
}
