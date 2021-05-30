using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRChatToolBox
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, "VRChatToolBox");
            bool hasHandle = false;
            try{
                try
                {
                    hasHandle = mutex.WaitOne(0, false);
                }
                catch (System.Threading.AbandonedMutexException)
                {
                    hasHandle = true;
                }
                if (!hasHandle)
                {
                    MessageBox.Show("既に起動しています。");
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            finally
            {
                if (hasHandle) mutex.ReleaseMutex();
                mutex.Close();
                mutex.Dispose();
            }
        }
    }
}
