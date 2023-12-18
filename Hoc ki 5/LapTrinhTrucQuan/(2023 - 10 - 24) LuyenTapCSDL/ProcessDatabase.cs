using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023___10___24__LuyenTapCSDL
{
    internal class ProcessDatabase
    {
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OE5VPO5\\SQLEXPRESS;Initial Catalog=TestQuanLyDiem;Integrated Security=True;Pooling=False");

        public void KetNoi()
        {
            con = new SqlConnection("Data Source=DESKTOP-OE5VPO5\\SQLEXPRESS;Initial Catalog=TestQuanLyDiem;Integrated Security=True;Pooling=False");
            
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
            da.Fill(tb);
            da.Dispose();
            DongKetNoi();

            return tb;
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
