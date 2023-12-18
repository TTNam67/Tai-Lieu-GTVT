using QLDiem;
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

namespace TimKiemHangHoa
{
    public partial class Form1 : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        DataTable dtHang = new DataTable();
        string sql;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void cboChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboChatLieu_Click(object sender, EventArgs e)
        {
            cboChatLieu.DataSource = dtBase.DocBang("Select * from tblChatLieu");
            cboChatLieu.ValueMember = "Machatlieu";
            cboChatLieu.DisplayMember = "Tenchatlieu";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            sql = "select MaHang,TenHang,TenChatLieu,SoLuong,DonGiaNhap,DonGiaBan," +
                  "tblHang.MaChatLieu from tblHang inner join tblChatLieu on " +
                  "tblHang.MaChatLieu=tblChatLieu.MaChatLieu where MaHang is not null";
            if (txtMaHang.Text != "")
                sql = sql + " and MaHang like N'%" + txtMaHang.Text.Trim() + "%'";
            if (txtTenHang.Text != "")
                sql = sql + " and TenHang like N'%" + txtTenHang.Text.Trim() + "%'";
            if (txtDonGiaBan1.Text != "")
                sql = sql + " and DonGiaBan >= " + txtDonGiaBan1.Text;
            if (txtDonGiaBan2.Text != "")
                sql = sql + " and DonGiaBan <= " + txtDonGiaBan2.Text;
            if (cboChatLieu.Text != "")
                sql = sql + " and tblHang.MaChatLieu='" +
               cboChatLieu.SelectedValue.ToString() + "'";
            dtHang = dtBase.DocBang(sql);
            dgvHang.DataSource = null;
            dgvHang.DataSource = dtHang;
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Chất liệu";
            dgvHang.Columns[3].HeaderText = "Giá nhập";
            dgvHang.Columns[4].HeaderText = "Giá bán";
            dgvHang.Columns[5].HeaderText = "Số lượng";
            dgvHang.Columns[0].DataPropertyName = "MaHang";
            dgvHang.Columns[1].DataPropertyName = "TenHang";
            dgvHang.Columns[2].DataPropertyName = "TenChatLieu";
            dgvHang.Columns[3].DataPropertyName = "DonGiaNhap";
            dgvHang.Columns[4].DataPropertyName = "DonGiaBan";
            dgvHang.Columns[5].DataPropertyName = "SoLuong";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dtHang.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook =
               exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "CỬA HÀNG BÁN ĐỒ LƯU NIỆM BÌNH AN";
                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 12;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: 37B - TT Đông Anh - Hà Nội";
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 0976967619";
                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:G5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH CÁC MẶT HÀNG";
                //Định dạng tiêu đề bảng

                exSheet.get_Range("A7:G7").Font.Bold = true;
                exSheet.get_Range("A7:G7").HorizontalAlignment =
               Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã hàng";
                exSheet.get_Range("C7").Value = "Tên hàng";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Chất liệu";
                exSheet.get_Range("E7").Value = "Số lượng";
                exSheet.get_Range("F7").Value = "Giá nhập";
                exSheet.get_Range("G7").Value = "Giá bán";
                //In dữ liệu
                for (int i = 0; i < dtHang.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i +
                   8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i +
                   1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value =
                   dtHang.Rows[i]["MaHang"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value =
                   dtHang.Rows[i]["TenHang"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value =
                   dtHang.Rows[i]["TenChatLieu"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value =
                   dtHang.Rows[i]["SoLuong"].ToString();
                    exSheet.get_Range("F" + (i + 8).ToString()).Value =
                   dtHang.Rows[i]["DonGiaNhap"].ToString();
                    exSheet.get_Range("G" + (i + 8).ToString()).Value =
                   dtHang.Rows[i]["DonGiaBan"].ToString();
                }
                exSheet.Name = "Hang";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xls";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvHang.DataSource = dtBase.DocBang("select * from tblChatLieu join tblHang on tblChatLieu.Machatlieu = tblHang.MaChatLieu");
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
