using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Nha_TaiSanDAO
    {
        DataProvider Instance = new DataProvider();

        public Nha_TaiSanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListNha_TaiSan()
        {
            return Instance.ExecuteQuery($"SELECT * FROM Nha_TaiSan");
        }

        public bool InsertNha_TaiSan(string maNha, string maTaiSan, int soLuong, decimal? giaTri, string tinhTrang)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT Nha_TaiSan (MaNha, MaTaiSan, SoLuong, GiaTri, TinhTrang)" + $"VALUES (N'{maNha}', N'{maTaiSan}', {soLuong}, {giaTri}, N'{tinhTrang}')");

            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateNha_TaiSan(string maNha, string maTaiSan, int soLuong, decimal? giaTri, string tinhTrang)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE Nha_TaiSan SET MaNha = N'{maNha}', MaTaiSan = N'{maTaiSan}', SoLuong = {soLuong}, GiaTri = {giaTri}, TinhTrang = N'{tinhTrang}' WHERE MaNha = N'{maNha}' AND MaTaiSan = N'{maTaiSan}'");

            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteNha_TaiSan(string maNha, string maTaiSan)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE Nha_TaiSan WHERE MaNha = N'{maNha}' AND MaTaiSan = N'{maTaiSan}'");

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
