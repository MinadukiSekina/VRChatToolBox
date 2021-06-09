namespace VRChatToolBox
{
    partial class SettingsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Return = new System.Windows.Forms.Button();
            this.PSC_LogEditedPath = new VRChatToolBox.PathSetControl();
            this.PSC_LogMovedPath = new VRChatToolBox.PathSetControl();
            this.PSC_PicturesMovedPath = new VRChatToolBox.PathSetControl();
            this.PSC_PicturesSavedPath = new VRChatToolBox.PathSetControl();
            this.PSC_LogSavedPath = new VRChatToolBox.PathSetControl();
            this.BT_Reset = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.PN_Function = new System.Windows.Forms.Panel();
            this.LB_F3 = new System.Windows.Forms.Label();
            this.LB_F2 = new System.Windows.Forms.Label();
            this.LB_F1 = new System.Windows.Forms.Label();
            this.LB_ESC = new System.Windows.Forms.Label();
            this.TC_Settings = new System.Windows.Forms.TabControl();
            this.LogTab = new System.Windows.Forms.TabPage();
            this.PictureTab = new System.Windows.Forms.TabPage();
            this.PSC_UpLoadedPicturesFolder = new VRChatToolBox.PathSetControl();
            this.PSC_SelectedPicturesFolder = new VRChatToolBox.PathSetControl();
            this.MetaTab = new System.Windows.Forms.TabPage();
            this.PSC_UpLoadedInfoFolder = new VRChatToolBox.PathSetControl();
            this.PSC_SelectedInfoFolder = new VRChatToolBox.PathSetControl();
            this.PN_Function.SuspendLayout();
            this.TC_Settings.SuspendLayout();
            this.LogTab.SuspendLayout();
            this.PictureTab.SuspendLayout();
            this.MetaTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Save
            // 
            this.BT_Save.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(444, 30);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(121, 34);
            this.BT_Save.TabIndex = 3;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Return
            // 
            this.BT_Return.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Return.Location = new System.Drawing.Point(170, 30);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(121, 34);
            this.BT_Return.TabIndex = 1;
            this.BT_Return.Text = "戻る";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // PSC_LogEditedPath
            // 
            this.PSC_LogEditedPath.Location = new System.Drawing.Point(4, 225);
            this.PSC_LogEditedPath.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_LogEditedPath.Name = "PSC_LogEditedPath";
            this.PSC_LogEditedPath.SelectedPath = "";
            this.PSC_LogEditedPath.Size = new System.Drawing.Size(798, 101);
            this.PSC_LogEditedPath.TabIndex = 2;
            this.PSC_LogEditedPath.Title = "編集したログの保存場所";
            // 
            // PSC_LogMovedPath
            // 
            this.PSC_LogMovedPath.Location = new System.Drawing.Point(4, 116);
            this.PSC_LogMovedPath.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_LogMovedPath.Name = "PSC_LogMovedPath";
            this.PSC_LogMovedPath.SelectedPath = "";
            this.PSC_LogMovedPath.Size = new System.Drawing.Size(798, 101);
            this.PSC_LogMovedPath.TabIndex = 1;
            this.PSC_LogMovedPath.Title = "VRChatログのコピー場所";
            // 
            // PSC_PicturesMovedPath
            // 
            this.PSC_PicturesMovedPath.Location = new System.Drawing.Point(4, 116);
            this.PSC_PicturesMovedPath.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_PicturesMovedPath.Name = "PSC_PicturesMovedPath";
            this.PSC_PicturesMovedPath.SelectedPath = "";
            this.PSC_PicturesMovedPath.Size = new System.Drawing.Size(798, 101);
            this.PSC_PicturesMovedPath.TabIndex = 1;
            this.PSC_PicturesMovedPath.Title = "整理した写真の保存場所";
            // 
            // PSC_PicturesSavedPath
            // 
            this.PSC_PicturesSavedPath.Location = new System.Drawing.Point(4, 7);
            this.PSC_PicturesSavedPath.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_PicturesSavedPath.Name = "PSC_PicturesSavedPath";
            this.PSC_PicturesSavedPath.SelectedPath = "";
            this.PSC_PicturesSavedPath.Size = new System.Drawing.Size(798, 101);
            this.PSC_PicturesSavedPath.TabIndex = 0;
            this.PSC_PicturesSavedPath.Title = "VRChat写真の場所";
            // 
            // PSC_LogSavedPath
            // 
            this.PSC_LogSavedPath.Location = new System.Drawing.Point(4, 7);
            this.PSC_LogSavedPath.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_LogSavedPath.Name = "PSC_LogSavedPath";
            this.PSC_LogSavedPath.SelectedPath = "";
            this.PSC_LogSavedPath.Size = new System.Drawing.Size(798, 101);
            this.PSC_LogSavedPath.TabIndex = 0;
            this.PSC_LogSavedPath.Title = "VRChatログの保存場所";
            // 
            // BT_Reset
            // 
            this.BT_Reset.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Reset.Location = new System.Drawing.Point(307, 30);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(121, 34);
            this.BT_Reset.TabIndex = 2;
            this.BT_Reset.Text = "初期化";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Cancel.Location = new System.Drawing.Point(32, 30);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(121, 34);
            this.BT_Cancel.TabIndex = 0;
            this.BT_Cancel.Text = "キャンセル";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // PN_Function
            // 
            this.PN_Function.Controls.Add(this.LB_F3);
            this.PN_Function.Controls.Add(this.LB_F2);
            this.PN_Function.Controls.Add(this.LB_F1);
            this.PN_Function.Controls.Add(this.LB_ESC);
            this.PN_Function.Controls.Add(this.BT_Save);
            this.PN_Function.Controls.Add(this.BT_Cancel);
            this.PN_Function.Controls.Add(this.BT_Return);
            this.PN_Function.Controls.Add(this.BT_Reset);
            this.PN_Function.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Function.Location = new System.Drawing.Point(0, 471);
            this.PN_Function.Name = "PN_Function";
            this.PN_Function.Size = new System.Drawing.Size(816, 76);
            this.PN_Function.TabIndex = 5;
            // 
            // LB_F3
            // 
            this.LB_F3.AutoSize = true;
            this.LB_F3.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_F3.Location = new System.Drawing.Point(441, 10);
            this.LB_F3.Name = "LB_F3";
            this.LB_F3.Size = new System.Drawing.Size(26, 17);
            this.LB_F3.TabIndex = 7;
            this.LB_F3.Text = "F3";
            // 
            // LB_F2
            // 
            this.LB_F2.AutoSize = true;
            this.LB_F2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_F2.Location = new System.Drawing.Point(304, 10);
            this.LB_F2.Name = "LB_F2";
            this.LB_F2.Size = new System.Drawing.Size(26, 17);
            this.LB_F2.TabIndex = 6;
            this.LB_F2.Text = "F2";
            // 
            // LB_F1
            // 
            this.LB_F1.AutoSize = true;
            this.LB_F1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_F1.Location = new System.Drawing.Point(167, 9);
            this.LB_F1.Name = "LB_F1";
            this.LB_F1.Size = new System.Drawing.Size(26, 17);
            this.LB_F1.TabIndex = 5;
            this.LB_F1.Text = "F1";
            // 
            // LB_ESC
            // 
            this.LB_ESC.AutoSize = true;
            this.LB_ESC.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_ESC.Location = new System.Drawing.Point(29, 9);
            this.LB_ESC.Name = "LB_ESC";
            this.LB_ESC.Size = new System.Drawing.Size(39, 17);
            this.LB_ESC.TabIndex = 4;
            this.LB_ESC.Text = "ESC";
            // 
            // TC_Settings
            // 
            this.TC_Settings.Controls.Add(this.LogTab);
            this.TC_Settings.Controls.Add(this.PictureTab);
            this.TC_Settings.Controls.Add(this.MetaTab);
            this.TC_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Settings.Location = new System.Drawing.Point(0, 0);
            this.TC_Settings.Name = "TC_Settings";
            this.TC_Settings.SelectedIndex = 0;
            this.TC_Settings.Size = new System.Drawing.Size(816, 547);
            this.TC_Settings.TabIndex = 2;
            // 
            // LogTab
            // 
            this.LogTab.Controls.Add(this.PSC_LogEditedPath);
            this.LogTab.Controls.Add(this.PSC_LogMovedPath);
            this.LogTab.Controls.Add(this.PSC_LogSavedPath);
            this.LogTab.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LogTab.Location = new System.Drawing.Point(4, 25);
            this.LogTab.Name = "LogTab";
            this.LogTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogTab.Size = new System.Drawing.Size(808, 518);
            this.LogTab.TabIndex = 0;
            this.LogTab.Text = "ログ出力";
            this.LogTab.UseVisualStyleBackColor = true;
            // 
            // PictureTab
            // 
            this.PictureTab.Controls.Add(this.PSC_UpLoadedPicturesFolder);
            this.PictureTab.Controls.Add(this.PSC_SelectedPicturesFolder);
            this.PictureTab.Controls.Add(this.PSC_PicturesSavedPath);
            this.PictureTab.Controls.Add(this.PSC_PicturesMovedPath);
            this.PictureTab.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.PictureTab.Location = new System.Drawing.Point(4, 25);
            this.PictureTab.Name = "PictureTab";
            this.PictureTab.Padding = new System.Windows.Forms.Padding(3);
            this.PictureTab.Size = new System.Drawing.Size(808, 518);
            this.PictureTab.TabIndex = 1;
            this.PictureTab.Text = "写真";
            this.PictureTab.UseVisualStyleBackColor = true;
            // 
            // PSC_UpLoadedPicturesFolder
            // 
            this.PSC_UpLoadedPicturesFolder.Location = new System.Drawing.Point(4, 334);
            this.PSC_UpLoadedPicturesFolder.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_UpLoadedPicturesFolder.Name = "PSC_UpLoadedPicturesFolder";
            this.PSC_UpLoadedPicturesFolder.SelectedPath = "";
            this.PSC_UpLoadedPicturesFolder.Size = new System.Drawing.Size(798, 101);
            this.PSC_UpLoadedPicturesFolder.TabIndex = 3;
            this.PSC_UpLoadedPicturesFolder.Title = "投稿した写真の保存先";
            // 
            // PSC_SelectedPicturesFolder
            // 
            this.PSC_SelectedPicturesFolder.Location = new System.Drawing.Point(4, 225);
            this.PSC_SelectedPicturesFolder.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_SelectedPicturesFolder.Name = "PSC_SelectedPicturesFolder";
            this.PSC_SelectedPicturesFolder.SelectedPath = "";
            this.PSC_SelectedPicturesFolder.Size = new System.Drawing.Size(798, 101);
            this.PSC_SelectedPicturesFolder.TabIndex = 2;
            this.PSC_SelectedPicturesFolder.Title = "選択した写真の保存先";
            // 
            // MetaTab
            // 
            this.MetaTab.Controls.Add(this.PSC_UpLoadedInfoFolder);
            this.MetaTab.Controls.Add(this.PSC_SelectedInfoFolder);
            this.MetaTab.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.MetaTab.Location = new System.Drawing.Point(4, 25);
            this.MetaTab.Name = "MetaTab";
            this.MetaTab.Padding = new System.Windows.Forms.Padding(3);
            this.MetaTab.Size = new System.Drawing.Size(808, 518);
            this.MetaTab.TabIndex = 2;
            this.MetaTab.Text = "メタデータ";
            this.MetaTab.UseVisualStyleBackColor = true;
            // 
            // PSC_UpLoadedInfoFolder
            // 
            this.PSC_UpLoadedInfoFolder.Location = new System.Drawing.Point(4, 116);
            this.PSC_UpLoadedInfoFolder.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_UpLoadedInfoFolder.Name = "PSC_UpLoadedInfoFolder";
            this.PSC_UpLoadedInfoFolder.SelectedPath = "";
            this.PSC_UpLoadedInfoFolder.Size = new System.Drawing.Size(798, 101);
            this.PSC_UpLoadedInfoFolder.TabIndex = 1;
            this.PSC_UpLoadedInfoFolder.Title = "投稿した写真のメタデータの保存場所";
            // 
            // PSC_SelectedInfoFolder
            // 
            this.PSC_SelectedInfoFolder.Location = new System.Drawing.Point(4, 7);
            this.PSC_SelectedInfoFolder.Margin = new System.Windows.Forms.Padding(4);
            this.PSC_SelectedInfoFolder.Name = "PSC_SelectedInfoFolder";
            this.PSC_SelectedInfoFolder.SelectedPath = "";
            this.PSC_SelectedInfoFolder.Size = new System.Drawing.Size(798, 101);
            this.PSC_SelectedInfoFolder.TabIndex = 0;
            this.PSC_SelectedInfoFolder.Title = "選択した写真のメタデータの保存場所";
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 547);
            this.Controls.Add(this.PN_Function);
            this.Controls.Add(this.TC_Settings);
            this.KeyPreview = true;
            this.Name = "SettingsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SettingsEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsEditor_KeyDown);
            this.PN_Function.ResumeLayout(false);
            this.PN_Function.PerformLayout();
            this.TC_Settings.ResumeLayout(false);
            this.LogTab.ResumeLayout(false);
            this.PictureTab.ResumeLayout(false);
            this.MetaTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PathSetControl PSC_LogSavedPath;
        private PathSetControl PSC_PicturesSavedPath;
        private PathSetControl PSC_PicturesMovedPath;
        private PathSetControl PSC_LogMovedPath;
        private PathSetControl PSC_LogEditedPath;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Return;
        private System.Windows.Forms.Button BT_Reset;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Panel PN_Function;
        private System.Windows.Forms.Label LB_F3;
        private System.Windows.Forms.Label LB_F2;
        private System.Windows.Forms.Label LB_F1;
        private System.Windows.Forms.Label LB_ESC;
        private System.Windows.Forms.TabControl TC_Settings;
        private System.Windows.Forms.TabPage PictureTab;
        private System.Windows.Forms.TabPage LogTab;
        private PathSetControl PSC_UpLoadedPicturesFolder;
        private PathSetControl PSC_SelectedPicturesFolder;
        private System.Windows.Forms.TabPage MetaTab;
        private PathSetControl PSC_UpLoadedInfoFolder;
        private PathSetControl PSC_SelectedInfoFolder;
    }
}