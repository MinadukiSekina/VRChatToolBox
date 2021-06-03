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

            // 初期化
            directoryTreeView0.InitList();
            fileListView0.SetListItems(ProgramSettings.Settings.DesignatedPicturesSavedFolder);
            fileListView0.PictureDisp = PB_Picture;

            directoryTreeView1.InitList();
            fileListView1.SetListItems(ProgramSettings.Settings.DesignatedPicturesSavedFolder);
            fileListView1.PictureDisp = PB_Picture;
        }

    }
}
