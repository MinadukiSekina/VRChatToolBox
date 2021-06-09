using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VRChatToolBox
{
    public partial class PictureExplorer : UserControl
    {
        internal PictureBox PictureDisplay { get; set; }
        internal PictureSelector MyBoss { get; set; }

        public PictureExplorer()
        {
            InitializeComponent();
        }

        //  初期化処理
        internal void Init(string pathString, PictureBox pictureBox, PictureSelector pictureSelector)
        {
            try
            {
                SuspendLayout();
                MyBoss = pictureSelector;
                PictureDisplay = pictureBox;
                DirectoryTreeView1.InitList();
                FileListView1.SetListItems(pathString);
                PathText.Text = pathString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "初期化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ResumeLayout();
            }
        }

        // フォルダ一覧で選択時
        private void DirectoryTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                FileListView1.SetListItems(e.Node.FullPath);
                PathText.Text = FileListView1.StringPath;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 上のフォルダへ
        private void BT_UP_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpString = PathText.Text;
                int strPosition = tmpString.LastIndexOf("\\");

                tmpString = tmpString.Remove(strPosition, tmpString.Length - strPosition);

                PathText.Text = tmpString;
                FileListView1.SetListItems(tmpString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // パスの指定
        private void PathText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (!Path_Validation(PathText.Text)) return;
            FileListView1.SetListItems(PathText.Text);
        }

        // パスチェック
        private void PathText_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = Path_Validation(PathText.Text) ? false : true;
        }

        //　パスチェックのメインメソッド
        private bool Path_Validation(string pathString)
        {
            if (Directory.Exists(pathString)) return true;

            MessageBox.Show("存在しないパスです。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        // ファイル一覧のクリック：コントロール独自の処理後
        private void FileListView1_Click(object sender, EventArgs e)
        {
            try
            {
                // 情報の更新
                if (FileListView1.SelectedItemType == ListSelectedItemType.Picture) PictureDisplay.ImageLocation = FileListView1.StringPath;
                // フォームへのイベント通達：よくわからなかったから苦肉
                MyBoss.PictureSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // ファイル一覧のダブルクリック：コントロール独自の処理後
        private void FileListView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // 情報の更新
                if (FileListView1.SelectedItemType == ListSelectedItemType.Folder) PathText.Text = FileListView1.StringPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
