using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace KiemTraGiuaKy
{
    public partial class Form1 : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        string tableName = "DanhSachTacPham";
        List<TacPham> _listTacPham = new List<TacPham>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTacPham.DataSource = pd.DocBang($"select * from {tableName}");
            dgvTacPham.Columns["MaTacPham"].HeaderText = "Mã tác phẩm";
            dgvTacPham.Columns["TenTacPham"].HeaderText = "Tên tác Phẩm";
            dgvTacPham.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvTacPham.Columns["LoaiTacPham"].HeaderText = "Loại Tác Phẩm";



            DataTable dataTable = pd.DocBang($"select * from {tableName}");


            foreach (DataRow row in dataTable.Rows)
            {
                string tenTacGia = row["TenTacGia"].ToString();
                int maTacPham = int.Parse(row["MaTacPham"].ToString());
                string tenTacPham = row["TenTacPham"].ToString();
                string loaiTacPham = row["LoaiTacPham"].ToString();

                _listTacPham.Add(new TacPham(tenTacGia, maTacPham, tenTacPham, loaiTacPham));
            }


            dgvTacPham.Columns[1].Width = 50;
            dgvTacPham.Columns[3].Width = 120;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTacGia, maTacPham, tenTacPham, loaiTacPham;
            if (Validate() == true && ValidateForExistence() == true)
            {
                tenTacGia = txtTenTacGia.Text;
                maTacPham = txtMaTacPham.Text;
                tenTacPham = txtTenTacPham.Text;
                loaiTacPham = txtLoaiTacPham.Text;

                pd.CapNhat($"insert into {tableName}(TenTacGia, MaTacPham, TenTacPham, LoaiTacPham) values(N'{tenTacGia}', N'{maTacPham}', N'{tenTacPham}', N'{loaiTacPham}')");
                TacPham tmp = new TacPham(tenTacGia, int.Parse(maTacPham), tenTacPham, loaiTacPham);
                //_listTacPham.Add(tmp);
                _listTacPham.Append(tmp);   

                Refresh(); 
            }
        }

        private bool Validate()
        {
            if (txtTenTacGia.Text.Trim() == "" ||
                txtMaTacPham.Text.Trim() == "" ||
                txtTenTacPham.Text.Trim() == "" ||
                txtLoaiTacPham.Text.Trim() == "")
            {
                MessageBox.Show("Nhap du lieu lai di");
                return false;
            }

            
            

            return true;
        }

        private bool ValidateForExistence()
        {
            int maTacPhamMoi = int.Parse(txtMaTacPham.Text.Trim());
            //MessageBox.Show($"{_listTacPham.Count}");

            for (int i = 0; i < _listTacPham.Count; i++)
            {
                //MessageBox.Show($"ma 1: {maTacPhamMoi}, ma 2: {_listTacPham[i].MaTacPham}");
                if (maTacPhamMoi == _listTacPham[i].MaTacPham)
                {

                    MessageBox.Show("Tác phẩm có mã này đã tồn tại");
                    return false;
                }
            }
            return true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenTacGia.Text = "";
            txtMaTacPham.Text = "";
            txtTenTacPham.Text = "";
            txtLoaiTacPham.Text = "";

            dgvTacPham.DataSource = pd.DocBang($"select * from {tableName}");

        }

        public void Refresh()
        {
            txtTenTacGia.Text = "";
            txtMaTacPham.Text = "";
            txtTenTacPham.Text = "";
            txtLoaiTacPham.Text = "";

            dgvTacPham.DataSource = pd.DocBang($"select * from {tableName}");
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thông tin của tác phẩm có mã: {txtMaTacPham.Text}?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            string sql = $"Delete from {tableName} where MaTacPham = '{txtMaTacPham.Text}'";
            pd.CapNhat(sql);

            for (int i = 0; i < _listTacPham.Count; i++)
            {
                if (_listTacPham[i].MaTacPham == int.Parse(txtMaTacPham.Text))
                {
                    _listTacPham.RemoveAt(i);
                }
            }

        }

        private void dgvTacPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTacGia.Text = dgvTacPham.SelectedRows[0].Cells["TenTacGia"].Value.ToString();
            txtTenTacPham.Text = dgvTacPham.SelectedRows[0].Cells["TenTacPham"].Value.ToString();
            txtMaTacPham.Text = dgvTacPham.SelectedRows[0].Cells["MaTacPham"].Value.ToString();
            txtLoaiTacPham.Text = dgvTacPham.SelectedRows[0].Cells["LoaiTacPham"].Value.ToString();
        }

        private void btnTimTenTacPham_Click(object sender, EventArgs e)
        {
            if (txtTenTacPham.Text.Trim().Length > 0)
            {
                string sql = $"select * from {tableName} where TenTacPham like N'%{txtTenTacPham.Text}%'";
                DataTable dt = pd.DocBang(sql);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Khong ton tai tac pham can tim");
                }
                else
                {
                    dgvTacPham.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Hay Nhap tac pham can tim");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Close the form.
                this.Close();
            }
        }

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            if (dgvTacPham.Rows.Count > 0)
            {
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Black;
                tenCuaHang.Value = "Danh sách tác phẩm";


                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Black;
                dtCuaHang.Value = "Điện thoại: xxxxxxx844";

                Excel.Range header = (Excel.Range)exSheet.Cells[5, 5];
                header.Font.Size = 15;
                header.Font.Bold = true;
                header.Font.Color = Color.Black;
                header.Value = "Báo cáo thống kê";

                Excel.Range ngaylap = (Excel.Range)exSheet.Cells[5, 1];
                ngaylap.Font.Size = 12;
                ngaylap.Value = "Ngày lập: " + DateTime.Now.ToShortDateString();



                for (int i = 0; i < dgvTacPham.ColumnCount; i++)
                {
                    exSheet.Cells[7, i + 1] = dgvTacPham.Columns[i].HeaderText;
                    exSheet.Cells[7, i + 1].Font.Bold = true;
                }

                for (int i = 0; i < dgvTacPham.RowCount; i++)
                {
                    for (int j = 0; j < dgvTacPham.ColumnCount; j++)
                    {
                        if (dgvTacPham.Rows[i].Cells[j].Value != null)
                        {
                            if (dgvTacPham.Rows[i].Cells[j].Value is DateTime)
                            {
                                exSheet.Cells[i + 8, j + 1] = ((DateTime)dgvTacPham.Rows[i].Cells[j].Value).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                exSheet.Cells[i + 8, j + 1] = dgvTacPham.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        else
                        {
                            exSheet.Cells[i + 8, j + 1] = "";
                        }
                    }
                }

                exSheet.Name = "Hang";
                exBook.Activate();

                saveFileDialog1.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".xlxs";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(saveFileDialog1.FileName.ToString());//Lưu file Excel
                exApp.Quit();
                MessageBox.Show("Đã xuất ra file excel thành công !");
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn cập nhật cho tác phẩm có mã: {txtMaTacPham.Text} ?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }


            if (Validate() == false)
            {
                return;
            }

            try
            {
                string sql = $"update {tableName} set MaTacPham = '{txtMaTacPham.Text}',TenTacPham = N'{txtTenTacPham.Text}',TenTacGia = N'{txtTenTacGia.Text}',LoaiTacPham = N'{txtLoaiTacPham.Text}' where MaTacPham = '{txtMaTacPham.Text}'";
                pd.CapNhat(sql);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin tác phẩm không thành công");
                return;
            }


            MessageBox.Show("Sửa thành công");
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.S)
            {
                // Perform desired action when shortcut key combination is pressed
            }
        }


    }
}
