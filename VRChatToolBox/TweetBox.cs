using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace VRChatToolBox
{
    class TweetBox : TextBox
    {
       
        protected override void OnValidating(CancelEventArgs e)
        {

            if (Text.Length > 140)
            {
                MessageBox.Show("140文字を超えています。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
