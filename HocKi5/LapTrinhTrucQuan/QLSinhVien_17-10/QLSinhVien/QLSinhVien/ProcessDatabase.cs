using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    class ProcessDatabase
    {
        public string connectString { get; set; } = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Hoc ki 5\\LapTrinhTrucQuan\\QLSinhVien_17-10\\QLSinhVien\\QlSinhVien.mdf\";Integrated Security=True"; 
        public SqlConnection con { get; set; }
        public void KetNoi()
        {
            con = new SqlConnection();
            con.ConnectionString= connectString;

            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        public void DongKetNoi()
        {
            if(con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            con.Dispose();
        }
        public DataTable LoadDataGridView()
        {
            KetNoi();
            string sql;
            sql = "Select * from tblSinhVien";
            SqlDataAdapter data = new SqlDataAdapter(sql,con); 
            DataTable sinhvien = new DataTable();
            data.Fill(sinhvien);
            DongKetNoi();
            return sinhvien;

        }
        public void RunSql(string sql)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            DongKetNoi();
        }

    }
}
