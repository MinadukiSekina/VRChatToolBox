namespace VRChatToolBox
{
    partial class LogBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogBrowser));
            this.DTP_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.LI_WorldList = new System.Windows.Forms.ListBox();
            this.LI_JoinList = new System.Windows.Forms.ListBox();
            this.LI_ExitList = new System.Windows.Forms.ListBox();
            this.PN_Function = new System.Windows.Forms.Panel();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Return = new System.Windows.Forms.Button();
            this.LB_JoinList = new System.Windows.Forms.Label();
            this.LB_Exit = new System.Windows.Forms.Label();
            this.LB_World = new System.Windows.Forms.Label();
            this.BT_NextDay = new System.Windows.Forms.Button();
            this.BT_BeforeDay = new System.Windows.Forms.Button();
            this.PN_Function.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTP_TimePicker
            // 
            this.DTP_TimePicker.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.DTP_TimePicker.Location = new System.Drawing.Point(81, 12);
            this.DTP_TimePicker.Name = "DTP_TimePicker";
            this.DTP_TimePicker.Size = new System.Drawing.Size(170, 29);
            this.DTP_TimePicker.TabIndex = 0;
            this.DTP_TimePicker.Value = new System.DateTime(2021, 6, 19, 19, 4, 0, 0);
            this.DTP_TimePicker.ValueChanged += new System.EventHandler(this.DTP_TimePicker_ValueChanged);
            // 
            // LI_WorldList
            // 
            this.LI_WorldList.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LI_WorldList.FormattingEnabled = true;
            this.LI_WorldList.ItemHeight = 16;
            this.LI_WorldList.Location = new System.Drawing.Point(32, 76);
            this.LI_WorldList.Name = "LI_WorldList";
            this.LI_WorldList.Size = new System.Drawing.Size(612, 132);
            this.LI_WorldList.TabIndex = 1;
            this.LI_WorldList.SelectedIndexChanged += new System.EventHandler(this.LI_WorldList_SelectedIndexChanged);
            // 
            // LI_JoinList
            // 
            this.LI_JoinList.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LI_JoinList.FormattingEnabled = true;
            this.LI_JoinList.ItemHeight = 16;
            this.LI_JoinList.Location = new System.Drawing.Point(32, 230);
            this.LI_JoinList.Name = "LI_JoinList";
            this.LI_JoinList.Size = new System.Drawing.Size(612, 132);
            this.LI_JoinList.TabIndex = 2;
            // 
            // LI_ExitList
            // 
            this.LI_ExitList.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LI_ExitList.FormattingEnabled = true;
            this.LI_ExitList.ItemHeight = 16;
            this.LI_ExitList.Location = new System.Drawing.Point(32, 384);
            this.LI_ExitList.Name = "LI_ExitList";
            this.LI_ExitList.Size = new System.Drawing.Size(612, 132);
            this.LI_ExitList.TabIndex = 3;
            // 
            // PN_Function
            // 
            this.PN_Function.Controls.Add(this.BT_Cancel);
            this.PN_Function.Controls.Add(this.BT_Return);
            this.PN_Function.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Function.Location = new System.Drawing.Point(0, 527);
            this.PN_Function.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Function.Name = "PN_Function";
            this.PN_Function.Size = new System.Drawing.Size(680, 46);
            this.PN_Function.TabIndex = 6;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Cancel.Location = new System.Drawing.Point(24, 9);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(91, 27);
            this.BT_Cancel.TabIndex = 0;
            this.BT_Cancel.Text = "キャンセル";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Return
            // 
            this.BT_Return.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Return.Location = new System.Drawing.Point(128, 9);
            this.BT_Return.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Return.Name = "BT_Return";
            this.BT_Return.Size = new System.Drawing.Size(91, 27);
            this.BT_Return.TabIndex = 1;
            this.BT_Return.Text = "戻る";
            this.BT_Return.UseVisualStyleBackColor = true;
            this.BT_Return.Click += new System.EventHandler(this.BT_Return_Click);
            // 
            // LB_JoinList
            // 
            this.LB_JoinList.AutoSize = true;
            this.LB_JoinList.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LB_JoinList.Location = new System.Drawing.Point(29, 211);
            this.LB_JoinList.Name = "LB_JoinList";
            this.LB_JoinList.Size = new System.Drawing.Size(68, 16);
            this.LB_JoinList.TabIndex = 7;
            this.LB_JoinList.Text = "Joinリスト";
            // 
            // LB_Exit
            // 
            this.LB_Exit.AutoSize = true;
            this.LB_Exit.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LB_Exit.Location = new System.Drawing.Point(29, 365);
            this.LB_Exit.Name = "LB_Exit";
            this.LB_Exit.Size = new System.Drawing.Size(65, 16);
            this.LB_Exit.TabIndex = 8;
            this.LB_Exit.Text = "Exitリスト";
            // 
            // LB_World
            // 
            this.LB_World.AutoSize = true;
            this.LB_World.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.LB_World.Location = new System.Drawing.Point(29, 57);
            this.LB_World.Name = "LB_World";
            this.LB_World.Size = new System.Drawing.Size(97, 16);
            this.LB_World.TabIndex = 9;
            this.LB_World.Text = "行ったワールド";
            // 
            // BT_NextDay
            // 
            this.BT_NextDay.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_NextDay.Location = new System.Drawing.Point(259, 12);
            this.BT_NextDay.Name = "BT_NextDay";
            this.BT_NextDay.Size = new System.Drawing.Size(41, 29);
            this.BT_NextDay.TabIndex = 10;
            this.BT_NextDay.Text = "次";
            this.BT_NextDay.UseVisualStyleBackColor = true;
            this.BT_NextDay.Click += new System.EventHandler(this.BT_NextDay_Click);
            // 
            // BT_BeforeDay
            // 
            this.BT_BeforeDay.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_BeforeDay.Location = new System.Drawing.Point(32, 12);
            this.BT_BeforeDay.Name = "BT_BeforeDay";
            this.BT_BeforeDay.Size = new System.Drawing.Size(41, 29);
            this.BT_BeforeDay.TabIndex = 11;
            this.BT_BeforeDay.Text = "前";
            this.BT_BeforeDay.UseVisualStyleBackColor = true;
            this.BT_BeforeDay.Click += new System.EventHandler(this.BT_BeforeDay_Click);
            // 
            // LogBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 573);
            this.Controls.Add(this.BT_BeforeDay);
            this.Controls.Add(this.BT_NextDay);
            this.Controls.Add(this.LB_World);
            this.Controls.Add(this.LB_Exit);
            this.Controls.Add(this.LB_JoinList);
            this.Controls.Add(this.PN_Function);
            this.Controls.Add(this.LI_ExitList);
            this.Controls.Add(this.LI_JoinList);
            this.Controls.Add(this.LI_WorldList);
            this.Controls.Add(this.DTP_TimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LogBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログ確認";
            this.Load += new System.EventHandler(this.LogBrowser_Load);
            this.PN_Function.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_TimePicker;
        private System.Windows.Forms.ListBox LI_WorldList;
        private System.Windows.Forms.ListBox LI_JoinList;
        private System.Windows.Forms.ListBox LI_ExitList;
        private System.Windows.Forms.Panel PN_Function;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Return;
        private System.Windows.Forms.Label LB_JoinList;
        private System.Windows.Forms.Label LB_Exit;
        private System.Windows.Forms.Label LB_World;
        private System.Windows.Forms.Button BT_NextDay;
        private System.Windows.Forms.Button BT_BeforeDay;
    }
}