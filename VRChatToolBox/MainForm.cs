using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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
                // 設定の読み込み
                ProgramSettings.InitializeSettings();
                // バージョン表示
                Assembly assembly = Assembly.GetExecutingAssembly();
                Version version   = assembly.GetName().Version;
                Text = $"VRChatToolBox {version.Major.ToString()}.{version.Minor.ToString()}.{version.Build.ToString()}";
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
            try
            {
                SettingsEditor settingsEditor = new SettingsEditor();
                settingsEditor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // 投稿する写真を選ぶ
        private void BT_Select_Click(object sender, EventArgs e)
        {
            try
            {
                PictureSelector pictureSelector = new PictureSelector(PictureSelectMode.Select);
                pictureSelector.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // 写真を投稿する
        private void BT_UpLoad_Click(object sender, EventArgs e)
        {
            try
            {
                PictureSelector pictureSelector = new PictureSelector(PictureSelectMode.UpLoad);
                pictureSelector.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ログの閲覧
        private void BT_BrowseLog_Click(object sender, EventArgs e)
        {
            try
            {
                LogBrowser logBrowser = new LogBrowser();
                logBrowser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
