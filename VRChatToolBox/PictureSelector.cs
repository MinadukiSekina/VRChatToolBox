﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VRChatToolBox
{
    public partial class PictureSelector : Form
    {
        private string MetaDataFileName { get; set; } 

        public PictureSelector()
        {
            InitializeComponent();
        }

        private void PictureSelector_Load(object sender, EventArgs e)
        {
                pictureExplorer1.Init(ProgramSettings.Settings.DesignatedPicturesSavedFolder, PB_Display, this);
                pictureExplorer2.Init(ProgramSettings.Settings.DesignatedPicturesMovedFolder, PB_Display, this);
        }

        private void PB_Display_MouseDown(object sender, MouseEventArgs e)
        {
            DataObject dataObject = new DataObject(DataFormats.FileDrop, PB_Display.ImageLocation);
            PB_Display.DoDragDrop(dataObject, DragDropEffects.Copy);
        }

        // 写真選択後
        internal void PictureSelected()
        {
            try
            {
                // 写真のファイル名の取得と、メタデータの設定
                string pictureName = Path.GetFileName(PB_Display.ImageLocation);
                MetaDataFileName = pictureName.Replace("png", "xml");
                string MetaDataFilePath = File.Exists($"{ProgramSettings.Settings.DesignatedPictureInfoPath}\\{MetaDataFileName}")
                    ? $"{ProgramSettings.Settings.DesignatedPictureInfoPath}\\{MetaDataFileName}"
                    : $"{ProgramSettings.Settings.DesignatedUpLoadedInfoPath}\\{MetaDataFileName}";

                // 年月日の取得
                for (int i = 0; i <= 2; i++)
                {
                    pictureName = i == 2 ? pictureName.Remove(pictureName.IndexOf("_")) : pictureName.Substring(pictureName.IndexOf("_") + 1);
                }
                string pictureDate = pictureName.Replace("-", "");

                // ワールド候補リストの設定
                Li_WorldList.Items.Clear();
                Li_WorldList.Items.AddRange(PicturesOrganizer.GetWorldList(pictureDate));

                // 内容の読み込み（あれば）
                PictureInfo pictureInfo = PictureInfo.LoadInfo(MetaDataFilePath);
                TB_WorldName.Text = pictureInfo.WorldName;
                TB_AuthorName.Text = pictureInfo.WorldAuthor;
                TB_Sentence.Lines = pictureInfo.TweetContents;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // ワールド名選択
        private void Li_WorldList_DoubleClick(object sender, EventArgs e)
        {
            TB_WorldName.Text = Li_WorldList.SelectedItem.ToString();
        }
        // 閉じる
        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Twitterを開く
        private void BT_OpenTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/home");
        }
        // VRChatを開く：Home直開きは、何かしらの向こうのチェックが走って嫌な予感がしたのでやめました
        private void BT_OpenVRCHome_Click(object sender, EventArgs e)
        {
            Process.Start("https://hello.vrchat.com");
        }
        // 投稿後の処理
        private void BT_Move_Click(object sender, EventArgs e)
        {
            try
            {
                // 写真を移動して、メタデータも移動
                PicturesOrganizer.MoveUpLoadedPicture(PB_Display.ImageLocation);
                LogEditor.MoveMetaDataFile($"{ProgramSettings.Settings.DesignatedPictureInfoPath}\\{MetaDataFileName}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 写真を選抜して保存：メタデータも作成
        private void BT_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // インスタンスにメタデータを格納
                PictureInfo pictureInfo = new PictureInfo
                {
                    WorldName = TB_WorldName.Text.Trim(),
                    WorldAuthor = TB_AuthorName.Text.Trim(),
                    TweetContents = TB_Sentence.Lines
                };

                string metaDataFilePath = $"{ProgramSettings.Settings.DesignatedPictureInfoPath}\\{MetaDataFileName}";

                // 写真をコピーして、メタデータを作成
                PicturesOrganizer.MoveSelectedPicture(PB_Display.ImageLocation);
                PictureInfo.WriteInfo(metaDataFilePath, pictureInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
