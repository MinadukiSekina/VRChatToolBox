namespace VRChatToolBox
{
    partial class PictureSelector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureSelector));
            this.SpC0 = new System.Windows.Forms.SplitContainer();
            this.LB_AvatarAuthor = new System.Windows.Forms.Label();
            this.TB_AvatarAuthor = new System.Windows.Forms.TextBox();
            this.LB_AvatarName = new System.Windows.Forms.Label();
            this.TB_AvatarName = new System.Windows.Forms.TextBox();
            this.LB_WorldList = new System.Windows.Forms.Label();
            this.TB_Sentence = new System.Windows.Forms.TextBox();
            this.LB_AuthorName = new System.Windows.Forms.Label();
            this.TB_WorldAuthorName = new System.Windows.Forms.TextBox();
            this.LB_WorldName = new System.Windows.Forms.Label();
            this.TB_WorldName = new System.Windows.Forms.TextBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.Li_WorldList = new System.Windows.Forms.ListBox();
            this.BT_OpenTwitter = new System.Windows.Forms.Button();
            this.BT_OpenVRCHome = new System.Windows.Forms.Button();
            this.BT_Move = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.PB_Display = new System.Windows.Forms.PictureBox();
            this.DT_DirectoryList = new VRChatToolBox.DirectoryTreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PN_Menu = new System.Windows.Forms.Panel();
            this.TB_FolderPath = new System.Windows.Forms.TextBox();
            this.BT_UP = new System.Windows.Forms.Button();
            this.FV_FileList = new VRChatToolBox.FileListView();
            this.ViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).BeginInit();
            this.SpC0.Panel1.SuspendLayout();
            this.SpC0.Panel2.SuspendLayout();
            this.SpC0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Display)).BeginInit();
            this.PN_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpC0
            // 
            this.SpC0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpC0.IsSplitterFixed = true;
            this.SpC0.Location = new System.Drawing.Point(0, 0);
            this.SpC0.Name = "SpC0";
            // 
            // SpC0.Panel1
            // 
            this.SpC0.Panel1.Controls.Add(this.FV_FileList);
            this.SpC0.Panel1.Controls.Add(this.PN_Menu);
            this.SpC0.Panel1.Controls.Add(this.splitter1);
            this.SpC0.Panel1.Controls.Add(this.DT_DirectoryList);
            // 
            // SpC0.Panel2
            // 
            this.SpC0.Panel2.Controls.Add(this.LB_AvatarAuthor);
            this.SpC0.Panel2.Controls.Add(this.TB_AvatarAuthor);
            this.SpC0.Panel2.Controls.Add(this.LB_AvatarName);
            this.SpC0.Panel2.Controls.Add(this.TB_AvatarName);
            this.SpC0.Panel2.Controls.Add(this.LB_WorldList);
            this.SpC0.Panel2.Controls.Add(this.LB_AuthorName);
            this.SpC0.Panel2.Controls.Add(this.TB_WorldAuthorName);
            this.SpC0.Panel2.Controls.Add(this.LB_WorldName);
            this.SpC0.Panel2.Controls.Add(this.TB_WorldName);
            this.SpC0.Panel2.Controls.Add(this.Li_WorldList);
            this.SpC0.Panel2.Controls.Add(this.PB_Display);
            this.SpC0.Panel2.Controls.Add(this.panel1);
            this.SpC0.Panel2.Controls.Add(this.TB_Sentence);
            this.SpC0.Size = new System.Drawing.Size(1284, 822);
            this.SpC0.SplitterDistance = 782;
            this.SpC0.TabIndex = 0;
            this.SpC0.TabStop = false;
            // 
            // LB_AvatarAuthor
            // 
            this.LB_AvatarAuthor.AutoSize = true;
            this.LB_AvatarAuthor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AvatarAuthor.Location = new System.Drawing.Point(9, 547);
            this.LB_AvatarAuthor.Name = "LB_AvatarAuthor";
            this.LB_AvatarAuthor.Size = new System.Drawing.Size(79, 20);
            this.LB_AvatarAuthor.TabIndex = 16;
            this.LB_AvatarAuthor.Text = "製作者：";
            // 
            // TB_AvatarAuthor
            // 
            this.TB_AvatarAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_AvatarAuthor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_AvatarAuthor.Location = new System.Drawing.Point(103, 544);
            this.TB_AvatarAuthor.Name = "TB_AvatarAuthor";
            this.TB_AvatarAuthor.Size = new System.Drawing.Size(383, 27);
            this.TB_AvatarAuthor.TabIndex = 3;
            // 
            // LB_AvatarName
            // 
            this.LB_AvatarName.AutoSize = true;
            this.LB_AvatarName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AvatarName.Location = new System.Drawing.Point(9, 514);
            this.LB_AvatarName.Name = "LB_AvatarName";
            this.LB_AvatarName.Size = new System.Drawing.Size(81, 20);
            this.LB_AvatarName.TabIndex = 14;
            this.LB_AvatarName.Text = "アバター：";
            // 
            // TB_AvatarName
            // 
            this.TB_AvatarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_AvatarName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_AvatarName.Location = new System.Drawing.Point(103, 511);
            this.TB_AvatarName.Name = "TB_AvatarName";
            this.TB_AvatarName.Size = new System.Drawing.Size(383, 27);
            this.TB_AvatarName.TabIndex = 2;
            // 
            // LB_WorldList
            // 
            this.LB_WorldList.AutoSize = true;
            this.LB_WorldList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_WorldList.Location = new System.Drawing.Point(9, 291);
            this.LB_WorldList.Name = "LB_WorldList";
            this.LB_WorldList.Size = new System.Drawing.Size(110, 20);
            this.LB_WorldList.TabIndex = 12;
            this.LB_WorldList.Text = "ワールド候補";
            // 
            // TB_Sentence
            // 
            this.TB_Sentence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Sentence.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_Sentence.Location = new System.Drawing.Point(9, 577);
            this.TB_Sentence.Multiline = true;
            this.TB_Sentence.Name = "TB_Sentence";
            this.TB_Sentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Sentence.Size = new System.Drawing.Size(477, 149);
            this.TB_Sentence.TabIndex = 4;
            // 
            // LB_AuthorName
            // 
            this.LB_AuthorName.AutoSize = true;
            this.LB_AuthorName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AuthorName.Location = new System.Drawing.Point(9, 481);
            this.LB_AuthorName.Name = "LB_AuthorName";
            this.LB_AuthorName.Size = new System.Drawing.Size(79, 20);
            this.LB_AuthorName.TabIndex = 10;
            this.LB_AuthorName.Text = "製作者：";
            // 
            // TB_WorldAuthorName
            // 
            this.TB_WorldAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_WorldAuthorName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_WorldAuthorName.Location = new System.Drawing.Point(103, 478);
            this.TB_WorldAuthorName.Name = "TB_WorldAuthorName";
            this.TB_WorldAuthorName.Size = new System.Drawing.Size(383, 27);
            this.TB_WorldAuthorName.TabIndex = 1;
            // 
            // LB_WorldName
            // 
            this.LB_WorldName.AutoSize = true;
            this.LB_WorldName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_WorldName.Location = new System.Drawing.Point(9, 448);
            this.LB_WorldName.Name = "LB_WorldName";
            this.LB_WorldName.Size = new System.Drawing.Size(80, 20);
            this.LB_WorldName.TabIndex = 8;
            this.LB_WorldName.Text = "ワールド：";
            // 
            // TB_WorldName
            // 
            this.TB_WorldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_WorldName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_WorldName.Location = new System.Drawing.Point(103, 445);
            this.TB_WorldName.Name = "TB_WorldName";
            this.TB_WorldName.Size = new System.Drawing.Size(383, 27);
            this.TB_WorldName.TabIndex = 0;
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Close.Location = new System.Drawing.Point(335, 11);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(147, 31);
            this.BT_Close.TabIndex = 6;
            this.BT_Close.Text = "閉じる";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // Li_WorldList
            // 
            this.Li_WorldList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Li_WorldList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Li_WorldList.FormattingEnabled = true;
            this.Li_WorldList.ItemHeight = 20;
            this.Li_WorldList.Location = new System.Drawing.Point(9, 314);
            this.Li_WorldList.Name = "Li_WorldList";
            this.Li_WorldList.Size = new System.Drawing.Size(477, 124);
            this.Li_WorldList.TabIndex = 5;
            this.Li_WorldList.TabStop = false;
            this.Li_WorldList.DoubleClick += new System.EventHandler(this.Li_WorldList_DoubleClick);
            // 
            // BT_OpenTwitter
            // 
            this.BT_OpenTwitter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_OpenTwitter.Location = new System.Drawing.Point(29, 48);
            this.BT_OpenTwitter.Name = "BT_OpenTwitter";
            this.BT_OpenTwitter.Size = new System.Drawing.Size(147, 31);
            this.BT_OpenTwitter.TabIndex = 4;
            this.BT_OpenTwitter.Text = "Twitter";
            this.BT_OpenTwitter.UseVisualStyleBackColor = true;
            this.BT_OpenTwitter.Click += new System.EventHandler(this.BT_OpenTwitter_Click);
            // 
            // BT_OpenVRCHome
            // 
            this.BT_OpenVRCHome.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_OpenVRCHome.Location = new System.Drawing.Point(182, 48);
            this.BT_OpenVRCHome.Name = "BT_OpenVRCHome";
            this.BT_OpenVRCHome.Size = new System.Drawing.Size(147, 31);
            this.BT_OpenVRCHome.TabIndex = 3;
            this.BT_OpenVRCHome.Text = "VRChat Home";
            this.BT_OpenVRCHome.UseVisualStyleBackColor = true;
            this.BT_OpenVRCHome.Click += new System.EventHandler(this.BT_OpenVRCHome_Click);
            // 
            // BT_Move
            // 
            this.BT_Move.Enabled = false;
            this.BT_Move.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Move.Location = new System.Drawing.Point(182, 11);
            this.BT_Move.Name = "BT_Move";
            this.BT_Move.Size = new System.Drawing.Size(147, 31);
            this.BT_Move.TabIndex = 2;
            this.BT_Move.Text = "投稿済へ";
            this.BT_Move.UseVisualStyleBackColor = true;
            this.BT_Move.Click += new System.EventHandler(this.BT_Move_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Enabled = false;
            this.BT_Save.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(29, 11);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(147, 31);
            this.BT_Save.TabIndex = 1;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // PB_Display
            // 
            this.PB_Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Display.Location = new System.Drawing.Point(9, 8);
            this.PB_Display.Name = "PB_Display";
            this.PB_Display.Size = new System.Drawing.Size(480, 270);
            this.PB_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Display.TabIndex = 0;
            this.PB_Display.TabStop = false;
            this.PB_Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Display_MouseDown);
            // 
            // DT_DirectoryList
            // 
            this.DT_DirectoryList.Dock = System.Windows.Forms.DockStyle.Left;
            this.DT_DirectoryList.Location = new System.Drawing.Point(0, 0);
            this.DT_DirectoryList.Name = "DT_DirectoryList";
            this.DT_DirectoryList.Size = new System.Drawing.Size(177, 822);
            this.DT_DirectoryList.TabIndex = 0;
            this.DT_DirectoryList.TabStop = false;
            this.DT_DirectoryList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DT_DirectoryList_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(177, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 822);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // PN_Menu
            // 
            this.PN_Menu.Controls.Add(this.BT_UP);
            this.PN_Menu.Controls.Add(this.TB_FolderPath);
            this.PN_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Menu.Location = new System.Drawing.Point(180, 0);
            this.PN_Menu.Name = "PN_Menu";
            this.PN_Menu.Size = new System.Drawing.Size(602, 61);
            this.PN_Menu.TabIndex = 2;
            // 
            // TB_FolderPath
            // 
            this.TB_FolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_FolderPath.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.TB_FolderPath.Location = new System.Drawing.Point(59, 17);
            this.TB_FolderPath.Name = "TB_FolderPath";
            this.TB_FolderPath.Size = new System.Drawing.Size(528, 27);
            this.TB_FolderPath.TabIndex = 0;
            this.TB_FolderPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_FolderPath_KeyDown);
            this.TB_FolderPath.Validating += new System.ComponentModel.CancelEventHandler(this.TB_FolderPath_Validating);
            // 
            // BT_UP
            // 
            this.BT_UP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_UP.Image = global::VRChatToolBox.Properties.Resources.sozai_cman_jp_20210605100828;
            this.BT_UP.Location = new System.Drawing.Point(12, 10);
            this.BT_UP.Name = "BT_UP";
            this.BT_UP.Size = new System.Drawing.Size(41, 40);
            this.BT_UP.TabIndex = 1;
            this.BT_UP.UseVisualStyleBackColor = true;
            this.BT_UP.Click += new System.EventHandler(this.BT_UP_Click);
            // 
            // FV_FileList
            // 
            this.FV_FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FV_FileList.HideSelection = false;
            this.FV_FileList.LargeImageList = this.ViewImageList;
            this.FV_FileList.Location = new System.Drawing.Point(180, 61);
            this.FV_FileList.MultiSelect = false;
            this.FV_FileList.Name = "FV_FileList";
            this.FV_FileList.Size = new System.Drawing.Size(602, 761);
            this.FV_FileList.SmallImageList = this.ViewImageList;
            this.FV_FileList.TabIndex = 3;
            this.FV_FileList.TabStop = false;
            this.FV_FileList.UseCompatibleStateImageBehavior = false;
            this.FV_FileList.Click += new System.EventHandler(this.FV_FileList_Click);
            this.FV_FileList.DoubleClick += new System.EventHandler(this.FV_FileList_DoubleClick);
            // 
            // ViewImageList
            // 
            this.ViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList.ImageStream")));
            this.ViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_Save);
            this.panel1.Controls.Add(this.BT_Move);
            this.panel1.Controls.Add(this.BT_OpenVRCHome);
            this.panel1.Controls.Add(this.BT_OpenTwitter);
            this.panel1.Controls.Add(this.BT_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 732);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 90);
            this.panel1.TabIndex = 17;
            // 
            // PictureSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 822);
            this.Controls.Add(this.SpC0);
            this.KeyPreview = true;
            this.Name = "PictureSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureSelector";
            this.Load += new System.EventHandler(this.PictureSelector_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PictureSelector_KeyDown);
            this.SpC0.Panel1.ResumeLayout(false);
            this.SpC0.Panel2.ResumeLayout(false);
            this.SpC0.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).EndInit();
            this.SpC0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Display)).EndInit();
            this.PN_Menu.ResumeLayout(false);
            this.PN_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SpC0;
        private System.Windows.Forms.PictureBox PB_Display;
        private System.Windows.Forms.ListBox Li_WorldList;
        private System.Windows.Forms.Button BT_OpenTwitter;
        private System.Windows.Forms.Button BT_OpenVRCHome;
        private System.Windows.Forms.Button BT_Move;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label LB_AuthorName;
        private System.Windows.Forms.TextBox TB_WorldAuthorName;
        private System.Windows.Forms.Label LB_WorldName;
        private System.Windows.Forms.TextBox TB_WorldName;
        private System.Windows.Forms.TextBox TB_Sentence;
        private System.Windows.Forms.Label LB_WorldList;
        private System.Windows.Forms.Label LB_AvatarAuthor;
        private System.Windows.Forms.TextBox TB_AvatarAuthor;
        private System.Windows.Forms.Label LB_AvatarName;
        private System.Windows.Forms.TextBox TB_AvatarName;
        private System.Windows.Forms.Panel PN_Menu;
        private System.Windows.Forms.Button BT_UP;
        private System.Windows.Forms.TextBox TB_FolderPath;
        private System.Windows.Forms.Splitter splitter1;
        private DirectoryTreeView DT_DirectoryList;
        private FileListView FV_FileList;
        private System.Windows.Forms.ImageList ViewImageList;
        private System.Windows.Forms.Panel panel1;
    }
}