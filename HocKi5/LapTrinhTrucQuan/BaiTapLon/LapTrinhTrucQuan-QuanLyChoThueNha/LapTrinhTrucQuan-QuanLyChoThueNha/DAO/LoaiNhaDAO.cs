using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public LoaiNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListLoaiNha()
        {
            return Instance.ExecuteQuery($"SELECT * FROM LoaiNha");
        }
        public bool InsertLoaiNha(string maLoai, string tenLoai)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT LoaiNha (MaLoai,TenLoai)" + $"VALUES (N'{maLoai}', N'{tenLoai}')");

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
