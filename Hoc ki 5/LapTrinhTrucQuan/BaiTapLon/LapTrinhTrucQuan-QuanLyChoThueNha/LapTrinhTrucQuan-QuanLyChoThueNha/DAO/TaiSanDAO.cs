using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiSanDAO
    {
        DataProvider Instance = new DataProvider();

        public TaiSanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListTaiSan()
        {
            return Instance.ExecuteQuery($"SELECT * FROM TaiSan");
        }
    }
}
