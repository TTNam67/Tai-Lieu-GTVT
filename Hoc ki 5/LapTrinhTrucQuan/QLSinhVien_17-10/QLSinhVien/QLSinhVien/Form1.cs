using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.LoadDataGridView();
            this.reportViewer1.RefreshReport();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ngaysinh = ReverseDateTime(txtNgaySinh.Text);
            string sql;
            sql = "Update tblSinhVien set HoTen ='"+txtHoTen.Text+"',NgaySinh='" + ngaysinh + "',Khoa = '"+txtKhoa.Text +"',Lop = '" + txtLop.Text+"',DiaChi = '"+txtDiaChi.Text +"' where MaSV = '" + txtMaSV.Text +"'";
            pd.RunSql(sql);
            dataGridView1.DataSource = pd.LoadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if(MessageBox.Show("Bạn Có Muốn xóa không","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblSinhVien where MaSV = '" + txtMaSV.Text + "'";
                pd.RunSql(sql);
                Form1_Load(sender, e);
                ResetValue();

            }
        }

        private void ResetValue()
        {
            txtMaSV.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtKhoa.Text = "";
            txtLop.Text = "";
            txtNgaySinh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            pd.KetNoi();
            string sql;
            sql = "select MaSV from tblSinhVien where MaSV = N'" + txtMaSV.Text + "'";
            SqlDataAdapter data = new SqlDataAdapter(sql,pd.con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            pd.DongKetNoi();
            data.Dispose();
            if(dt.Rows.Count > 0 )
            {
                MessageBox.Show("Ma Sinh Vien Da Ton Tai");
                return;
            }
            sql = "insert into tblSinhVien values ('" + txtMaSV.Text+"','"+txtHoTen.Text+"','" + ReverseDateTime(txtNgaySinh.Text)+"','" + txtKhoa.Text + "','" + txtLop.Text+"','" + txtDiaChi.Text +"')";
            pd.RunSql(sql);
            Form1_Load(sender, e);
            ResetValue();
        }
        private string ReverseDateTime(string date)
        {
            date  = txtNgaySinh.Text.Replace("/", "-");
            string[] help = date.Split('-');
            string hehe = "";
            for (int i = help.Length - 1; i >= 0; i--)
            {
                if (help[i] == help[help.Length - 1])
                {
                    hehe += help[i];
                }
                else
                {

                    hehe += "-" + help[i];
                }

            }
            return hehe;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat khong","thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
