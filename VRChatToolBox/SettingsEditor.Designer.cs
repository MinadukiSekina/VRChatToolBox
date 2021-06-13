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
            this.LB_Format = new System.Windows.Forms.Label();
            this.LB_Notification = new System.Windows.Forms.Label();
            this.BT_RemoveRow = new System.Windows.Forms.Button();
            this.BT_AddRow = new System.Windows.Forms.Button();
            this.DGV_AvatarData = new System.Windows.Forms.DataGridView();
            this.AvatarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvatarAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TweetBox1 = new VRChatToolBox.TweetBox();
            this.PSC_UpLoadedInfoFolder = new VRChatToolBox.PathSetControl();
            this.PSC_SelectedInfoFolder = new VRChatToolBox.PathSetControl();
            this.PN_Function.SuspendLayout();
            this.TC_Settings.SuspendLayout();
            this.LogTab.SuspendLayout();
            this.PictureTab.SuspendLayout();
            this.MetaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AvatarData)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Save
            // 
            this.BT_Save.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(333, 24);
            this.BT_Save.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(91, 27);
            this.BT_Save.TabIndex = 3;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Return
            // 
            this.BT_Return.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Return.Location = new System.Drawing.Point(128, 24);
            this.BT_Return.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(91, 27);
            this.BT_Return.TabIndex = 1;
            this.BT_Return.Text = "戻る";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // PSC_LogEditedPath
            // 
            this.PSC_LogEditedPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_LogEditedPath.Location = new System.Drawing.Point(3, 180);
            this.PSC_LogEditedPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_LogEditedPath.Name = "PSC_LogEditedPath";
            this.PSC_LogEditedPath.SelectedPath = "";
            this.PSC_LogEditedPath.Size = new System.Drawing.Size(682, 81);
            this.PSC_LogEditedPath.TabIndex = 2;
            this.PSC_LogEditedPath.Title = "編集したログの保存場所";
            // 
            // PSC_LogMovedPath
            // 
            this.PSC_LogMovedPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_LogMovedPath.Location = new System.Drawing.Point(3, 93);
            this.PSC_LogMovedPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_LogMovedPath.Name = "PSC_LogMovedPath";
            this.PSC_LogMovedPath.SelectedPath = "";
            this.PSC_LogMovedPath.Size = new System.Drawing.Size(682, 81);
            this.PSC_LogMovedPath.TabIndex = 1;
            this.PSC_LogMovedPath.Title = "VRChatログのコピー場所";
            // 
            // PSC_PicturesMovedPath
            // 
            this.PSC_PicturesMovedPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_PicturesMovedPath.Location = new System.Drawing.Point(3, 93);
            this.PSC_PicturesMovedPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_PicturesMovedPath.Name = "PSC_PicturesMovedPath";
            this.PSC_PicturesMovedPath.SelectedPath = "";
            this.PSC_PicturesMovedPath.Size = new System.Drawing.Size(682, 81);
            this.PSC_PicturesMovedPath.TabIndex = 1;
            this.PSC_PicturesMovedPath.Title = "整理した写真の保存場所";
            // 
            // PSC_PicturesSavedPath
            // 
            this.PSC_PicturesSavedPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_PicturesSavedPath.Location = new System.Drawing.Point(3, 6);
            this.PSC_PicturesSavedPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_PicturesSavedPath.Name = "PSC_PicturesSavedPath";
            this.PSC_PicturesSavedPath.SelectedPath = "";
            this.PSC_PicturesSavedPath.Size = new System.Drawing.Size(682, 81);
            this.PSC_PicturesSavedPath.TabIndex = 0;
            this.PSC_PicturesSavedPath.Title = "VRChat写真の場所";
            // 
            // PSC_LogSavedPath
            // 
            this.PSC_LogSavedPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_LogSavedPath.Location = new System.Drawing.Point(3, 6);
            this.PSC_LogSavedPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_LogSavedPath.Name = "PSC_LogSavedPath";
            this.PSC_LogSavedPath.SelectedPath = "";
            this.PSC_LogSavedPath.Size = new System.Drawing.Size(682, 81);
            this.PSC_LogSavedPath.TabIndex = 0;
            this.PSC_LogSavedPath.Title = "VRChatログの保存場所";
            // 
            // BT_Reset
            // 
            this.BT_Reset.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Reset.Location = new System.Drawing.Point(230, 24);
            this.BT_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(91, 27);
            this.BT_Reset.TabIndex = 2;
            this.BT_Reset.Text = "初期化";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Cancel.Location = new System.Drawing.Point(24, 24);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(91, 27);
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
            this.PN_Function.Location = new System.Drawing.Point(0, 377);
            this.PN_Function.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Function.Name = "PN_Function";
            this.PN_Function.Size = new System.Drawing.Size(696, 61);
            this.PN_Function.TabIndex = 5;
            // 
            // LB_F3
            // 
            this.LB_F3.AutoSize = true;
            this.LB_F3.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_F3.Location = new System.Drawing.Point(331, 8);
            this.LB_F3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_F3.Name = "LB_F3";
            this.LB_F3.Size = new System.Drawing.Size(22, 14);
            this.LB_F3.TabIndex = 7;
            this.LB_F3.Text = "F3";
            // 
            // LB_F2
            // 
            this.LB_F2.AutoSize = true;
            this.LB_F2.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_F2.Location = new System.Drawing.Point(228, 8);
            this.LB_F2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_F2.Name = "LB_F2";
            this.LB_F2.Size = new System.Drawing.Size(22, 14);
            this.LB_F2.TabIndex = 6;
            this.LB_F2.Text = "F2";
            // 
            // LB_F1
            // 
            this.LB_F1.AutoSize = true;
            this.LB_F1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_F1.Location = new System.Drawing.Point(125, 7);
            this.LB_F1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_F1.Name = "LB_F1";
            this.LB_F1.Size = new System.Drawing.Size(22, 14);
            this.LB_F1.TabIndex = 5;
            this.LB_F1.Text = "F1";
            // 
            // LB_ESC
            // 
            this.LB_ESC.AutoSize = true;
            this.LB_ESC.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_ESC.Location = new System.Drawing.Point(22, 7);
            this.LB_ESC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ESC.Name = "LB_ESC";
            this.LB_ESC.Size = new System.Drawing.Size(32, 14);
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
            this.TC_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.TC_Settings.Name = "TC_Settings";
            this.TC_Settings.SelectedIndex = 0;
            this.TC_Settings.Size = new System.Drawing.Size(696, 438);
            this.TC_Settings.TabIndex = 2;
            // 
            // LogTab
            // 
            this.LogTab.Controls.Add(this.PSC_LogEditedPath);
            this.LogTab.Controls.Add(this.PSC_LogMovedPath);
            this.LogTab.Controls.Add(this.PSC_LogSavedPath);
            this.LogTab.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LogTab.Location = new System.Drawing.Point(4, 22);
            this.LogTab.Margin = new System.Windows.Forms.Padding(2);
            this.LogTab.Name = "LogTab";
            this.LogTab.Padding = new System.Windows.Forms.Padding(2);
            this.LogTab.Size = new System.Drawing.Size(688, 412);
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
            this.PictureTab.Location = new System.Drawing.Point(4, 22);
            this.PictureTab.Margin = new System.Windows.Forms.Padding(2);
            this.PictureTab.Name = "PictureTab";
            this.PictureTab.Padding = new System.Windows.Forms.Padding(2);
            this.PictureTab.Size = new System.Drawing.Size(688, 412);
            this.PictureTab.TabIndex = 1;
            this.PictureTab.Text = "写真";
            this.PictureTab.UseVisualStyleBackColor = true;
            // 
            // PSC_UpLoadedPicturesFolder
            // 
            this.PSC_UpLoadedPicturesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_UpLoadedPicturesFolder.Location = new System.Drawing.Point(3, 267);
            this.PSC_UpLoadedPicturesFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_UpLoadedPicturesFolder.Name = "PSC_UpLoadedPicturesFolder";
            this.PSC_UpLoadedPicturesFolder.SelectedPath = "";
            this.PSC_UpLoadedPicturesFolder.Size = new System.Drawing.Size(682, 81);
            this.PSC_UpLoadedPicturesFolder.TabIndex = 3;
            this.PSC_UpLoadedPicturesFolder.Title = "投稿した写真の保存先";
            // 
            // PSC_SelectedPicturesFolder
            // 
            this.PSC_SelectedPicturesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_SelectedPicturesFolder.Location = new System.Drawing.Point(3, 180);
            this.PSC_SelectedPicturesFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_SelectedPicturesFolder.Name = "PSC_SelectedPicturesFolder";
            this.PSC_SelectedPicturesFolder.SelectedPath = "";
            this.PSC_SelectedPicturesFolder.Size = new System.Drawing.Size(682, 81);
            this.PSC_SelectedPicturesFolder.TabIndex = 2;
            this.PSC_SelectedPicturesFolder.Title = "選択した写真の保存先";
            // 
            // MetaTab
            // 
            this.MetaTab.Controls.Add(this.LB_Format);
            this.MetaTab.Controls.Add(this.LB_Notification);
            this.MetaTab.Controls.Add(this.BT_RemoveRow);
            this.MetaTab.Controls.Add(this.BT_AddRow);
            this.MetaTab.Controls.Add(this.DGV_AvatarData);
            this.MetaTab.Controls.Add(this.TweetBox1);
            this.MetaTab.Controls.Add(this.PSC_UpLoadedInfoFolder);
            this.MetaTab.Controls.Add(this.PSC_SelectedInfoFolder);
            this.MetaTab.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.MetaTab.Location = new System.Drawing.Point(4, 22);
            this.MetaTab.Margin = new System.Windows.Forms.Padding(2);
            this.MetaTab.Name = "MetaTab";
            this.MetaTab.Padding = new System.Windows.Forms.Padding(2);
            this.MetaTab.Size = new System.Drawing.Size(688, 412);
            this.MetaTab.TabIndex = 2;
            this.MetaTab.Text = "メタデータ";
            this.MetaTab.UseVisualStyleBackColor = true;
            // 
            // LB_Format
            // 
            this.LB_Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Format.AutoSize = true;
            this.LB_Format.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_Format.Location = new System.Drawing.Point(9, 185);
            this.LB_Format.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Format.Name = "LB_Format";
            this.LB_Format.Size = new System.Drawing.Size(107, 16);
            this.LB_Format.TabIndex = 11;
            this.LB_Format.Text = "投稿フォーマット";
            // 
            // LB_Notification
            // 
            this.LB_Notification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Notification.AutoSize = true;
            this.LB_Notification.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_Notification.Location = new System.Drawing.Point(120, 186);
            this.LB_Notification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Notification.Name = "LB_Notification";
            this.LB_Notification.Size = new System.Drawing.Size(115, 14);
            this.LB_Notification.TabIndex = 10;
            this.LB_Notification.Text = "Ctrl + Enterで改行";
            // 
            // BT_RemoveRow
            // 
            this.BT_RemoveRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_RemoveRow.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_RemoveRow.Location = new System.Drawing.Point(584, 313);
            this.BT_RemoveRow.Margin = new System.Windows.Forms.Padding(2);
            this.BT_RemoveRow.Name = "BT_RemoveRow";
            this.BT_RemoveRow.Size = new System.Drawing.Size(91, 27);
            this.BT_RemoveRow.TabIndex = 9;
            this.BT_RemoveRow.TabStop = false;
            this.BT_RemoveRow.Text = "削除";
            this.BT_RemoveRow.UseVisualStyleBackColor = true;
            this.BT_RemoveRow.Click += new System.EventHandler(this.BT_RemoveRow_Click);
            // 
            // BT_AddRow
            // 
            this.BT_AddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_AddRow.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_AddRow.Location = new System.Drawing.Point(317, 313);
            this.BT_AddRow.Margin = new System.Windows.Forms.Padding(2);
            this.BT_AddRow.Name = "BT_AddRow";
            this.BT_AddRow.Size = new System.Drawing.Size(91, 27);
            this.BT_AddRow.TabIndex = 8;
            this.BT_AddRow.TabStop = false;
            this.BT_AddRow.Text = "追加";
            this.BT_AddRow.UseVisualStyleBackColor = true;
            this.BT_AddRow.Click += new System.EventHandler(this.BT_AddRow_Click);
            // 
            // DGV_AvatarData
            // 
            this.DGV_AvatarData.AllowUserToAddRows = false;
            this.DGV_AvatarData.AllowUserToDeleteRows = false;
            this.DGV_AvatarData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_AvatarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AvatarData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvatarName,
            this.AvatarAuthor});
            this.DGV_AvatarData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_AvatarData.Location = new System.Drawing.Point(318, 203);
            this.DGV_AvatarData.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_AvatarData.Name = "DGV_AvatarData";
            this.DGV_AvatarData.RowHeadersVisible = false;
            this.DGV_AvatarData.RowTemplate.Height = 24;
            this.DGV_AvatarData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_AvatarData.Size = new System.Drawing.Size(356, 105);
            this.DGV_AvatarData.TabIndex = 3;
            // 
            // AvatarName
            // 
            this.AvatarName.DataPropertyName = "AvatarName";
            this.AvatarName.HeaderText = "アバター名";
            this.AvatarName.Name = "AvatarName";
            this.AvatarName.Width = 200;
            // 
            // AvatarAuthor
            // 
            this.AvatarAuthor.DataPropertyName = "AvatarAuthor";
            this.AvatarAuthor.HeaderText = "作者";
            this.AvatarAuthor.Name = "AvatarAuthor";
            this.AvatarAuthor.Width = 150;
            // 
            // TweetBox1
            // 
            this.TweetBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TweetBox1.Location = new System.Drawing.Point(12, 203);
            this.TweetBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TweetBox1.Multiline = true;
            this.TweetBox1.Name = "TweetBox1";
            this.TweetBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TweetBox1.Size = new System.Drawing.Size(294, 138);
            this.TweetBox1.TabIndex = 2;
            this.TweetBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TweetBox1_KeyDown);
            // 
            // PSC_UpLoadedInfoFolder
            // 
            this.PSC_UpLoadedInfoFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_UpLoadedInfoFolder.Location = new System.Drawing.Point(3, 93);
            this.PSC_UpLoadedInfoFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_UpLoadedInfoFolder.Name = "PSC_UpLoadedInfoFolder";
            this.PSC_UpLoadedInfoFolder.SelectedPath = "";
            this.PSC_UpLoadedInfoFolder.Size = new System.Drawing.Size(682, 81);
            this.PSC_UpLoadedInfoFolder.TabIndex = 1;
            this.PSC_UpLoadedInfoFolder.Title = "投稿した写真のメタデータの保存場所";
            // 
            // PSC_SelectedInfoFolder
            // 
            this.PSC_SelectedInfoFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSC_SelectedInfoFolder.Location = new System.Drawing.Point(3, 6);
            this.PSC_SelectedInfoFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSC_SelectedInfoFolder.Name = "PSC_SelectedInfoFolder";
            this.PSC_SelectedInfoFolder.SelectedPath = "";
            this.PSC_SelectedInfoFolder.Size = new System.Drawing.Size(682, 81);
            this.PSC_SelectedInfoFolder.TabIndex = 0;
            this.PSC_SelectedInfoFolder.Title = "選択した写真のメタデータの保存場所";
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 438);
            this.Controls.Add(this.PN_Function);
            this.Controls.Add(this.TC_Settings);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsEditor_FormClosing);
            this.Load += new System.EventHandler(this.SettingsEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsEditor_KeyDown);
            this.PN_Function.ResumeLayout(false);
            this.PN_Function.PerformLayout();
            this.TC_Settings.ResumeLayout(false);
            this.LogTab.ResumeLayout(false);
            this.PictureTab.ResumeLayout(false);
            this.MetaTab.ResumeLayout(false);
            this.MetaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AvatarData)).EndInit();
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
        private TweetBox TweetBox1;
        private System.Windows.Forms.DataGridView DGV_AvatarData;
        private System.Windows.Forms.Button BT_AddRow;
        private System.Windows.Forms.Button BT_RemoveRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvatarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvatarAuthor;
        private System.Windows.Forms.Label LB_Notification;
        private System.Windows.Forms.Label LB_Format;
    }
}