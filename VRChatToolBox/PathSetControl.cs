using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRChatToolBox
{
    public partial class PathSetControl : UserControl
    {
        [Browsable(true)]
        public string Title
        {
            get { return PathSetGroup.Text; }
            set { PathSetGroup.Text = value; }
        }
        public PathSetControl()
        {
            InitializeComponent();
        }

        private void BT_OpenDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.SelectedPath = "C:\\";
            dialog.ShowNewFolderButton = true;
            dialog.Description = "フォルダ選択";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            PathText.Text = dialog.SelectedPath;
            SelectNextControl(PathText, true, true, true, true);

        }

    }
}
