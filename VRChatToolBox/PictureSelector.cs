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

        }

        private void PictureSelector_Load(object sender, EventArgs e)
        {
            pictureExplorer1.Init(ProgramSettings.Settings.DesignatedPicturesSavedFolder, PB_Display);
            pictureExplorer2.Init(ProgramSettings.Settings.DesignatedPicturesMovedFolder, PB_Display);
        }

        private void PB_Display_MouseDown(object sender, MouseEventArgs e)
        {
            DataObject dataObject = new DataObject(DataFormats.FileDrop, PB_Display.ImageLocation);
            PB_Display.DoDragDrop(dataObject, DragDropEffects.Copy);
        }

    }
}
