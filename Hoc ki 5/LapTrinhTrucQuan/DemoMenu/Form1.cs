using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HinhChuNhat h = new HinhChuNhat();
            h.ShowDialog();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // Specify the path to your media file (e.g., an MP3 file)
            string mediaFilePath = @"D:\Hoc ki 5\LapTrinhTrucQuan\Rick Roll.mp3";

            // Load the media file and start playback
            axWindowsMediaPlayer1.URL = mediaFilePath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Bac1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPTBac1 giaiPTBac1 = new GiaiPTBac1();
            giaiPTBac1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void xanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
