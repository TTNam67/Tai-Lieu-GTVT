using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Xml.XPath;


namespace KiemTraGiuaKy
{
    public class ProcessDatabase
    {
        //static public string _connectionString = "Data Source=DESKTOP-OE5VPO5\\SQLEXPRESS;Initial Catalog=LapTrinhTrucQuanDatabase;Integrated Security=True";
        static public string _connectionString = "Data Source=DESKTOP-OE5VPO5\\SQLEXPRESS;Initial Catalog=KiemTraGiuaKy;User ID=sa;Password=nam123";
        SqlConnection con = new SqlConnection(_connectionString);

        public void KetNoi()
        {
            con = new SqlConnection(_connectionString);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void DongKetNoi()
        {
            if (con.State != ConnectionState.Closed)
            {
                // Disconnect from the data source
                con.Close();
            }
            con.Dispose();
        }

        public DataTable DocBang(string sql)
        {
            KetNoi(); //Connect to the database
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con); //The SqlDataAdapter object is used to execute the SQL query and fill the DataTable object with the results

            //SqlDataAdapter is designed to be used to populate a DataSet object with the results of a SQL query.

            //Using DataReader
            /*
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List <TacPham> list = new List<TacPham> ();
            while(sqlDataReader.Read())
            {
                TacPham tacPham = new TacPham();
                tacPham.MaTacPham = Convert.ToInt32(sqlDataReader["MaTacPham"]);
                tacPham.TenTacPham = sqlDataReader["TenTacPham"].ToString();
                
                list.Add(tacPham);
            } 
            */

            da.Fill(tb);
            da.Dispose();
            DongKetNoi();

            return tb;
            //return list //Using DataReader
        }

        public void CapNhat(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            KetNoi();

            cmd.Connection = con;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();
            DongKetNoi();
            cmd.Dispose();
        }
    }
}
