using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NgheNghiepDAO
    {
        DataProvider Instance = new DataProvider();

        public NgheNghiepDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListNgheNghiep()
        {
            return Instance.ExecuteQuery($"SELECT * FROM NgheNghiep");
        }

        public bool InsertNgheNghiep(string maNghe, string tenNghe)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT NgheNghiep (MaNghe,TenNghe)" + $"VALUES (N'{maNghe}', N'{tenNghe}')");

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
