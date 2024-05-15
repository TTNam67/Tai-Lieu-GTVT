using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HinhThucThanhToanDAO
    {
        DataProvider Instance = new DataProvider();

        public HinhThucThanhToanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListHinhThucThanhToan()
        {
            return Instance.ExecuteQuery($"SELECT * FROM HinhThucThanhToan");
        }
    }
}
