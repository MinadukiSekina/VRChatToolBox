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
            try
            {
                InitializeComponent();
                ProgramSettings.InitializeSettings();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "起動時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_EditLog_Click(object sender, EventArgs e)
        {
            try
            {
                LogEditor.CopyAndEdit();
                MessageBox.Show("ログのコピーと編集が終わりました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", "処理時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_PicturesMove_Click(object sender, EventArgs e)
        {
            try
            {
                PicturesOrganizer.OrganizePictures();
                MessageBox.Show("写真の整理が終わりました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", "処理時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_Settings_Click(object sender, EventArgs e)
        {
            SettingsEditor settingsEditor = new SettingsEditor();
            settingsEditor.ShowDialog();
        }

        private void BT_Select_Click(object sender, EventArgs e)
        {
            PictureSelector pictureSelector = new PictureSelector();
            pictureSelector.ShowDialog();
        }
    }
}
