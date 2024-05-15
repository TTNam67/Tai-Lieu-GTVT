using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TraNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public TraNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListTraNha()
        {
            return Instance.ExecuteQuery($"SELECT * FROM TraNha");
        }

        public DataTable GetListTraNha_ChuaTra()
        {
            return Instance.ExecuteQuery($"Select MaSoThue, NgayTra from TraNha where NgayTra > getdate()");
        }

        public DataTable FindingTraNha(string maSoThue)
        {
            return Instance.ExecuteQuery($"Select MaSoThue, NgayTra from TraNha where NgayTra > getdate() and MaSoThue = {maSoThue}");
        }

        public bool InsertTraNha(string maSoThue, DateTime ngayTra, decimal tongTien)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT TraNha (MaSoThue, NgayTra, TongTien)" + $"VALUES (N'{maSoThue}', N'{ngayTra}', {tongTien})");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateTraNha(string maSoThue, DateTime ngayTra)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE TraNha SET NgayTra = N'{ngayTra}' WHERE MaSoThue = N'{maSoThue}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteTraNha(string maSoThue)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE TraNha WHERE MaSoThue = N'{maSoThue}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}