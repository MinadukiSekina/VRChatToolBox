namespace VRChatToolBox
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_EditLog = new System.Windows.Forms.Button();
            this.BT_PicturesMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_EditLog
            // 
            this.BT_EditLog.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_EditLog.Location = new System.Drawing.Point(128, 71);
            this.BT_EditLog.Name = "BT_EditLog";
            this.BT_EditLog.Size = new System.Drawing.Size(121, 34);
            this.BT_EditLog.TabIndex = 0;
            this.BT_EditLog.Text = "ログ出力";
            this.BT_EditLog.UseVisualStyleBackColor = true;
            this.BT_EditLog.Click += new System.EventHandler(this.BT_EditLog_Click);
            // 
            // BT_PicturesMove
            // 
            this.BT_PicturesMove.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_PicturesMove.Location = new System.Drawing.Point(128, 122);
            this.BT_PicturesMove.Name = "BT_PicturesMove";
            this.BT_PicturesMove.Size = new System.Drawing.Size(121, 34);
            this.BT_PicturesMove.TabIndex = 1;
            this.BT_PicturesMove.Text = "写真整理";
            this.BT_PicturesMove.UseVisualStyleBackColor = true;
            this.BT_PicturesMove.Click += new System.EventHandler(this.BT_PicturesMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 243);
            this.Controls.Add(this.BT_PicturesMove);
            this.Controls.Add(this.BT_EditLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_EditLog;
        private System.Windows.Forms.Button BT_PicturesMove;
    }
}

