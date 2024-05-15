using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DoiTuongSuDungDAO
    {
        DataProvider Instance = new DataProvider();

        public DoiTuongSuDungDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListDoiTuongSuDung()
        {
            return Instance.ExecuteQuery($"SELECT * FROM DoiTuongSudung");
        }

        public bool InsertDoiTuongSuDung(string maDTSD, string tenDTSD)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT DoiTuongSudung (MaDTSD,TenDTSD)" +  $"VALUES (N'{maDTSD}', N'{tenDTSD}')");

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
