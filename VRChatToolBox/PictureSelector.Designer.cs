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
            this.ViewImageList0 = new System.Windows.Forms.ImageList(this.components);
            this.SpC1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PN_Menu0 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.PN_Menu1 = new System.Windows.Forms.Panel();
            this.ViewImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PB_Picture = new System.Windows.Forms.PictureBox();
            this.fileListView0 = new VRChatToolBox.FileListView();
            this.directoryTreeView0 = new VRChatToolBox.DirectoryTreeView();
            this.fileListView1 = new VRChatToolBox.FileListView();
            this.directoryTreeView1 = new VRChatToolBox.DirectoryTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).BeginInit();
            this.SpC0.Panel1.SuspendLayout();
            this.SpC0.Panel2.SuspendLayout();
            this.SpC0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpC1)).BeginInit();
            this.SpC1.Panel1.SuspendLayout();
            this.SpC1.Panel2.SuspendLayout();
            this.SpC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // SpC0
            // 
            this.SpC0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpC0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpC0.IsSplitterFixed = true;
            this.SpC0.Location = new System.Drawing.Point(0, 0);
            this.SpC0.Name = "SpC0";
            this.SpC0.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpC0.Panel1
            // 
            this.SpC0.Panel1.Controls.Add(this.PB_Picture);
            // 
            // SpC0.Panel2
            // 
            this.SpC0.Panel2.Controls.Add(this.SpC1);
            this.SpC0.Size = new System.Drawing.Size(800, 822);
            this.SpC0.SplitterDistance = 282;
            this.SpC0.TabIndex = 0;
            // 
            // ViewImageList0
            // 
            this.ViewImageList0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList0.ImageStream")));
            this.ViewImageList0.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList0.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
            // 
            // SpC1
            // 
            this.SpC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpC1.Location = new System.Drawing.Point(0, 0);
            this.SpC1.Name = "SpC1";
            this.SpC1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpC1.Panel1
            // 
            this.SpC1.Panel1.Controls.Add(this.fileListView0);
            this.SpC1.Panel1.Controls.Add(this.PN_Menu0);
            this.SpC1.Panel1.Controls.Add(this.splitter1);
            this.SpC1.Panel1.Controls.Add(this.directoryTreeView0);
            // 
            // SpC1.Panel2
            // 
            this.SpC1.Panel2.Controls.Add(this.fileListView1);
            this.SpC1.Panel2.Controls.Add(this.PN_Menu1);
            this.SpC1.Panel2.Controls.Add(this.splitter2);
            this.SpC1.Panel2.Controls.Add(this.directoryTreeView1);
            this.SpC1.Size = new System.Drawing.Size(800, 536);
            this.SpC1.SplitterDistance = 271;
            this.SpC1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 269);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // PN_Menu0
            // 
            this.PN_Menu0.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Menu0.Location = new System.Drawing.Point(124, 0);
            this.PN_Menu0.Name = "PN_Menu0";
            this.PN_Menu0.Size = new System.Drawing.Size(674, 58);
            this.PN_Menu0.TabIndex = 3;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(121, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 259);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // PN_Menu1
            // 
            this.PN_Menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Menu1.Location = new System.Drawing.Point(124, 0);
            this.PN_Menu1.Name = "PN_Menu1";
            this.PN_Menu1.Size = new System.Drawing.Size(674, 63);
            this.PN_Menu1.TabIndex = 2;
            // 
            // ViewImageList1
            // 
            this.ViewImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList1.ImageStream")));
            this.ViewImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList1.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
            // 
            // PB_Picture
            // 
            this.PB_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PB_Picture.Location = new System.Drawing.Point(3, 3);
            this.PB_Picture.Name = "PB_Picture";
            this.PB_Picture.Size = new System.Drawing.Size(480, 270);
            this.PB_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Picture.TabIndex = 0;
            this.PB_Picture.TabStop = false;
            // 
            // fileListView0
            // 
            this.fileListView0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView0.HideSelection = false;
            this.fileListView0.LargeImageList = this.ViewImageList0;
            this.fileListView0.Location = new System.Drawing.Point(124, 58);
            this.fileListView0.Name = "fileListView0";
            this.fileListView0.Size = new System.Drawing.Size(674, 211);
            this.fileListView0.SmallImageList = this.ViewImageList0;
            this.fileListView0.TabIndex = 2;
            this.fileListView0.UseCompatibleStateImageBehavior = false;
            // 
            // directoryTreeView0
            // 
            this.directoryTreeView0.Dock = System.Windows.Forms.DockStyle.Left;
            this.directoryTreeView0.Location = new System.Drawing.Point(0, 0);
            this.directoryTreeView0.Name = "directoryTreeView0";
            this.directoryTreeView0.Size = new System.Drawing.Size(121, 269);
            this.directoryTreeView0.TabIndex = 0;
            // 
            // fileListView1
            // 
            this.fileListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView1.HideSelection = false;
            this.fileListView1.LargeImageList = this.ViewImageList1;
            this.fileListView1.Location = new System.Drawing.Point(124, 63);
            this.fileListView1.Name = "fileListView1";
            this.fileListView1.Size = new System.Drawing.Size(674, 196);
            this.fileListView1.SmallImageList = this.ViewImageList1;
            this.fileListView1.TabIndex = 3;
            this.fileListView1.UseCompatibleStateImageBehavior = false;
            // 
            // directoryTreeView1
            // 
            this.directoryTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.directoryTreeView1.Location = new System.Drawing.Point(0, 0);
            this.directoryTreeView1.Name = "directoryTreeView1";
            this.directoryTreeView1.Size = new System.Drawing.Size(121, 259);
            this.directoryTreeView1.TabIndex = 0;
            // 
            // PictureSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 822);
            this.Controls.Add(this.SpC0);
            this.Name = "PictureSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureSelector";
            this.SpC0.Panel1.ResumeLayout(false);
            this.SpC0.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).EndInit();
            this.SpC0.ResumeLayout(false);
            this.SpC1.Panel1.ResumeLayout(false);
            this.SpC1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpC1)).EndInit();
            this.SpC1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpC0;
        private System.Windows.Forms.ImageList ViewImageList0;
        private System.Windows.Forms.SplitContainer SpC1;
        private FileListView fileListView0;
        private System.Windows.Forms.Panel PN_Menu0;
        private System.Windows.Forms.Splitter splitter1;
        private DirectoryTreeView directoryTreeView0;
        private FileListView fileListView1;
        private System.Windows.Forms.Panel PN_Menu1;
        private System.Windows.Forms.Splitter splitter2;
        private DirectoryTreeView directoryTreeView1;
        private System.Windows.Forms.ImageList ViewImageList1;
        private System.Windows.Forms.PictureBox PB_Picture;
    }
}