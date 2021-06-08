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
            this.ViewImageList0 = new System.Windows.Forms.ImageList(this.components);
            this.ViewImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SpC0 = new System.Windows.Forms.SplitContainer();
            this.SpC1 = new System.Windows.Forms.SplitContainer();
            this.LB_WorldList = new System.Windows.Forms.Label();
            this.TB_Sentence = new System.Windows.Forms.TextBox();
            this.LB_AuthorName = new System.Windows.Forms.Label();
            this.TB_AuthorName = new System.Windows.Forms.TextBox();
            this.LB_WorldName = new System.Windows.Forms.Label();
            this.TB_WorldName = new System.Windows.Forms.TextBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.Li_WorldList = new System.Windows.Forms.ListBox();
            this.BT_OpenTwitter = new System.Windows.Forms.Button();
            this.BT_OpenVRCHome = new System.Windows.Forms.Button();
            this.BT_Move = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.PB_Display = new System.Windows.Forms.PictureBox();
            this.pictureExplorer1 = new VRChatToolBox.PictureExplorer();
            this.pictureExplorer2 = new VRChatToolBox.PictureExplorer();
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).BeginInit();
            this.SpC0.Panel1.SuspendLayout();
            this.SpC0.Panel2.SuspendLayout();
            this.SpC0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpC1)).BeginInit();
            this.SpC1.Panel1.SuspendLayout();
            this.SpC1.Panel2.SuspendLayout();
            this.SpC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewImageList0
            // 
            this.ViewImageList0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList0.ImageStream")));
            this.ViewImageList0.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList0.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
            // 
            // ViewImageList1
            // 
            this.ViewImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList1.ImageStream")));
            this.ViewImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList1.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
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
            this.SpC0.Panel1.Controls.Add(this.SpC1);
            // 
            // SpC0.Panel2
            // 
            this.SpC0.Panel2.Controls.Add(this.LB_WorldList);
            this.SpC0.Panel2.Controls.Add(this.TB_Sentence);
            this.SpC0.Panel2.Controls.Add(this.LB_AuthorName);
            this.SpC0.Panel2.Controls.Add(this.TB_AuthorName);
            this.SpC0.Panel2.Controls.Add(this.LB_WorldName);
            this.SpC0.Panel2.Controls.Add(this.TB_WorldName);
            this.SpC0.Panel2.Controls.Add(this.BT_Close);
            this.SpC0.Panel2.Controls.Add(this.Li_WorldList);
            this.SpC0.Panel2.Controls.Add(this.BT_OpenTwitter);
            this.SpC0.Panel2.Controls.Add(this.BT_OpenVRCHome);
            this.SpC0.Panel2.Controls.Add(this.BT_Move);
            this.SpC0.Panel2.Controls.Add(this.BT_Save);
            this.SpC0.Panel2.Controls.Add(this.PB_Display);
            this.SpC0.Size = new System.Drawing.Size(1284, 822);
            this.SpC0.SplitterDistance = 782;
            this.SpC0.TabIndex = 0;
            // 
            // SpC1
            // 
            this.SpC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpC1.Location = new System.Drawing.Point(0, 0);
            this.SpC1.Name = "SpC1";
            this.SpC1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpC1.Panel1
            // 
            this.SpC1.Panel1.Controls.Add(this.pictureExplorer1);
            // 
            // SpC1.Panel2
            // 
            this.SpC1.Panel2.Controls.Add(this.pictureExplorer2);
            this.SpC1.Size = new System.Drawing.Size(782, 822);
            this.SpC1.SplitterDistance = 373;
            this.SpC1.TabIndex = 0;
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
            this.TB_Sentence.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_Sentence.Location = new System.Drawing.Point(9, 529);
            this.TB_Sentence.Multiline = true;
            this.TB_Sentence.Name = "TB_Sentence";
            this.TB_Sentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Sentence.Size = new System.Drawing.Size(477, 197);
            this.TB_Sentence.TabIndex = 11;
            // 
            // LB_AuthorName
            // 
            this.LB_AuthorName.AutoSize = true;
            this.LB_AuthorName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_AuthorName.Location = new System.Drawing.Point(9, 496);
            this.LB_AuthorName.Name = "LB_AuthorName";
            this.LB_AuthorName.Size = new System.Drawing.Size(79, 20);
            this.LB_AuthorName.TabIndex = 10;
            this.LB_AuthorName.Text = "製作者：";
            // 
            // TB_AuthorName
            // 
            this.TB_AuthorName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_AuthorName.Location = new System.Drawing.Point(103, 493);
            this.TB_AuthorName.Name = "TB_AuthorName";
            this.TB_AuthorName.Size = new System.Drawing.Size(383, 27);
            this.TB_AuthorName.TabIndex = 9;
            // 
            // LB_WorldName
            // 
            this.LB_WorldName.AutoSize = true;
            this.LB_WorldName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_WorldName.Location = new System.Drawing.Point(9, 463);
            this.LB_WorldName.Name = "LB_WorldName";
            this.LB_WorldName.Size = new System.Drawing.Size(80, 20);
            this.LB_WorldName.TabIndex = 8;
            this.LB_WorldName.Text = "ワールド：";
            // 
            // TB_WorldName
            // 
            this.TB_WorldName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TB_WorldName.Location = new System.Drawing.Point(103, 460);
            this.TB_WorldName.Name = "TB_WorldName";
            this.TB_WorldName.Size = new System.Drawing.Size(383, 27);
            this.TB_WorldName.TabIndex = 7;
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Close.Location = new System.Drawing.Point(329, 746);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(147, 31);
            this.BT_Close.TabIndex = 6;
            this.BT_Close.Text = "閉じる";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // Li_WorldList
            // 
            this.Li_WorldList.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Li_WorldList.FormattingEnabled = true;
            this.Li_WorldList.ItemHeight = 20;
            this.Li_WorldList.Location = new System.Drawing.Point(9, 314);
            this.Li_WorldList.Name = "Li_WorldList";
            this.Li_WorldList.Size = new System.Drawing.Size(477, 124);
            this.Li_WorldList.TabIndex = 5;
            this.Li_WorldList.DoubleClick += new System.EventHandler(this.Li_WorldList_DoubleClick);
            // 
            // BT_OpenTwitter
            // 
            this.BT_OpenTwitter.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_OpenTwitter.Location = new System.Drawing.Point(23, 783);
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
            this.BT_OpenVRCHome.Location = new System.Drawing.Point(176, 783);
            this.BT_OpenVRCHome.Name = "BT_OpenVRCHome";
            this.BT_OpenVRCHome.Size = new System.Drawing.Size(147, 31);
            this.BT_OpenVRCHome.TabIndex = 3;
            this.BT_OpenVRCHome.Text = "VRChat Home";
            this.BT_OpenVRCHome.UseVisualStyleBackColor = true;
            this.BT_OpenVRCHome.Click += new System.EventHandler(this.BT_OpenVRCHome_Click);
            // 
            // BT_Move
            // 
            this.BT_Move.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Move.Location = new System.Drawing.Point(176, 746);
            this.BT_Move.Name = "BT_Move";
            this.BT_Move.Size = new System.Drawing.Size(147, 31);
            this.BT_Move.TabIndex = 2;
            this.BT_Move.Text = "投稿済へ";
            this.BT_Move.UseVisualStyleBackColor = true;
            this.BT_Move.Click += new System.EventHandler(this.BT_Move_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Save.Location = new System.Drawing.Point(23, 746);
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
            // pictureExplorer1
            // 
            this.pictureExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureExplorer1.Location = new System.Drawing.Point(0, 0);
            this.pictureExplorer1.Name = "pictureExplorer1";
            this.pictureExplorer1.Size = new System.Drawing.Size(782, 373);
            this.pictureExplorer1.TabIndex = 0;
            // 
            // pictureExplorer2
            // 
            this.pictureExplorer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureExplorer2.Location = new System.Drawing.Point(0, 0);
            this.pictureExplorer2.Name = "pictureExplorer2";
            this.pictureExplorer2.Size = new System.Drawing.Size(782, 445);
            this.pictureExplorer2.TabIndex = 0;
            // 
            // PictureSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 822);
            this.Controls.Add(this.SpC0);
            this.Name = "PictureSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureSelector";
            this.Load += new System.EventHandler(this.PictureSelector_Load);
            this.SpC0.Panel1.ResumeLayout(false);
            this.SpC0.Panel2.ResumeLayout(false);
            this.SpC0.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).EndInit();
            this.SpC0.ResumeLayout(false);
            this.SpC1.Panel1.ResumeLayout(false);
            this.SpC1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpC1)).EndInit();
            this.SpC1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ViewImageList0;
        private System.Windows.Forms.ImageList ViewImageList1;
        private System.Windows.Forms.SplitContainer SpC0;
        private System.Windows.Forms.SplitContainer SpC1;
        private PictureExplorer pictureExplorer1;
        private PictureExplorer pictureExplorer2;
        private System.Windows.Forms.PictureBox PB_Display;
        private System.Windows.Forms.ListBox Li_WorldList;
        private System.Windows.Forms.Button BT_OpenTwitter;
        private System.Windows.Forms.Button BT_OpenVRCHome;
        private System.Windows.Forms.Button BT_Move;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label LB_AuthorName;
        private System.Windows.Forms.TextBox TB_AuthorName;
        private System.Windows.Forms.Label LB_WorldName;
        private System.Windows.Forms.TextBox TB_WorldName;
        private System.Windows.Forms.TextBox TB_Sentence;
        private System.Windows.Forms.Label LB_WorldList;
    }
}