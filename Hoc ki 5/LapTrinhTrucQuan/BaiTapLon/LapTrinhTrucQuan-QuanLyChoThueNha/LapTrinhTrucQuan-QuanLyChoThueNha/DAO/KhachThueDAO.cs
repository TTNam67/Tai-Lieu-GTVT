using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class KhachThueDAO
    {
        private DataProvider Instance;

        public KhachThueDAO()
        {
            Instance = new DataProvider();
        }

        // Lấy thông tin khách thuê theo tên 
        public DataTable GetListKhachThue()
        {
            return Instance.ExecuteQuery($"SELECT * FROM KhachThue");
        }

        public DataTable FindingKhachThue(string tenKhach = "", string diaChiThuongTru = "", string maNghe = "")
        {
            /*
            string query = $"SELECT * FROM KhachThue where";
            if (tenKhach != "")
            {
                
            }
            */
            return Instance.ExecuteQuery($"SELECT * FROM KhachThue where TenKhach LIKE N'%{tenKhach}%' AND DiaChiThuongTru LIKE N'%{diaChiThuongTru}%' AND MaNghe LIKE N'%{maNghe}%'");
        }

        // Lấy thông tin khách thuê theo địa chỉ thường trú
        //public DataTable GetListKhachThueByDiaChi(string diaChiThuongTru = "")
        //{
        //    return Instance.ExecuteQuery($"SELECT * FROM KhachThue WHERE TenKhach = N'{diaChiThuongTru}'");
        //}

        // Lấy thông tin khách thuê theo nghề
        //public DataTable GetListKhachThueByNghe(string maNghe = "")
        //{
        //    return Instance.ExecuteQuery($"SELECT * FROM KhachThue WHERE TenKhach = N'{maNghe}'");
        //}

        // Nhập thông tin khách thuê
        public bool InsertKhachThue(string maKhach, string tenKhach, DateTime ngaySinh, int gioiTinh,
            string soCMND, string diaChiThuongTru, string maNghe, string maCQ)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT KhachThue (MaKhach, TenKhach, NgaySinh, GioiTinh, SoCMND, DiaChiThuongTru, MaNghe, MaCQ)" + $"VALUES (N'{maKhach}', N'{tenKhach}', N'{ngaySinh}', {gioiTinh}, N'{soCMND}', N'{diaChiThuongTru}', N'{maNghe}', N'{maCQ}')");
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Update thông tin khách hàng
        public bool UpdateKhachThue(string maKhach, string tenKhach, DateTime ngaySinh, int gioiTinh,
            string soCMND, string diaChiThuongTru, string maNghe, string maCQ)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE KhachThue SET MaKhach = N'{maKhach}', TenKhach = '{tenKhach}', N'{ngaySinh}', GioiTinh = {gioiTinh}, SoCMND = N'{soCMND}', DiaChiThuongTru = N'{diaChiThuongTru}', MaNghe = N'{maNghe}', MaCQ = N'{maCQ}' WHERE MaKhach = N'{maKhach}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        // Xóa khách thuê
        public bool DeleteKhachThue(string maKhach)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE KhachThue WHERE MaKhach = N'{maKhach}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
