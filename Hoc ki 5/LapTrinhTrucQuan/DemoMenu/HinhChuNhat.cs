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
    public partial class HinhChuNhat : Form
    {
        public HinhChuNhat()
        {
            InitializeComponent();
        }

        private void TinhDienTich_Click(object sender, EventArgs e)
        {
            float a, b;
            bool k = float.TryParse(txtChieuDai.Text, out a);
            bool k2 = float.TryParse(txtChieuRong.Text, out b);

            if (k == true && k2 == true)
            {
                labKetQua.Text = "Diện tích là: " + (a * b).ToString();
            }
            else
            {
                MessageBox.Show("Dm nhap co dung dau");
            }
        }

        private void DoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labKetQua.BackColor = Color.Red;
        }

        private void XanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labKetQua.BackColor = Color.Green;
        }

        private void VangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labKetQua.BackColor= Color.Yellow;
        }
    }
}
