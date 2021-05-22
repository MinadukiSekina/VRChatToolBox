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
    public partial class SettingsEditor : Form
    {
        public SettingsEditor()
        {
            InitializeComponent();
            //PSC_SavedLogPath.ControlText = "VRChatのログの保存場所";
            
        }

        private void SettingsEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SelectNextControl(ActiveControl, true, true, true, true);
        }
    }
}
