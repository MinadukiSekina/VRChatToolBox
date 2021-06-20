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
            this.DTP_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.LI_WorldList = new System.Windows.Forms.ListBox();
            this.LI_JoinList = new System.Windows.Forms.ListBox();
            this.LI_ExitList = new System.Windows.Forms.ListBox();
            this.PN_Function = new System.Windows.Forms.Panel();
            this.LB_F1 = new System.Windows.Forms.Label();
            this.LB_ESC = new System.Windows.Forms.Label();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Return = new System.Windows.Forms.Button();
            this.LB_JoinList = new System.Windows.Forms.Label();
            this.LB_Exit = new System.Windows.Forms.Label();
            this.LB_World = new System.Windows.Forms.Label();
            this.PN_Function.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTP_TimePicker
            // 
            this.DTP_TimePicker.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.DTP_TimePicker.Location = new System.Drawing.Point(32, 12);
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
            this.PN_Function.Controls.Add(this.LB_F1);
            this.PN_Function.Controls.Add(this.LB_ESC);
            this.PN_Function.Controls.Add(this.BT_Cancel);
            this.PN_Function.Controls.Add(this.BT_Return);
            this.PN_Function.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PN_Function.Location = new System.Drawing.Point(0, 542);
            this.PN_Function.Margin = new System.Windows.Forms.Padding(2);
            this.PN_Function.Name = "PN_Function";
            this.PN_Function.Size = new System.Drawing.Size(680, 61);
            this.PN_Function.TabIndex = 6;
            // 
            // LB_F1
            // 
            this.LB_F1.AutoSize = true;
            this.LB_F1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_F1.Location = new System.Drawing.Point(125, 7);
            this.LB_F1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_F1.Name = "LB_F1";
            this.LB_F1.Size = new System.Drawing.Size(22, 14);
            this.LB_F1.TabIndex = 5;
            this.LB_F1.Text = "F1";
            // 
            // LB_ESC
            // 
            this.LB_ESC.AutoSize = true;
            this.LB_ESC.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LB_ESC.Location = new System.Drawing.Point(22, 7);
            this.LB_ESC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ESC.Name = "LB_ESC";
            this.LB_ESC.Size = new System.Drawing.Size(32, 14);
            this.LB_ESC.TabIndex = 4;
            this.LB_ESC.Text = "ESC";
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BT_Cancel.Location = new System.Drawing.Point(24, 24);
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
            this.BT_Return.Location = new System.Drawing.Point(128, 24);
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
            // LogBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 603);
            this.Controls.Add(this.LB_World);
            this.Controls.Add(this.LB_Exit);
            this.Controls.Add(this.LB_JoinList);
            this.Controls.Add(this.PN_Function);
            this.Controls.Add(this.LI_ExitList);
            this.Controls.Add(this.LI_JoinList);
            this.Controls.Add(this.LI_WorldList);
            this.Controls.Add(this.DTP_TimePicker);
            this.KeyPreview = true;
            this.Name = "LogBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログ確認";
            this.Load += new System.EventHandler(this.LogBrowser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogBrowser_KeyDown);
            this.PN_Function.ResumeLayout(false);
            this.PN_Function.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_TimePicker;
        private System.Windows.Forms.ListBox LI_WorldList;
        private System.Windows.Forms.ListBox LI_JoinList;
        private System.Windows.Forms.ListBox LI_ExitList;
        private System.Windows.Forms.Panel PN_Function;
        private System.Windows.Forms.Label LB_F1;
        private System.Windows.Forms.Label LB_ESC;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Return;
        private System.Windows.Forms.Label LB_JoinList;
        private System.Windows.Forms.Label LB_Exit;
        private System.Windows.Forms.Label LB_World;
    }
}