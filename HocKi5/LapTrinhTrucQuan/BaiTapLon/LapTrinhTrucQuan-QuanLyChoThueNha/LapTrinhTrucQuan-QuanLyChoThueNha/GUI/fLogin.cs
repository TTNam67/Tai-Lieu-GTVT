using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class fLogin : Form
    {
        string tentk, mk, tenht;
        public fLogin()
        {
            InitializeComponent();


            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Close the form.
                this.Close();
            }
        }

        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbLoginUserName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản!");
                tbLoginUserName.Focus();
                return;
            }
            if (tbLoginPassword.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                tbLoginPassword.Focus();
                return;
            }
            if (!taiKhoanBUS.CheckLogin(tbLoginUserName.Text, tbLoginPassword.Text))
            {
                MessageBox.Show("Sai mật khẩu hoặc tên tài khoản");
                return;
            }
            
            tentk = tbLoginUserName.Text;
            mk = tbLoginPassword.Text;
            tenht = taiKhoanBUS.GetTenHienThiTK(tbLoginUserName.Text).ToString();
            fManager f = new fManager(taiKhoanBUS.GetAccountByUserName(tbLoginUserName.Text), tentk, tenht, mk);
            this.Hide();
            f.ShowDialog();
        }
    }
}
