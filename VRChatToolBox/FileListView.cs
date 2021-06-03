using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace VRChatToolBox
{
    class FileListView : ListView
    {
        // 写真表示用の紐付け
        internal PictureBox PictureDisp { get; set; }

        // とりあえず単一ビュー想定なので、使ってるイメージリストを返す
        internal ImageList NowViewImages
        {
            get {
                if (View == View.LargeIcon)
                {
                    if (LargeImageList == null) LargeImageList = new ImageList();
                    return LargeImageList;
                }
                else
                {
                    if (SmallImageList == null) SmallImageList = new ImageList();
                    return SmallImageList;
                }
            }
        }

        // リストの設定
        internal void SetListItems(string folderPath)
        {
            // 初期化
            Clear();
            if (NowViewImages.Images.Count >= 2)
            {
                for (int i = 1; i < NowViewImages.Images.Count; i++)
                {
                    NowViewImages.Images.RemoveAt(i);
                }
            }

            DirectoryInfo ParentDir = new DirectoryInfo(folderPath);
            // フォルダの列挙
            foreach (DirectoryInfo childDir in ParentDir.EnumerateDirectories())
            {
                string[] items = { childDir.Name, childDir.FullName };
                ListViewItem listViewItem = new ListViewItem(items, 0);
                Items.Add(listViewItem);
            }

            // 写真の列挙
            int j = 1;
            foreach (FileInfo childFile in ParentDir.EnumerateFiles("*.png", SearchOption.TopDirectoryOnly))
            {
                NowViewImages.Images.Add(Bitmap.FromFile(childFile.FullName));
                ListViewItem listViewItem = new ListViewItem(childFile.Name, j);
                listViewItem.SubItems.Add(childFile.FullName);
                Items.Add(listViewItem);
                j += 1;
            }
        }

        // ダブルクリック時
        protected override void OnDoubleClick(EventArgs e)
        {
            // 何も選択されてなかったら抜ける
            if (SelectedItems.Count == 0) return;

            string selectedPath = SelectedItems[0].SubItems[1].Text;

            // 選択がフォルダなら再設定して抜ける
            if (Directory.Exists(selectedPath))
            {
                SetListItems(selectedPath);
            }
            else
            {
                // 存在しないなら抜ける
                if (!File.Exists(selectedPath)) return;
                // 表示させる
                PictureDisp.ImageLocation = selectedPath;
            }

            // 基底クラスの処理
            base.OnDoubleClick(e);
        }
    }
}
