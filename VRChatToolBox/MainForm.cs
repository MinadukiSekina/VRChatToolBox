using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRChatToolBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // ロード時
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                ProgramSettings.InitializeSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "起動時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        // ログのコピーと編集
        private void BT_EditLog_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                LogEditor.CopyAndEdit();
                MessageBox.Show("ログのコピーと編集が終わりました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", "処理時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Enabled = true;
            }
        }
        
        // 写真の整理と移動
        private void BT_PicturesMove_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                
                PicturesOrganizer.OrganizePictures();
                MessageBox.Show("写真の整理が終わりました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", "処理時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Enabled = true;
            }
        }
        
        // 設定画面のオープン
        private void BT_Settings_Click(object sender, EventArgs e)
        {
            SettingsEditor settingsEditor = new SettingsEditor();
            settingsEditor.ShowDialog();
        }
        
        // 投稿する写真を選ぶ
        private void BT_Select_Click(object sender, EventArgs e)
        {
            PictureSelector pictureSelector = new PictureSelector(PictureSelectMode.Select);
            pictureSelector.ShowDialog();
        }
        
        // 写真を投稿する
        private void BT_UpLoad_Click(object sender, EventArgs e)
        {
            PictureSelector pictureSelector = new PictureSelector(PictureSelectMode.UpLoad);
            pictureSelector.ShowDialog();
        }

    }
}
