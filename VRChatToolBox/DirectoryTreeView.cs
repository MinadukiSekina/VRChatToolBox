using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VRChatToolBox
{
    class DirectoryTreeView : TreeView
    {

        // 初期化処理
        internal void InitList()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                TreeNode node = new TreeNode(drive);
                node.Nodes.Add(new TreeNode());
                Nodes.Add(node);
            }

        }

        // ノード展開時
        protected override void OnBeforeExpand(TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            string path = node.FullPath;
            node.Nodes.Clear();

            try
            {
                DirectoryInfo parentInfo = new DirectoryInfo(path);
                foreach (DirectoryInfo childInfo in parentInfo.GetDirectories())
                {
                    TreeNode child = new TreeNode(childInfo.Name);
                    child.Nodes.Add(new TreeNode());
                    node.Nodes.Add(child);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "選択エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // 基底クラスの処理呼び出し
            base.OnBeforeExpand(e);

        }

    }
}
