namespace VRChatToolBox
{
    partial class PathSetControl
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
            this.PathSetGroup = new System.Windows.Forms.GroupBox();
            this.BT_OpenDialog = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.TextBox();
            this.PathSetGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathSetGroup
            // 
            this.PathSetGroup.Controls.Add(this.BT_OpenDialog);
            this.PathSetGroup.Controls.Add(this.PathText);
            this.PathSetGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathSetGroup.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PathSetGroup.Location = new System.Drawing.Point(0, 0);
            this.PathSetGroup.Name = "PathSetGroup";
            this.PathSetGroup.Size = new System.Drawing.Size(530, 76);
            this.PathSetGroup.TabIndex = 0;
            this.PathSetGroup.TabStop = false;
            this.PathSetGroup.Text = "PathSetGroup";
            // 
            // BT_OpenDialog
            // 
            this.BT_OpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_OpenDialog.Location = new System.Drawing.Point(439, 26);
            this.BT_OpenDialog.Name = "BT_OpenDialog";
            this.BT_OpenDialog.Size = new System.Drawing.Size(75, 27);
            this.BT_OpenDialog.TabIndex = 1;
            this.BT_OpenDialog.TabStop = false;
            this.BT_OpenDialog.Text = "参照";
            this.BT_OpenDialog.UseVisualStyleBackColor = true;
            this.BT_OpenDialog.Click += new System.EventHandler(this.BT_OpenDialog_Click);
            // 
            // PathText
            // 
            this.PathText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathText.Location = new System.Drawing.Point(16, 26);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(417, 27);
            this.PathText.TabIndex = 0;
            // 
            // PathSetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PathSetGroup);
            this.Name = "PathSetControl";
            this.Size = new System.Drawing.Size(530, 76);
            this.PathSetGroup.ResumeLayout(false);
            this.PathSetGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PathSetGroup;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button BT_OpenDialog;
    }
}
