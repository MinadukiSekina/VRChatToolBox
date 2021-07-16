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
        private async void BT_EditLog_Click(object sender, EventArgs e)
        {
            try
            {
                BT_EditLog.Enabled = false;
                // 非同期で実行
                await Task.Run(() => LogEditor.CopyAndEdit());
                MessageBox.Show("ログのコピーと編集が終わりました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", "処理時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BT_EditLog.Enabled = true;
            }
        }
        
        // 写真の整理と移動
        private async void BT_PicturesMove_Click(object sender, EventArgs e)
        {
            try
            {
                BT_PicturesMove.Enabled = false;
                // 非同期で実行
                await Task.Run( () => PicturesOrganizer.OrganizePictures());
                MessageBox.Show("写真の整理が終わりました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", "処理時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BT_PicturesMove.Enabled = true;
            }
        }
        
        // 設定画面のオープン
        private void BT_Settings_Click(object sender, EventArgs e)
        {
            try
            {
                // 念のため、ログ移動などをしている時は止める。
                if (Check_Enabled() == false) return;

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
                // 念のため、ログ移動などをしている時は止める。
                if (Check_Enabled() == false) return;

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
                // 念のため、ログ移動などをしている時は止める。
                if (Check_Enabled() == false) return;

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
                // 念のため、ログ移動などをしている時は止める。
                if (Check_Enabled() == false) return;

                LogBrowser logBrowser = new LogBrowser();
                logBrowser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // フォームのクローズ中
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ログの移動中などは閉じさせない。
            e.Cancel = !Check_Enabled();
        }

        // 各フォームの起動・メイン画面の終了可否判断
        private bool Check_Enabled()
        {
            // ログの移動・写真の移動のどちらもしてなければ許可する。
            if (BT_EditLog.Enabled == true && BT_PicturesMove.Enabled == true) return true;
            MessageBox.Show("他の処理を実行中です。\r\nしばらくお待ちください。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
    }
}
