using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TraNha_MatTaiSanDAO
    {
        DataProvider Instance = new DataProvider();

        public TraNha_MatTaiSanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListTraNha_MatTaiSan()
        {
            return Instance.ExecuteQuery($"SELECT * FROM TraNha_MatTaiSan");
        }

        public bool InsertTraNha_MatTaiSan(string maSoThue, string maTaiSan, int soLuong, decimal giaTri, decimal thanhTien)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT TraNha_MatTaiSan (MaSoThue, MaTaiSan, SoLuong, GiaTri)" + $"VALUES (N'{maSoThue}', N'{maTaiSan}', {soLuong}, {giaTri})");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateTraNha_MatTaiSan(string maSoThue, string maTaiSan, int soLuong, decimal giaTri, decimal thanhTien)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE TraNha_MatTaiSan SET SoLuong = {soLuong}, GiaTri = {giaTri} where MaSoThue = N'{maSoThue}' and MaTaiSan = N'{maTaiSan}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteTraNha_MatTaiSan(string maSoThue, string maTaiSan)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE TraNha_MatTaiSan WHERE MaSoThue = N'{maSoThue}' and MaTaiSan = N'{maTaiSan}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
