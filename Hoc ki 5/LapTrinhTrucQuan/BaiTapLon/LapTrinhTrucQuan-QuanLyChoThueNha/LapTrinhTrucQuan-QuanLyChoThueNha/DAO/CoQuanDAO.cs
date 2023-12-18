using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CoQuanDAO
    {
        private DataProvider Instance;

        public CoQuanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListCoQuan()
        {
            return Instance.ExecuteQuery($"SELECT * FROM CoQuan"); // Dien cau lenh SQL vao day
        }

        public bool InsertCoQuan(string maCQ, string tenCQ)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT BANAN (maCQ, tenCQ) " +
                $"VALUES (N'{maCQ}', N'{maCQ}')"); // Gia tri de insert vao thi dien theo format nay
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
