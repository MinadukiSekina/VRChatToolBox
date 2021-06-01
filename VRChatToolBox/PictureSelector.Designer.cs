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
            this.FileView0 = new System.Windows.Forms.ListView();
            this.ViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.Sp0 = new System.Windows.Forms.Splitter();
            this.FolderView0 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).BeginInit();
            this.SpC0.Panel2.SuspendLayout();
            this.SpC0.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpC0
            // 
            this.SpC0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpC0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpC0.Location = new System.Drawing.Point(0, 0);
            this.SpC0.Name = "SpC0";
            this.SpC0.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpC0.Panel2
            // 
            this.SpC0.Panel2.Controls.Add(this.FileView0);
            this.SpC0.Panel2.Controls.Add(this.Sp0);
            this.SpC0.Panel2.Controls.Add(this.FolderView0);
            this.SpC0.Size = new System.Drawing.Size(800, 450);
            this.SpC0.SplitterDistance = 150;
            this.SpC0.TabIndex = 0;
            // 
            // FileView0
            // 
            this.FileView0.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileView0.HideSelection = false;
            this.FileView0.LabelWrap = false;
            this.FileView0.LargeImageList = this.ViewImageList;
            this.FileView0.Location = new System.Drawing.Point(100, 0);
            this.FileView0.MultiSelect = false;
            this.FileView0.Name = "FileView0";
            this.FileView0.Size = new System.Drawing.Size(185, 294);
            this.FileView0.SmallImageList = this.ViewImageList;
            this.FileView0.TabIndex = 2;
            this.FileView0.UseCompatibleStateImageBehavior = false;
            // 
            // ViewImageList
            // 
            this.ViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ViewImageList.ImageStream")));
            this.ViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ViewImageList.Images.SetKeyName(0, "sozai_cman_jp_20210601203235.png");
            // 
            // Sp0
            // 
            this.Sp0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sp0.Location = new System.Drawing.Point(97, 0);
            this.Sp0.Name = "Sp0";
            this.Sp0.Size = new System.Drawing.Size(3, 294);
            this.Sp0.TabIndex = 1;
            this.Sp0.TabStop = false;
            // 
            // FolderView0
            // 
            this.FolderView0.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolderView0.Location = new System.Drawing.Point(0, 0);
            this.FolderView0.Name = "FolderView0";
            this.FolderView0.Size = new System.Drawing.Size(97, 294);
            this.FolderView0.TabIndex = 0;
            this.FolderView0.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.FolderView0_BeforeExpand);
            this.FolderView0.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FolderView0_AfterSelect);
            // 
            // PictureSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpC0);
            this.Name = "PictureSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureSelector";
            this.SpC0.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpC0)).EndInit();
            this.SpC0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpC0;
        private System.Windows.Forms.Splitter Sp0;
        private System.Windows.Forms.TreeView FolderView0;
        private System.Windows.Forms.ListView FileView0;
        private System.Windows.Forms.ImageList ViewImageList;
    }
}