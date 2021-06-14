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
                    if (LargeImageList is null) LargeImageList = new ImageList();
                    return LargeImageList;
                }
                else
                {
                    if (SmallImageList is null) SmallImageList = new ImageList();
                    return SmallImageList;
                }
            }
        }

        // リストビューアイテムのリスト
        private List<ListViewItem> _listViewItems;
        internal List<ListViewItem> ListViewItems
        {
            get { if (_listViewItems is null)
                    _listViewItems = new List<ListViewItem> { };
                  return _listViewItems; }
            set { _listViewItems = value; }
        }

        // コンストラクタ
        public FileListView()
        {
            // イベント追加
            RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(FilelistView_RetrieveVirtualItem);
        }

        // リストの設定
        internal void SetListItems(string folderPath)
        {
            try
            {
                // 処理を軽くしたい
                BeginUpdate();

                // 初期化
                Clear();
                StringPath = folderPath;
                SelectedItemType = ListSelectedItemType.Folder;

                // 仮想モードオン
                VirtualMode = true;
                ListViewItems.Clear();

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
                    string[] items = { childDir.Name, childDir.FullName, "0" };
                    ListViewItem listViewItem = new ListViewItem(items, 0);
                    ListViewItems.Add(listViewItem);
                }

                // 写真の列挙
                int j = 1;
                foreach (FileInfo childFile in ParentDir.EnumerateFiles("*.png", SearchOption.TopDirectoryOnly))
                {
                    using (FileStream fileStream = File.OpenRead(childFile.FullName))
                    {
                        string[] items = { childFile.Name, childFile.FullName, "1" };
                        ListViewItem listViewItem = new ListViewItem(items, 0);
                        ListViewItems.Add(listViewItem);
                    }
                    j += 1;
                }

                // 仮想モードの設定終了
                VirtualListSize = ListViewItems.Count;
            }
            finally
            {
                // 描画処理再開
                EndUpdate();
            }
        }

        //// 選択した項目の削除
        //internal void DeleteItemAndImage()
        //{
        //    if (Items.Count == 0 || SelectedItems is null) return;
        //    NowViewImages.Images.RemoveAt(SelectedIndices[0] + 1);
        //    Items.Remove(SelectedItems[0]);
        //}


        internal void FilelistView_RetrieveVirtualItem(object sender,RetrieveVirtualItemEventArgs re)
        {
            try
            {
                // デバッグだと何度もイベントが起きたりしていたので
                if (re.Item != null) return;

                ListViewItem listViewItem = ListViewItems[re.ItemIndex];
                
                // フォルダ or 読み込み済ならそのまま返す
                if (listViewItem.SubItems[2].Text != "1")
                {
                    re.Item = listViewItem;
                    return;
                }
                
                using (FileStream fileStream = File.OpenRead(listViewItem.SubItems[1].Text))
                {
                    using (Image image = Image.FromStream(fileStream, false, false))
                    {
                        // サムネイルの追加
                        NowViewImages.Images.Add(image);
                        // サムネイルのインデックス
                        int index = NowViewImages.Images.Count - 1;

                        // サムネイルと紐づけて渡す
                        listViewItem.ImageIndex = index;
                        listViewItem.SubItems[2].Text = "2";
                        re.Item = listViewItem;

                        // キャッシュに更新を反映
                        ListViewItems[re.ItemIndex] = listViewItem;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ダブルクリック時
        protected override void OnDoubleClick(EventArgs e)
        {
            try
            {
                // 何も選択されてなかったら抜ける
                if (SelectedIndices.Count == 0) return;
                string selectedPath = ListViewItems[SelectedIndices[0]].SubItems[1].Text;

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
                if (SelectedIndices.Count == 0) return;
                string selectedPath = ListViewItems[SelectedIndices[0]].SubItems[1].Text;

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
