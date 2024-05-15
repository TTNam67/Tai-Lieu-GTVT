using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addData();
        }

        private void addData()
        {
            lstDanhSachMatHang.Items.Add("Kỹ thuật lập tình C#");
            lstDanhSachMatHang.Items.Add("Tự học Visual C# trong 21 ngày");
            lstDanhSachMatHang.Items.Add("Bìa tập C#");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 1");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 2");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 3");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 4");
            lstDanhSachMatHang.Items.Add("Tin học cơ bản");
            lstDanhSachMatHang.Items.Add("SQL Server");
            lstDanhSachMatHang.Items.Add("Cơ bản về XML");
            lstDanhSachMatHang.Items.Add("Phân tích thiết kế hệ thống");
            lstDanhSachMatHang.Items.Add("Sử dụng Word");
            lstDanhSachMatHang.Items.Add("Đến với Word 2003");

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        private void lstDanhSachMatHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string curItem = lstDanhSachMatHang.SelectedItem.ToString();
            string curr = lstDanhSachMatHang.SelectedItem.ToString();
            //Tìm kiếm xem có trong bảng đặt mua
            int index = lstHangDatMua.FindString(curItem);
            //Nếu mà k có thì in thông báo và thêm vào hàng đặt mua và ngược lại
            if (index == -1)
            {
                lstHangDatMua.Items.Add(curr);
                
            }
            else
                MessageBox.Show("Hàng đặt mua đã có rồi ");
        }



        private void lstHangDatMua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstHangDatMua.SelectedIndex;
            if(MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                lstHangDatMua.Items.RemoveAt(index);
        }

        private string HinhThucLL()
        {
            string a = "";
            if(chbDienThoai.Checked == true)
            {
                a += "     " + chbDienThoai.Text; 
            }
            if(chbFax.Checked == true)
            {
                a += "     " + chbFax.Text;
            }
            if(chbEmail.Checked == true)
            {
                a += "     " + chbEmail.Text;
            }
            return a;
        }

        private string ThanhToan()
        {
            string s = "";
            if(rdbTienMat.Checked == true)
            {
                s += rdbTienMat.Text;
            }
            else if(rdbSec.Checked == true)
            {
                s += rdbSec.Text;
            }
            else if(rdbTheTinDung.Checked == true)
            {
                s += rdbTheTinDung.Text;
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals("") || txtDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo");
                txtTen.Focus();
            }
            else
            {
                string sb = "";
                foreach(object item in lstHangDatMua.Items)
                {
                    sb += (item.ToString());
                    sb += ("\n");
                    
                }
                MessageBox.Show(sb + ThanhToan() + HinhThucLL());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
