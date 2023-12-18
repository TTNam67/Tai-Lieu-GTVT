using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MucDichSuDungDAO
    {
        DataProvider Instance = new DataProvider();

        public MucDichSuDungDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListMucDichSuDung()
        {
            return Instance.ExecuteQuery($"SELECT * FROM MucDichSuDung");
        }
    }
}
