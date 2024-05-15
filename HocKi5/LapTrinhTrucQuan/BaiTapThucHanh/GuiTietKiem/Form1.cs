using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GuiTietKiem
{
    public partial class Form1 : Form
    {
        List<KhachHang> _lstKhachHang;
        ProcessDatabase _processDatabase = new ProcessDatabase();
        string _tblKhachHang = "KhackHang";
        string _attributeList = "maKH, hotenKH, diaChi, soTienGui, ngayGui, thoiHanGui, phatLoc, tienLai, tongTien";
        
        public Form1()
        {
            _lstKhachHang = new List<KhachHang>();
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbThoiHan.Items.Add(1);
            cmbThoiHan.Items.Add(3);
            cmbThoiHan.Items.Add(6);
            cmbThoiHan.Items.Add(12);

            this.KeyPreview = true;

            dgvDanhSachKH.DataSource = _processDatabase.DocBang($"select * from {_tblKhachHang}");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.M)
            {
                btnThemMoi.PerformClick();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTienGui_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemVoDS_Click(object sender, EventArgs e)
        {
            string maKH, tenKH, diaChi;
            float soTienGui;
            int thoiGianGui, phatLoc = 1;
            DateTime ngayGui;

            if (Validate() == true)
            {
                maKH = txtMaKH.Text;
                tenKH = txtHoTenKH.Text;
                diaChi = txtDiaChi.Text;
                soTienGui = float.Parse(txtSoTienGui.Text);
                thoiGianGui = int.Parse(cmbThoiHan.SelectedItem.ToString());
                if (rdbPhatLoc.Checked == true)
                    phatLoc = 1;
                else if (rdbThuong.Checked == true)
                    phatLoc = 0;
                ngayGui = datNgayGui.Value;

                KhachHang tmp = new KhachHang(maKH, tenKH, diaChi, soTienGui, ngayGui, thoiGianGui, phatLoc);
                
                _lstKhachHang.Add(tmp);
                lstBoxDanhSachKH.Items.Add(tmp);

                _processDatabase.CapNhat($"insert into {_tblKhachHang}({_attributeList}) values(N'{maKH}', N'{tenKH}', N'{diaChi}', {soTienGui}, {ngayGui}, {thoiGianGui}, {phatLoc}, {tmp.TienLai}, {soTienGui + tmp.TienLai})");
               
            }
            
        }

        private bool Validate()
        {
            if(txtMaKH.Text.Trim() == "" ||
                txtHoTenKH.Text.Trim() == "" ||
                txtDiaChi.Text.Trim() == "" ||
                txtSoTienGui.Text.Trim().Length == 0 ||
                datNgayGui.Value.ToString() == "" ||
                (rdbPhatLoc.Checked == false && rdbThuong.Checked == false) || 
                cmbThoiHan.Text == "")
            {
                MessageBox.Show("Nhap du lieu lai di cmm");
                return false;
            }
            else if (txtMaKH.Text.Length != 6)
            {
                MessageBox.Show("Mã khách hàng là 1 số có 6 chữ số");
                return false;
            }
            return true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSoTienGui.Text = "";
            rdbPhatLoc.Checked = false;
            rdbThuong.Checked = false;
            cmbThoiHan.SelectedIndex = -1;
        }

        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho phép nhập số ở textbox 
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho phép nhập số ở textbox 
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Show a message box asking the user to confirm if they want to exit.
            DialogResult result = MessageBox.Show("Có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Close the form.
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Show a pop-up form that allows the user to enter the customer ID.
            Form formTimKiemKhachHang = new Form();
            formTimKiemKhachHang.Text = "Tìm kiếm khách hàng";

            // Add a textbox to the form for the customer ID.
            TextBox textBoxMaKH = new TextBox();
            textBoxMaKH.Location = new Point(10, 10);
            textBoxMaKH.Width = 200;
            formTimKiemKhachHang.Controls.Add(textBoxMaKH);

            Label labelThongTinKhach = new Label();
            labelThongTinKhach.Location = new Point(10, 40);
            labelThongTinKhach.Size = new Size(200, 200);
            formTimKiemKhachHang.Controls.Add(labelThongTinKhach);

            // Add a button to the form to search for the customer.
            Button buttonTimKiem = new Button();
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.Location = new Point(210, 10);
            buttonTimKiem.Click += (sender2, e2) =>
            {
                // Get the customer ID from the textbox.
                string maKHCanTim = textBoxMaKH.Text;

                // Find the customer in the database.
                KhachHang customer = GetCustomerByID(maKHCanTim);
             //   MessageBox.Show(customer.HoTenKH);

                // If the customer is found, show their information in a new form.
                if (customer != null)
                {
                    labelThongTinKhach.Text = customer.ThongTin();
                }
                else
                {
                    // The customer was not found.
                    MessageBox.Show("Không tim thấy khách hàng nào có mã: " + maKHCanTim, "Lỗi tìm kiếm");
                }
            };
            formTimKiemKhachHang.Controls.Add(buttonTimKiem);

            formTimKiemKhachHang.Show();
        }

        private KhachHang GetCustomerByID(string maKH)
        {
            foreach (KhachHang k in _lstKhachHang)
            {
                if (k.MaKH.ToString() ==  maKH.ToString())
                { return k; }
            }
            return null;
        }

        private void lstDS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBoxDanhSachKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void dgvDanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datNgayGui_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
