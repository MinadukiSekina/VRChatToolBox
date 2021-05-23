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
            this.PN_Function.SuspendLayout();
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
            this.PSC_LogEditedPath.Location = new System.Drawing.Point(12, 210);
            this.PSC_LogEditedPath.Name = "PSC_LogEditedPath";
            this.PSC_LogEditedPath.SelectedPath = "";
            this.PSC_LogEditedPath.Size = new System.Drawing.Size(580, 76);
            this.PSC_LogEditedPath.TabIndex = 2;
            this.PSC_LogEditedPath.Title = "編集したログの保存場所";
            // 
            // PSC_LogMovedPath
            // 
            this.PSC_LogMovedPath.Location = new System.Drawing.Point(12, 114);
            this.PSC_LogMovedPath.Name = "PSC_LogMovedPath";
            this.PSC_LogMovedPath.SelectedPath = "";
            this.PSC_LogMovedPath.Size = new System.Drawing.Size(580, 76);
            this.PSC_LogMovedPath.TabIndex = 1;
            this.PSC_LogMovedPath.Title = "VRChatログのコピー場所";
            // 
            // PSC_PicturesMovedPath
            // 
            this.PSC_PicturesMovedPath.Location = new System.Drawing.Point(602, 114);
            this.PSC_PicturesMovedPath.Name = "PSC_PicturesMovedPath";
            this.PSC_PicturesMovedPath.SelectedPath = "";
            this.PSC_PicturesMovedPath.Size = new System.Drawing.Size(580, 76);
            this.PSC_PicturesMovedPath.TabIndex = 4;
            this.PSC_PicturesMovedPath.Title = "写真の整理保存場所";
            // 
            // PSC_PicturesSavedPath
            // 
            this.PSC_PicturesSavedPath.Location = new System.Drawing.Point(602, 18);
            this.PSC_PicturesSavedPath.Name = "PSC_PicturesSavedPath";
            this.PSC_PicturesSavedPath.SelectedPath = "";
            this.PSC_PicturesSavedPath.Size = new System.Drawing.Size(580, 76);
            this.PSC_PicturesSavedPath.TabIndex = 3;
            this.PSC_PicturesSavedPath.Title = "VRChat写真の場所";
            // 
            // PSC_LogSavedPath
            // 
            this.PSC_LogSavedPath.Location = new System.Drawing.Point(12, 18);
            this.PSC_LogSavedPath.Name = "PSC_LogSavedPath";
            this.PSC_LogSavedPath.SelectedPath = "";
            this.PSC_LogSavedPath.Size = new System.Drawing.Size(580, 76);
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
            this.PN_Function.Controls.Add(this.BT_Save);
            this.PN_Function.Controls.Add(this.BT_Cancel);
            this.PN_Function.Controls.Add(this.BT_Return);
            this.PN_Function.Controls.Add(this.BT_Reset);
            this.PN_Function.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Function.Location = new System.Drawing.Point(0, 314);
            this.PN_Function.Name = "PN_Function";
            this.PN_Function.Size = new System.Drawing.Size(1194, 76);
            this.PN_Function.TabIndex = 5;
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 390);
            this.Controls.Add(this.PN_Function);
            this.Controls.Add(this.PSC_LogEditedPath);
            this.Controls.Add(this.PSC_LogMovedPath);
            this.Controls.Add(this.PSC_PicturesMovedPath);
            this.Controls.Add(this.PSC_PicturesSavedPath);
            this.Controls.Add(this.PSC_LogSavedPath);
            this.KeyPreview = true;
            this.Name = "SettingsEditor";
            this.Text = "SettingsEditor";
            this.Load += new System.EventHandler(this.SettingsEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsEditor_KeyDown);
            this.PN_Function.ResumeLayout(false);
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
    }
}