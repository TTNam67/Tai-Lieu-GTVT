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
    public partial class GiaiPTBac1 : Form
    {
        public GiaiPTBac1()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            float a, b;
            bool k1 = float.TryParse(txtA.Text, out a);
            bool k2 = float.TryParse(txtB.Text, out b);

            if (k1 == true && k2 == true)
            {
                if (a == 0)
                {
                    labKetQua.Text = "Phương trình vô nghiệm dmm";
                }
                else
                {
                    float nghiem = -b / a;
                    labKetQua.Text = "Nghiệm là: " + nghiem.ToString();
                }
                
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // Specify the path to your media file (e.g., an MP3 file)
            string mediaFilePath = @"D:\Hoc ki 5\LapTrinhTrucQuan\Rick Roll.mp3";

            // Load the media file and start playback
            axWindowsMediaPlayer1.URL = mediaFilePath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
