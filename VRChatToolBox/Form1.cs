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
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
                ProgramSettings.InitializeSettings();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "起動時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_EditLog_Click(object sender, EventArgs e)
        {
            try
            {
                LogEditor.CopyAndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}", "処理時エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
