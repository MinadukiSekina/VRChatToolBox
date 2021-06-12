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
            this.ViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.LB_AvatarAuthor = new System.Windows.Forms.Label();
            this.TB_AvatarAuthor = new System.Windows.Forms.TextBox();
            this.LB_AvatarName = new System.Windows.Forms.Label();
            this.TB_AvatarName = new System.Windows.Forms.TextBox();
            this.LB_WorldList = new System.Windows.Forms.Label();
            this.LB_AuthorName = new System.Windows.Forms.Label();
            this.TB_WorldAuthorName = new System.Windows.Forms.TextBox();
            this.LB_WorldName = new System.Windows.Forms.Label();
            this.TB_WorldName = new System.Windows.Forms.TextBox();
            this.LI_WorldList = new System.Windows.Forms.ListBox();
            this.PN_Button = new System.Windows.Forms.Panel();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Move = new System.Windows.Forms.Button();
            this.BT_OpenVRCHome = new System.Windows.Forms.Button();
            this.BT_OpenTwitter = new System.Windows.Forms.Button();
            this.BT_Close = new System.Windows.Forms.Button();
            this.TB_Sentence = new System.Windows.Forms.TextBox();
            this.PN_Menu = new System.Windows.Forms.Panel();
            this.TB_FolderPath = new System.Windows.Forms.TextBox();
            this.BT_UP = new System.Windows.Forms.Button();
            this.FV_FileList = new VRChatToolBox.FileListView();
            this.DT_DirectoryList = new VRChatToolBox.DirectoryTreeView();
            this.PN_Buffer = new System.Windows.Forms.Panel();
            this.PB_Display = new System.Windows.Forms.PictureBox();
            this.PN_Menu1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PN_Bottom = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PN_Top = new System.Windows.Forms.Panel();
            this.TC_Select = new System.Windows.Forms.TabControl();
            this.WorldTab = new System.Windows.Forms.TabPage();
            this.AvatarTab = new System.Windows.Forms.TabPage();
            this.LB_Sentence = new System.Windows.Forms.Label();
            this.LB_AvatarList = new System.Windows.Forms.Label();
            this.LI_AvatarList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).BeginInit();
            this.SpC0.Panel1.SuspendLayout();
            this.SpC0.Panel2.SuspendLayout();
            this.SpC0.SuspendLayout();
            this.PN_Button.SuspendLayout();
            this.PN_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Display)).BeginInit();
            this.PN_Menu1.SuspendLayout();
            this.PN_Bottom.SuspendLayout();
            this.PN_Top.SuspendLayout();
            this.TC_Select.SuspendLayout();
            this.WorldTab.SuspendLayout();
            this.AvatarTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpC0
            // 
            this.SpC0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpC0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpC0.IsSplitterFixed = true;
            this.SpC0.Location = new System.Drawing.Point(0, 0);
            this.SpC0.Name = "SpC0";
            // 
            // SpC0.Panel1
            // 
            this.SpC0.Panel1.Controls.Add(this.PN_Top);
            this.SpC0.Panel1.Controls.Add(this.splitter1);
            this.SpC0.Panel1.Controls.Add(this.PN_Bottom);
            // 
            // SpC0.Panel2
            // 
            this.SpC0.Panel2.Controls.Add(this.LB_Sentence);
            this.SpC0.Panel2.Controls.Add(this.TC_Select);
            this.SpC0.Panel2.Controls.Add(this.TB_Sentence);
            this.SpC0.Panel2.Controls.Add(this.PN_Button);
            this.SpC0.Size = new System.Drawing.Size(1284, 822);
            this.SpC0.SplitterDistance = 782;
            this.SpC0.TabIndex = 0;
            this.SpC0.TabStop = false;
            // 
            // ViewImageList
            // 
            this.ViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList.ImageStream")));
            this.ViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
            // 
            // LB_AvatarAuthor
            // 
            this.LB_AvatarAuthor.AutoSize = true;
            this.LB_AvatarAuthor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AvatarAuthor.Location = new System.Drawing.Point(9, 321);
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
            this.TB_AvatarAuthor.Location = new System.Drawing.Point(90, 318);
            this.TB_AvatarAuthor.Name = "TB_AvatarAuthor";
            this.TB_AvatarAuthor.Size = new System.Drawing.Size(367, 27);
            this.TB_AvatarAuthor.TabIndex = 1;
            this.TB_AvatarAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_AvatarAuthor_KeyDown);
            // 
            // LB_AvatarName
            // 
            this.LB_AvatarName.AutoSize = true;
            this.LB_AvatarName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AvatarName.Location = new System.Drawing.Point(7, 288);
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
            this.TB_AvatarName.Location = new System.Drawing.Point(90, 285);
            this.TB_AvatarName.Name = "TB_AvatarName";
            this.TB_AvatarName.Size = new System.Drawing.Size(367, 27);
            this.TB_AvatarName.TabIndex = 0;
            this.TB_AvatarName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_AvatarName_KeyDown);
            // 
            // LB_WorldList
            // 
            this.LB_WorldList.AutoSize = true;
            this.LB_WorldList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_WorldList.Location = new System.Drawing.Point(6, 15);
            this.LB_WorldList.Name = "LB_WorldList";
            this.LB_WorldList.Size = new System.Drawing.Size(110, 20);
            this.LB_WorldList.TabIndex = 12;
            this.LB_WorldList.Text = "ワールド候補";
            // 
            // LB_AuthorName
            // 
            this.LB_AuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_AuthorName.AutoSize = true;
            this.LB_AuthorName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AuthorName.Location = new System.Drawing.Point(9, 321);
            this.LB_AuthorName.Name = "LB_AuthorName";
            this.LB_AuthorName.Size = new System.Drawing.Size(79, 20);
            this.LB_AuthorName.TabIndex = 10;
            this.LB_AuthorName.Text = "製作者：";
            // 
            // TB_WorldAuthorName
            // 
            this.TB_WorldAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_WorldAuthorName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_WorldAuthorName.Location = new System.Drawing.Point(90, 318);
            this.TB_WorldAuthorName.Name = "TB_WorldAuthorName";
            this.TB_WorldAuthorName.Size = new System.Drawing.Size(367, 27);
            this.TB_WorldAuthorName.TabIndex = 1;
            this.TB_WorldAuthorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_WorldAuthorName_KeyDown);
            // 
            // LB_WorldName
            // 
            this.LB_WorldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_WorldName.AutoSize = true;
            this.LB_WorldName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_WorldName.Location = new System.Drawing.Point(8, 288);
            this.LB_WorldName.Name = "LB_WorldName";
            this.LB_WorldName.Size = new System.Drawing.Size(80, 20);
            this.LB_WorldName.TabIndex = 8;
            this.LB_WorldName.Text = "ワールド：";
            // 
            // TB_WorldName
            // 
            this.TB_WorldName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_WorldName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_WorldName.Location = new System.Drawing.Point(90, 285);
            this.TB_WorldName.Name = "TB_WorldName";
            this.TB_WorldName.Size = new System.Drawing.Size(367, 27);
            this.TB_WorldName.TabIndex = 0;
            this.TB_WorldName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_WorldName_KeyDown);
            // 
            // LI_WorldList
            // 
            this.LI_WorldList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LI_WorldList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LI_WorldList.FormattingEnabled = true;
            this.LI_WorldList.ItemHeight = 20;
            this.LI_WorldList.Location = new System.Drawing.Point(10, 39);
            this.LI_WorldList.Name = "LI_WorldList";
            this.LI_WorldList.Size = new System.Drawing.Size(447, 224);
            this.LI_WorldList.TabIndex = 5;
            this.LI_WorldList.TabStop = false;
            this.LI_WorldList.DoubleClick += new System.EventHandler(this.Li_WorldList_DoubleClick);
            // 
            // PN_Button
            // 
            this.PN_Button.Controls.Add(this.BT_Save);
            this.PN_Button.Controls.Add(this.BT_Move);
            this.PN_Button.Controls.Add(this.BT_OpenVRCHome);
            this.PN_Button.Controls.Add(this.BT_OpenTwitter);
            this.PN_Button.Controls.Add(this.BT_Close);
            this.PN_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Button.Location = new System.Drawing.Point(0, 730);
            this.PN_Button.Name = "PN_Button";
            this.PN_Button.Size = new System.Drawing.Size(496, 90);
            this.PN_Button.TabIndex = 17;
            // 
            // BT_Save
            // 
            this.BT_Save.Enabled = false;
            this.BT_Save.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(182, 11);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(147, 31);
            this.BT_Save.TabIndex = 1;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Move
            // 
            this.BT_Move.Enabled = false;
            this.BT_Move.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Move.Location = new System.Drawing.Point(335, 11);
            this.BT_Move.Name = "BT_Move";
            this.BT_Move.Size = new System.Drawing.Size(147, 31);
            this.BT_Move.TabIndex = 2;
            this.BT_Move.Text = "投稿済へ";
            this.BT_Move.UseVisualStyleBackColor = true;
            this.BT_Move.Click += new System.EventHandler(this.BT_Move_Click);
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
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Close.Location = new System.Drawing.Point(29, 11);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(147, 31);
            this.BT_Close.TabIndex = 6;
            this.BT_Close.Text = "閉じる";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // TB_Sentence
            // 
            this.TB_Sentence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Sentence.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_Sentence.Location = new System.Drawing.Point(9, 457);
            this.TB_Sentence.Multiline = true;
            this.TB_Sentence.Name = "TB_Sentence";
            this.TB_Sentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Sentence.Size = new System.Drawing.Size(475, 254);
            this.TB_Sentence.TabIndex = 1;
            // 
            // PN_Menu
            // 
            this.PN_Menu.Controls.Add(this.BT_UP);
            this.PN_Menu.Controls.Add(this.TB_FolderPath);
            this.PN_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Menu.Location = new System.Drawing.Point(177, 0);
            this.PN_Menu.Name = "PN_Menu";
            this.PN_Menu.Size = new System.Drawing.Size(603, 61);
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
            this.TB_FolderPath.Size = new System.Drawing.Size(529, 27);
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
            this.FV_FileList.Location = new System.Drawing.Point(177, 61);
            this.FV_FileList.MultiSelect = false;
            this.FV_FileList.Name = "FV_FileList";
            this.FV_FileList.Size = new System.Drawing.Size(603, 370);
            this.FV_FileList.SmallImageList = this.ViewImageList;
            this.FV_FileList.TabIndex = 3;
            this.FV_FileList.TabStop = false;
            this.FV_FileList.UseCompatibleStateImageBehavior = false;
            this.FV_FileList.Click += new System.EventHandler(this.FV_FileList_Click);
            this.FV_FileList.DoubleClick += new System.EventHandler(this.FV_FileList_DoubleClick);
            // 
            // DT_DirectoryList
            // 
            this.DT_DirectoryList.Dock = System.Windows.Forms.DockStyle.Left;
            this.DT_DirectoryList.Location = new System.Drawing.Point(0, 0);
            this.DT_DirectoryList.Name = "DT_DirectoryList";
            this.DT_DirectoryList.Size = new System.Drawing.Size(177, 431);
            this.DT_DirectoryList.TabIndex = 0;
            this.DT_DirectoryList.TabStop = false;
            this.DT_DirectoryList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DT_DirectoryList_AfterSelect);
            // 
            // PN_Buffer
            // 
            this.PN_Buffer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Buffer.Location = new System.Drawing.Point(0, 0);
            this.PN_Buffer.Name = "PN_Buffer";
            this.PN_Buffer.Size = new System.Drawing.Size(780, 15);
            this.PN_Buffer.TabIndex = 2;
            // 
            // PB_Display
            // 
            this.PB_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Display.Location = new System.Drawing.Point(0, 0);
            this.PB_Display.Name = "PB_Display";
            this.PB_Display.Size = new System.Drawing.Size(780, 386);
            this.PB_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Display.TabIndex = 0;
            this.PB_Display.TabStop = false;
            this.PB_Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_Display_MouseDown);
            // 
            // PN_Menu1
            // 
            this.PN_Menu1.Controls.Add(this.button1);
            this.PN_Menu1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Menu1.Location = new System.Drawing.Point(0, 346);
            this.PN_Menu1.Name = "PN_Menu1";
            this.PN_Menu1.Size = new System.Drawing.Size(780, 40);
            this.PN_Menu1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(101, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // PN_Bottom
            // 
            this.PN_Bottom.Controls.Add(this.FV_FileList);
            this.PN_Bottom.Controls.Add(this.PN_Menu);
            this.PN_Bottom.Controls.Add(this.DT_DirectoryList);
            this.PN_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Bottom.Location = new System.Drawing.Point(0, 389);
            this.PN_Bottom.Name = "PN_Bottom";
            this.PN_Bottom.Size = new System.Drawing.Size(780, 431);
            this.PN_Bottom.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 386);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(780, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // PN_Top
            // 
            this.PN_Top.Controls.Add(this.PN_Menu1);
            this.PN_Top.Controls.Add(this.PN_Buffer);
            this.PN_Top.Controls.Add(this.PB_Display);
            this.PN_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_Top.Location = new System.Drawing.Point(0, 0);
            this.PN_Top.Name = "PN_Top";
            this.PN_Top.Size = new System.Drawing.Size(780, 386);
            this.PN_Top.TabIndex = 6;
            // 
            // TC_Select
            // 
            this.TC_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_Select.Controls.Add(this.WorldTab);
            this.TC_Select.Controls.Add(this.AvatarTab);
            this.TC_Select.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.TC_Select.Location = new System.Drawing.Point(9, 11);
            this.TC_Select.Name = "TC_Select";
            this.TC_Select.SelectedIndex = 0;
            this.TC_Select.Size = new System.Drawing.Size(476, 399);
            this.TC_Select.TabIndex = 0;
            this.TC_Select.TabStop = false;
            // 
            // WorldTab
            // 
            this.WorldTab.Controls.Add(this.LB_WorldList);
            this.WorldTab.Controls.Add(this.LI_WorldList);
            this.WorldTab.Controls.Add(this.TB_WorldName);
            this.WorldTab.Controls.Add(this.LB_WorldName);
            this.WorldTab.Controls.Add(this.TB_WorldAuthorName);
            this.WorldTab.Controls.Add(this.LB_AuthorName);
            this.WorldTab.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WorldTab.Location = new System.Drawing.Point(4, 30);
            this.WorldTab.Name = "WorldTab";
            this.WorldTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorldTab.Size = new System.Drawing.Size(468, 365);
            this.WorldTab.TabIndex = 0;
            this.WorldTab.Text = "ワールド";
            this.WorldTab.UseVisualStyleBackColor = true;
            // 
            // AvatarTab
            // 
            this.AvatarTab.Controls.Add(this.LB_AvatarList);
            this.AvatarTab.Controls.Add(this.LI_AvatarList);
            this.AvatarTab.Controls.Add(this.TB_AvatarName);
            this.AvatarTab.Controls.Add(this.LB_AvatarAuthor);
            this.AvatarTab.Controls.Add(this.LB_AvatarName);
            this.AvatarTab.Controls.Add(this.TB_AvatarAuthor);
            this.AvatarTab.Location = new System.Drawing.Point(4, 30);
            this.AvatarTab.Name = "AvatarTab";
            this.AvatarTab.Padding = new System.Windows.Forms.Padding(3);
            this.AvatarTab.Size = new System.Drawing.Size(468, 365);
            this.AvatarTab.TabIndex = 1;
            this.AvatarTab.Text = "アバター";
            this.AvatarTab.UseVisualStyleBackColor = true;
            // 
            // LB_Sentence
            // 
            this.LB_Sentence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_Sentence.AutoSize = true;
            this.LB_Sentence.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_Sentence.Location = new System.Drawing.Point(9, 434);
            this.LB_Sentence.Name = "LB_Sentence";
            this.LB_Sentence.Size = new System.Drawing.Size(89, 20);
            this.LB_Sentence.TabIndex = 13;
            this.LB_Sentence.Text = "投稿内容";
            // 
            // LB_AvatarList
            // 
            this.LB_AvatarList.AutoSize = true;
            this.LB_AvatarList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AvatarList.Location = new System.Drawing.Point(6, 15);
            this.LB_AvatarList.Name = "LB_AvatarList";
            this.LB_AvatarList.Size = new System.Drawing.Size(71, 20);
            this.LB_AvatarList.TabIndex = 14;
            this.LB_AvatarList.Text = "アバター";
            // 
            // LI_AvatarList
            // 
            this.LI_AvatarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LI_AvatarList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LI_AvatarList.FormattingEnabled = true;
            this.LI_AvatarList.ItemHeight = 20;
            this.LI_AvatarList.Location = new System.Drawing.Point(10, 39);
            this.LI_AvatarList.Name = "LI_AvatarList";
            this.LI_AvatarList.Size = new System.Drawing.Size(447, 224);
            this.LI_AvatarList.TabIndex = 13;
            this.LI_AvatarList.TabStop = false;
            this.LI_AvatarList.DoubleClick += new System.EventHandler(this.LI_AvatarList_DoubleClick);
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
            this.PN_Button.ResumeLayout(false);
            this.PN_Menu.ResumeLayout(false);
            this.PN_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Display)).EndInit();
            this.PN_Menu1.ResumeLayout(false);
            this.PN_Bottom.ResumeLayout(false);
            this.PN_Top.ResumeLayout(false);
            this.TC_Select.ResumeLayout(false);
            this.WorldTab.ResumeLayout(false);
            this.WorldTab.PerformLayout();
            this.AvatarTab.ResumeLayout(false);
            this.AvatarTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SpC0;
        private System.Windows.Forms.ListBox LI_WorldList;
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
        private System.Windows.Forms.ImageList ViewImageList;
        private System.Windows.Forms.Panel PN_Button;
        private System.Windows.Forms.Splitter splitter1;
        private FileListView FV_FileList;
        private DirectoryTreeView DT_DirectoryList;
        private System.Windows.Forms.Panel PN_Menu;
        private System.Windows.Forms.Button BT_UP;
        private System.Windows.Forms.TextBox TB_FolderPath;
        private System.Windows.Forms.PictureBox PB_Display;
        private System.Windows.Forms.Panel PN_Buffer;
        private System.Windows.Forms.Panel PN_Menu1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PN_Bottom;
        private System.Windows.Forms.Panel PN_Top;
        private System.Windows.Forms.TabControl TC_Select;
        private System.Windows.Forms.TabPage WorldTab;
        private System.Windows.Forms.TabPage AvatarTab;
        private System.Windows.Forms.Label LB_Sentence;
        private System.Windows.Forms.Label LB_AvatarList;
        private System.Windows.Forms.ListBox LI_AvatarList;
    }
}