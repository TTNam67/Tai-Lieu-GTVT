using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023___10___24__LuyenTapCSDL
{
    public partial class Form1 : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        public string _tableName = "tblDiem";
        public TextBox[] _textBoxes;
        public Form1()
        {
            InitializeComponent();

            _textBoxes = this.Controls.OfType<TextBox>().ToArray();
        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            dgvDanhSachMon.Columns[0].HeaderText = "Mã môn";
            dgvDanhSachMon.Columns[1].HeaderText = "Tên môn";
            dgvDanhSachMon.Columns[2].HeaderText = "Số tín chỉ";
            dgvDanhSachMon.Columns[3].HeaderText = "Điểm thi";

            dgvDanhSachMon.Columns[1].Width = 200;
            */

            dgvDanhSachMon.DataSource = pd.DocBang($"select * from {_tableName}");
        }

        private void btnThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            //Them vao bang diem (DataGridView)
            if (KiemTraDuLieu() == true)
            {
                string sql = $"insert into {_tableName}(MaMon, TenMon, SoTin, DiemThi) values({int.Parse(txtMaMon.Text)}, N'{txtTenMon.Text}', {int.Parse(txtSoTin.Text)}, {float.Parse(txtDiemThi.Text)})";
                pd.CapNhat(sql);

                dgvDanhSachMon.DataSource = pd.DocBang($"Select * from {_tableName}");
            }
        }

        bool KiemTraDuLieu()
        {
            bool k = true;
            if (txtMaMon.Text.Trim().Equals("")
                || txtTenMon.Text.Trim().Equals("")
                || txtSoTin.Text.Trim().Equals("")
                || txtDiemThi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Cmm, nhập đủ dữ liệu đi");
                k = false;
            }
            else
            {
                if (pd.DocBang($"select * from {_tableName} where MaMon = {txtMaMon.Text.Trim()}").Rows.Count > 0)
                {
                    MessageBox.Show("Cmm, Mã môn này có rồi");
                    k = false;
                }
            }

            return k;
        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("May chac chua??", "Thong bao", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                pd.CapNhat($"delete {_tableName} where MaMon = {int.Parse(txtMaMon.Text)}");
                dgvDanhSachMon.DataSource = pd.DocBang($"Select * from {_tableName}");
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            float tongDiem = 0;
            int tongTinChi = 0;

            for (int i = 0; i < dgvDanhSachMon.Rows.Count; i++)
            {
                int tinChi = int.Parse(dgvDanhSachMon.Rows[i].Cells[2].Value.ToString());
                float diemThi = float.Parse(dgvDanhSachMon.Rows[i].Cells[3].Value.ToString());
                tongTinChi += tinChi;
                tongDiem += diemThi * tinChi;

            }

            MessageBox.Show($"Diem trung binh {(tongDiem / tongTinChi).ToString()}");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < _textBoxes.Count(); i++)
            {
                _textBoxes[i].Clear();
            }

             foreach (TextBox txtBox in _textBoxes)
            {
                txtBox.Clear();
            }

        }

        private void dgvDanhSachMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachMon_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dgvDanhSachMon.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dgvDanhSachMon.CurrentRow.Cells[0].Value.ToString();
            txtSoTin.Text = dgvDanhSachMon.CurrentRow.Cells[0].Value.ToString();
            txtDiemThi.Text = dgvDanhSachMon.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
