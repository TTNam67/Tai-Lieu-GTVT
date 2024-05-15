using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDiem
{
    internal class ProcessDatabase
    {
        string stringcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\document\\Ki 5\\LapTrinhTrucQuan\\TimKiemHangHoa\\TimKiemHangHoa\\HangHoa.mdf\";Integrated Security=True";
        SqlConnection con;
        public void Ketnoi()
        {
            con = new SqlConnection(stringcon);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        public void DongKetNoi()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            con.Dispose();
        }
        public DataTable DocBang(string sql)
        {
            DataTable tb = new DataTable();
            Ketnoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(tb);
            DongKetNoi();
            return tb;
        }
        public void CapNhat(string sql)
        {
            SqlCommand cmm = new SqlCommand();
            Ketnoi();
            cmm.CommandText = sql;
            cmm.Connection = con;
            cmm.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
