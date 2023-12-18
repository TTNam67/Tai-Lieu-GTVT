using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiKetThucHocPhan
{
    public partial class Form1 : Form
    {
        DatabaseProcess dp = new DatabaseProcess();
        string tableName = "DanhSachKhachHang";
        List<KhachHang> listKhachHang = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = dp.DocBang($"select * from {tableName}");
            dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns["HoTenKhachHang"].HeaderText = "Họ tên khách hàng";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["NgayChotSo"].HeaderText = "Ngày chốt sổ";
            dgvKhachHang.Columns["SoThangTruoc"].HeaderText = "Số tháng trước";
            dgvKhachHang.Columns["SoThangNay"].HeaderText = "Số tháng này";

            //Convert.ToDateTime(txtKhachThue_NgaySinh.Text)

            DataTable dataTable = dp.DocBang($"select * from {tableName}");

            foreach (DataRow row in dataTable.Rows)
            {
                string maKhachHang = row["MaKhachHang"].ToString();
                string hoTenKhachHang = row["HoTenKhachHang"].ToString();
                string diaChi = row["DiaChi"].ToString();
                DateTime ngayChotSo = Convert.ToDateTime(row["NgayChotSo"].ToString());
                int soThangTruoc = int.Parse(row["SoThangTruoc"].ToString());
                int soThangNay = int.Parse(row["SoThangNay"].ToString());



                listKhachHang.Add(new KhachHang(maKhachHang, hoTenKhachHang, diaChi, ngayChotSo, soThangTruoc, soThangNay));
            }

            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                this.Close();
            }
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            string tenTacGia, maTacPham, tenTacPham, loaiTacPham;
            if (Validate() == true && ValidateForExistence() == true)
            {
                string maKhachHang = txtMaKhachHang.Text;
                string hoTenKhachHang = txtHoTenKhachHang.Text;
                string diaChi = txtDiaChi.Text;
                DateTime ngayChotSo = Convert.ToDateTime(txtNgayChotSo.Text);
                int soThangTruoc = int.Parse(txtSoThangTruoc.Text);
                int soThangNay = int.Parse(txtSoThangNay.Text);
                   
                
                dp.CapNhat($"insert into {tableName}(MaKhachHang, HoTenKhachHang, DiaChi, NgayChotSo, SoThangTruoc, SoThangNay) values(N'{maKhachHang}', N'{hoTenKhachHang}', N'{diaChi}', N'{ngayChotSo}', N'{soThangTruoc}', N'{soThangNay}')");

                KhachHang tmp = new KhachHang(maKhachHang, hoTenKhachHang, diaChi, ngayChotSo, soThangTruoc, soThangNay);
                
                listKhachHang.Append(tmp);

                Refresh();
                
            }
        }

        private bool Validate()
        {
            if (txtMaKhachHang.Text.Trim() == "" ||
                txtHoTenKhachHang.Text.Trim() == "" ||
                txtDiaChi.Text.Trim() == "" ||
                txtNgayChotSo.Text.Trim() == "" ||
                txtSoThangTruoc.Text.Trim() == ""||
                txtSoThangNay.Text.Trim() == "")
            {
                MessageBox.Show("Chua nhập đủ dữ liệu");
                return false;
            }

            if (int.Parse(txtSoThangTruoc.Text) > int.Parse(txtSoThangNay.Text))
            {
                MessageBox.Show("Số tháng trước phải <= số tháng này");
                return false;
            }


            

            return true;
        }

        


        private bool ValidateForExistence()
        {
            string maKhachHangMoi = txtMaKhachHang.Text.Trim();

           
            for (int i = 0; i < listKhachHang.Count; i++)
            {
                MessageBox.Show($"ma cu: {listKhachHang[i].MaKhachHang}, ma moi: {maKhachHangMoi}");
                if (maKhachHangMoi == listKhachHang[i].MaKhachHang.Trim())
                {
                    MessageBox.Show("Khách hàng có mã này đã tồn tại trong hệ thống");
                    return false;
                }
            }
            return true;
        }

        public void Refresh()
        {
            txtMaKhachHang.Text = "";
            txtHoTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtNgayChotSo.Text = "";
            txtSoThangTruoc.Text = "";
            txtSoThangNay.Text = "";


            dgvKhachHang.DataSource = dp.DocBang($"select * from {tableName}");
        }


        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void txtSoThangTruoc_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void txtSoThangNay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoThangNay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Chỉ nhập số nguyên vào mục này");
            }
        }

        private void txtSoThangTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;    
                MessageBox.Show("Chỉ nhập số nguyên vào mục này");
            }
        }

        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thông tin của khách hàng có mã: {txtMaKhachHang.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            string sql = $"Delete from {tableName} where MaKhachHang = '{txtMaKhachHang.Text}'";
            dp.CapNhat(sql);

            for (int i = 0; i < listKhachHang.Count; i++)
            {
                if (listKhachHang[i].MaKhachHang == txtMaKhachHang.Text)
                {
                    listKhachHang.RemoveAt(i);
                }
            }

            Refresh();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            txtMaKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
            txtHoTenKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells["HoTenKhachHang"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtNgayChotSo.Text = dgvKhachHang.SelectedRows[0].Cells["NgayChotSo"].Value.ToString();
            txtSoThangTruoc.Text = dgvKhachHang.SelectedRows[0].Cells["SoThangTruoc"].Value.ToString();
            txtSoThangNay.Text = dgvKhachHang.SelectedRows[0].Cells["SoThangNay"].Value.ToString();
            */
        }

        private void dgvKhachHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            txtMaKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
            txtHoTenKhachHang.Text = dgvKhachHang.SelectedRows[0].Cells["HoTenKhachHang"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtNgayChotSo.Text = dgvKhachHang.SelectedRows[0].Cells["NgayChotSo"].Value.ToString();
            txtSoThangTruoc.Text = dgvKhachHang.SelectedRows[0].Cells["SoThangTruoc"].Value.ToString();
            txtSoThangNay.Text = dgvKhachHang.SelectedRows[0].Cells["SoThangNay"].Value.ToString();
            */
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.M)
            {
                txtMaKhachHang.Text = "";
                txtHoTenKhachHang.Text = "";
                txtDiaChi.Text = "";
                txtNgayChotSo.Text = "";
                txtSoThangTruoc.Text = "";
                txtSoThangNay.Text = "";


                dgvKhachHang.DataSource = dp.DocBang($"select * from {tableName}");
            }
            else if (e.Alt && e.KeyCode == Keys.T)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                
                    this.Close();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
