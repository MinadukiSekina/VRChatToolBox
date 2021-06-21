using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRChatToolBox
{
    public partial class LogBrowser : Form
    {
        private string[][] JoinList { get; set; }
        private string[][] ExitList { get; set; }
        private DateTime NowDateTime { get; set; }

        public LogBrowser()
        {
            InitializeComponent();
        }

        private void LogBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                NowDateTime = DateTime.Now;
                FormClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "起動時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        // 日付選択時
        private void DTP_TimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                InitLists(DTP_TimePicker.Value.ToString("yyyyMMdd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 閉じる
        private void BT_Return_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ワールド選択時
        private void LI_WorldList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = LI_WorldList.SelectedIndex;

                if (index == -1) return;

                LI_JoinList.Items.Clear();
                LI_ExitList.Items.Clear();
                LI_JoinList.Items.AddRange(JoinList[index]);
                LI_ExitList.Items.AddRange(ExitList[index]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // キャンセル
        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                FormClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "処理エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 初期化
        private void FormClear()
        {
            DTP_TimePicker.Value = NowDateTime;
            InitLists(DTP_TimePicker.Value.ToString("yyyyMMdd"));
        }

        // 指定した日付での読み込み
        private void InitLists(string dateString)
        {
            string[] worldList = new string[] { };
            string[][] joinList = new string[][] { };
            string[][] exitList = new string[][] { };

            LI_WorldList.Items.Clear();
            LI_JoinList.Items.Clear();
            LI_ExitList.Items.Clear();

            LogEditor.GetListFromEditedLog(dateString, ref worldList, ref joinList, ref exitList);

            LI_WorldList.Items.AddRange(worldList);
            JoinList = joinList;
            ExitList = exitList;
        }

    }
}
