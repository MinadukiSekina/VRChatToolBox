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
    public partial class SettingsEditor : Form
    {
        public SettingsEditor()
        {
            InitializeComponent();
        }

        private void SettingsEditor_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode) {
                case Keys.Enter : SelectNextControl(ActiveControl, true, true, true, true); break;
                case Keys.Escape : BT_Cancel_Click(BT_Cancel,EventArgs.Empty); break;
                case Keys.F1 : BT_Return_Click(BT_Cancel,EventArgs.Empty); break;
                case Keys.F2 : BT_Reset_Click(BT_Cancel,EventArgs.Empty); break;
                case Keys.F3 : BT_Save_Click(BT_Cancel,EventArgs.Empty); break;
                default : break;
            }

        }

        private void SettingsEditor_Load(object sender, EventArgs e)
        {
            // 現在設定の表示
            SetNowValue();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // 設定の保存
                ProgramSettings.Settings.DesignatedLogPath = PSC_LogSavedPath.SelectedPath;
                ProgramSettings.Settings.DesignatedMovedLogPath = PSC_LogMovedPath.SelectedPath;
                ProgramSettings.Settings.DesignatedEditedLogPath = PSC_LogEditedPath.SelectedPath;
                ProgramSettings.Settings.DesignatedPicturesSavedFolder = PSC_PicturesSavedPath.SelectedPath;
                ProgramSettings.Settings.DesignatedPicturesMovedFolder = PSC_PicturesMovedPath.SelectedPath;

                ProgramSettings.WriteSettings($"{ProgramSettings.Settings.ExeFolderPath}\\MySettings.settings");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_Return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            // 設定のリセット
            PSC_LogSavedPath.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.LogPath2}";
            PSC_LogMovedPath.SelectedPath = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.MovedLogPath}";
            PSC_LogEditedPath.SelectedPath = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.EditedLogPath}";
            PSC_PicturesSavedPath.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.PicturesSavedFolder}";
            PSC_PicturesMovedPath.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.PicturesSavedFolder}";

        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            // 現在の設定値を表示
            SetNowValue();
        }

        private void SetNowValue()
        {
            // 設定の表示
            PSC_LogSavedPath.SelectedPath = ProgramSettings.Settings.DesignatedLogPath;
            PSC_LogMovedPath.SelectedPath = ProgramSettings.Settings.DesignatedMovedLogPath;
            PSC_LogEditedPath.SelectedPath = ProgramSettings.Settings.DesignatedEditedLogPath;
            PSC_PicturesSavedPath.SelectedPath = ProgramSettings.Settings.DesignatedPicturesSavedFolder;
            PSC_PicturesMovedPath.SelectedPath = ProgramSettings.Settings.DesignatedPicturesMovedFolder;
        }
    }
}
