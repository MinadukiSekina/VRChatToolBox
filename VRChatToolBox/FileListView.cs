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
        // 選択したパスの格納
        internal string StringPath { get; set; }
        // 何を選んだか
        internal ListSelectedItemType SelectedItemType { get; set; }

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
            try
            {
                // 処理を軽くしたい
                SuspendLayout();

                // 初期化
                Clear();
                StringPath = folderPath;
                SelectedItemType = ListSelectedItemType.Folder;

                if (NowViewImages.Images.Count >= 2)
                {
                    for (int i = NowViewImages.Images.Count - 1; i > 0; i--)
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
                    using (FileStream fileStream = File.OpenRead(childFile.FullName))
                    {
                        using (Image image = Image.FromStream(fileStream, false, false))
                        {
                            NowViewImages.Images.Add(image);
                            ListViewItem listViewItem = new ListViewItem(childFile.Name, j);
                            listViewItem.SubItems.Add(childFile.FullName);
                            Items.Add(listViewItem);
                        }
                    }
                    j += 1;
                }
            }
            finally
            {
                ResumeLayout();
            }
        }

        // ダブルクリック時
        protected override void OnDoubleClick(EventArgs e)
        {
            try
            {
                // 何も選択されてなかったら抜ける
                if (SelectedItems.Count == 0) return;

                string selectedPath = SelectedItems[0].SubItems[1].Text;

                // 選択がフォルダなら再設定
                if (Directory.Exists(selectedPath)) SetListItems(selectedPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "選択エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 基底クラスの処理
            base.OnDoubleClick(e);
        }

        protected override void OnClick(EventArgs e)
        {
            try
            {
                // 何も選択されてなかったら抜ける
                if (SelectedItems.Count == 0) return;

                string selectedPath = SelectedItems[0].SubItems[1].Text;

                // ファイルが存在しないなら抜ける
                if (!File.Exists(selectedPath)) return;
                // 表示させる
                StringPath = selectedPath;
                SelectedItemType = ListSelectedItemType.Picture;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "選択エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 基底クラスのイベント処理
            base.OnClick(e);
        }

    }
}
