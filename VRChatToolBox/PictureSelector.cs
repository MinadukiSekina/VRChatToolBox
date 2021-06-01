using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VRChatToolBox
{
    public partial class PictureSelector : Form
    {
        public PictureSelector()
        {
            InitializeComponent();

            foreach (string drive in Environment.GetLogicalDrives())
            {
                TreeNode node = new TreeNode(drive);
                node.Nodes.Add(new TreeNode());
                FolderView0.Nodes.Add(node);
            }
            //SetFileView(Environment.GetLogicalDrives().First());
            SetFileView("C:\\Users\\徳馬\\Pictures");
        }

        private void SetFileView(string folderPath)
        {
            // 初期化
            FileView0.Clear();
            if (ViewImageList.Images.Count >= 2)
            {
                for (int i = 1; i < ViewImageList.Images.Count; i++)
                {
                    ViewImageList.Images.RemoveAt(i);
                }
            }

            DirectoryInfo directoryList = new DirectoryInfo(folderPath);
            // フォルダの列挙
            foreach (DirectoryInfo folder in directoryList.EnumerateDirectories())
            {
                string[] items = { folder.Name, folder.FullName };
                ListViewItem listViewItem = new ListViewItem(items, 0);
                FileView0.Items.Add(listViewItem);
            }

            // 写真の列挙
            int j = 1;
            foreach (FileInfo file in directoryList.EnumerateFiles("*.png", SearchOption.TopDirectoryOnly))
            {
                string[] fileInfomation = { file.Name, file.FullName };
                ViewImageList.Images.Add(Bitmap.FromFile(file.FullName));
                ListViewItem listViewItem = new ListViewItem(fileInfomation, j);
                FileView0.Items.Add(listViewItem);
                j += 1;
            }
        }

        // ノードを開いた時
        private void FolderView0_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            String path = node.FullPath;
            node.Nodes.Clear();

            try
            {
                DirectoryInfo dirList = new DirectoryInfo(path);
                foreach (DirectoryInfo di in dirList.GetDirectories())
                {
                    TreeNode child = new TreeNode(di.Name);
                    child.Nodes.Add(new TreeNode());
                    node.Nodes.Add(child);
                }
            }
            catch (IOException ie)
            {
                MessageBox.Show(ie.Message, "選択エラー");
            }
        }

        // フォルダ選択時
        private void FolderView0_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SetFileView(e.Node.FullPath);
        }
    }
}
