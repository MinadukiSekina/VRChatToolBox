namespace VRChatToolBox
{
    partial class PictureExplorer
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureExplorer));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PN_MENU = new System.Windows.Forms.Panel();
            this.PathText = new System.Windows.Forms.TextBox();
            this.BT_UP = new System.Windows.Forms.Button();
            this.ViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.FileListView1 = new VRChatToolBox.FileListView();
            this.DirectoryTreeView1 = new VRChatToolBox.DirectoryTreeView();
            this.PN_MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(121, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 309);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // PN_MENU
            // 
            this.PN_MENU.Controls.Add(this.PathText);
            this.PN_MENU.Controls.Add(this.BT_UP);
            this.PN_MENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_MENU.Location = new System.Drawing.Point(124, 0);
            this.PN_MENU.Name = "PN_MENU";
            this.PN_MENU.Size = new System.Drawing.Size(600, 51);
            this.PN_MENU.TabIndex = 2;
            // 
            // PathText
            // 
            this.PathText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PathText.Location = new System.Drawing.Point(49, 12);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(542, 27);
            this.PathText.TabIndex = 1;
            this.PathText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathText_KeyDown);
            this.PathText.Validating += new System.ComponentModel.CancelEventHandler(this.PathText_Validating);
            // 
            // BT_UP
            // 
            this.BT_UP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_UP.Image = global::VRChatToolBox.Properties.Resources.sozai_cman_jp_20210605100828;
            this.BT_UP.Location = new System.Drawing.Point(8, 6);
            this.BT_UP.Name = "BT_UP";
            this.BT_UP.Size = new System.Drawing.Size(35, 39);
            this.BT_UP.TabIndex = 0;
            this.BT_UP.UseVisualStyleBackColor = true;
            this.BT_UP.Click += new System.EventHandler(this.BT_UP_Click);
            // 
            // ViewImageList
            // 
            this.ViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList.ImageStream")));
            this.ViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
            // 
            // FileListView1
            // 
            this.FileListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListView1.HideSelection = false;
            this.FileListView1.LargeImageList = this.ViewImageList;
            this.FileListView1.Location = new System.Drawing.Point(124, 51);
            this.FileListView1.MultiSelect = false;
            this.FileListView1.Name = "FileListView1";
            this.FileListView1.Size = new System.Drawing.Size(600, 258);
            this.FileListView1.SmallImageList = this.ViewImageList;
            this.FileListView1.TabIndex = 3;
            this.FileListView1.UseCompatibleStateImageBehavior = false;
            this.FileListView1.Click += new System.EventHandler(this.FileListView1_Click);
            this.FileListView1.DoubleClick += new System.EventHandler(this.FileListView1_DoubleClick);
            // 
            // DirectoryTreeView1
            // 
            this.DirectoryTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.DirectoryTreeView1.Location = new System.Drawing.Point(0, 0);
            this.DirectoryTreeView1.Name = "DirectoryTreeView1";
            this.DirectoryTreeView1.Size = new System.Drawing.Size(121, 309);
            this.DirectoryTreeView1.TabIndex = 0;
            this.DirectoryTreeView1.TabStop = false;
            this.DirectoryTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirectoryTreeView1_AfterSelect);
            // 
            // PictureExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileListView1);
            this.Controls.Add(this.PN_MENU);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.DirectoryTreeView1);
            this.Name = "PictureExplorer";
            this.Size = new System.Drawing.Size(724, 309);
            this.PN_MENU.ResumeLayout(false);
            this.PN_MENU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DirectoryTreeView DirectoryTreeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel PN_MENU;
        private System.Windows.Forms.Button BT_UP;
        private FileListView FileListView1;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.ImageList ViewImageList;
    }
}
