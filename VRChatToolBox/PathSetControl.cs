using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        public string SelectedPath
        {
            get { return PathText.Text.Trim(); }
            set { PathText.Text = value; }
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

            PathText.Text = dialog.SelectedPath.Trim();
            PathText.Select();
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            PathText.Text = PathText.Text.Trim().TrimEnd('\\');
            if (!Directory.Exists(PathText.Text))
            {
                MessageBox.Show("存在しないパスです。", "選択エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

            base.OnValidating(e);
        }
    }

}
