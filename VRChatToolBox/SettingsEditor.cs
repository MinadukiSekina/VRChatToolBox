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
            DGV_AvatarData.AutoGenerateColumns = false;
        }

        private void SettingsEditor_Load(object sender, EventArgs e)
        {
            // 現在設定の表示
            SetNowValue();
            LB_CacheSize.Text =$"サムネイル画像のキャッシュ容量：{PicturesOrganizer.GetThumbNailFolderSize()}";
            PSC_LogSavedPath.Select();
        }

        private void SettingsEditor_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode) {
                case Keys.Enter :
                    if (ActiveControl.Name != TweetBox1.Name) SelectNextControl(ActiveControl, true, true, true, true);
                    break;
                default : break;
            }

        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // 設定の保存
                // ログ関連
                ProgramSettings.Settings.DesignatedLogPath = PSC_LogSavedPath.SelectedPath.Trim();
                ProgramSettings.Settings.DesignatedMovedLogPath = PSC_LogMovedPath.SelectedPath.Trim();
                ProgramSettings.Settings.DesignatedEditedLogPath = PSC_LogEditedPath.SelectedPath.Trim();
                // 写真関連
                ProgramSettings.Settings.DesignatedPicturesSavedFolder = PSC_PicturesSavedPath.SelectedPath.Trim();
                ProgramSettings.Settings.DesignatedPicturesMovedFolder = PSC_PicturesMovedPath.SelectedPath.Trim();
                ProgramSettings.Settings.DesignatedPicturesSelectedFolder = PSC_SelectedPicturesFolder.SelectedPath.Trim();
                ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder = PSC_UpLoadedPicturesFolder.SelectedPath.Trim();
                ProgramSettings.Settings.MakeDayFolder = CH_MakeDayFolder.Checked;
                // メタデータ関連
                ProgramSettings.Settings.DesignatedPictureInfoPath = PSC_SelectedInfoFolder.SelectedPath.Trim();
                ProgramSettings.Settings.DesignatedUpLoadedInfoPath = PSC_UpLoadedInfoFolder.SelectedPath.Trim();
                ProgramSettings.Settings.Tweet = TweetBox1.Lines;
                DGV_AvatarData.EndEdit();
                ProgramSettings.Settings.AvataData.AcceptChanges();

                XmlContractor.WriteObjectXML($"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.SettingsFileName}", ProgramSettings.Settings);

                MessageBox.Show("設定を保存しました。", "設定保存", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            // ログ関連
            PSC_LogSavedPath.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.LogPath2}";
            PSC_LogMovedPath.SelectedPath = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.MovedLogPath}";
            PSC_LogEditedPath.SelectedPath = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.EditedLogPath}";
            // 写真関連
            PSC_PicturesSavedPath.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.PicturesSavedFolder}";
            PSC_PicturesMovedPath.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.PicturesSavedFolder}";
            PSC_SelectedPicturesFolder.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.PicturesSavedFolder}\\{ProgramSettings.PictureSelectedFolder}";
            PSC_UpLoadedPicturesFolder.SelectedPath = $"{ProgramSettings.LogPath1}{ProgramSettings.Settings.UserName}{ProgramSettings.PicturesSavedFolder}\\{ProgramSettings.PictureUpLoadedFolder}";
            CH_MakeDayFolder.Checked = false;
            // メタデータ関連
            PSC_SelectedInfoFolder.SelectedPath = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.PictureInfoPath}";
            PSC_UpLoadedInfoFolder.SelectedPath = $"{ProgramSettings.Settings.ExeFolderPath}\\{ProgramSettings.UpLoadedInfoPath}";
            TweetBox1.Text = "";
            DGV_AvatarData.EndEdit();
            ProgramSettings.Settings.AvataData.RejectChanges();

        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            DGV_AvatarData.EndEdit();
            ProgramSettings.Settings.AvataData.RejectChanges();
            // 現在の設定値を表示
            SetNowValue();
        }

        private void SetNowValue()
        {
            // 設定の表示
            // ログ出力関連
            PSC_LogSavedPath.SelectedPath = ProgramSettings.Settings.DesignatedLogPath;
            PSC_LogMovedPath.SelectedPath = ProgramSettings.Settings.DesignatedMovedLogPath;
            PSC_LogEditedPath.SelectedPath = ProgramSettings.Settings.DesignatedEditedLogPath;
            // 写真関連
            PSC_PicturesSavedPath.SelectedPath = ProgramSettings.Settings.DesignatedPicturesSavedFolder;
            PSC_PicturesMovedPath.SelectedPath = ProgramSettings.Settings.DesignatedPicturesMovedFolder;
            PSC_SelectedPicturesFolder.SelectedPath = ProgramSettings.Settings.DesignatedPicturesSelectedFolder;
            PSC_UpLoadedPicturesFolder.SelectedPath = ProgramSettings.Settings.DesignatedPicturesUpLoadedFolder;
            CH_MakeDayFolder.Checked = ProgramSettings.Settings.MakeDayFolder;
            // メタデータ関連
            PSC_SelectedInfoFolder.SelectedPath = ProgramSettings.Settings.DesignatedPictureInfoPath;
            PSC_UpLoadedInfoFolder.SelectedPath = ProgramSettings.Settings.DesignatedUpLoadedInfoPath;
            TweetBox1.Lines = ProgramSettings.Settings.Tweet;
            DGV_AvatarData.DataSource = ProgramSettings.Settings.AvataData;

        }

        // 行の追加
        private void BT_AddRow_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = ProgramSettings.Settings.AvataData.NewRow();
                dataRow["AvatarName"]   = "";
                dataRow["AvatarAuthor"] = "";
                ProgramSettings.Settings.AvataData.Rows.InsertAt(dataRow, ProgramSettings.Settings.AvataData.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_RemoveRow_Click(object sender, EventArgs e)
        {
            try
            {
                ProgramSettings.Settings.AvataData.Rows.RemoveAt(DGV_AvatarData.CurrentRow.Index);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgramSettings.Settings.AvataData.RejectChanges();
        }

    }
}
