using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThuTienNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public ThuTienNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListThuTienNha()
        {
            return Instance.ExecuteQuery($"SELECT * FROM ThuTienNha");
        }

        public bool InsertThuTienNha(string maSoThu, string maSoThue, string thang, string nam, decimal tongTien, string nguoiThu, DateTime ngayThu, string ghiChu)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT ThuTienNha (MaSoThu, MaSoThue, Thang, Nam, TongTien, NguoiThu, NgayThu, GhiChu)" + $"VALUES (N'{maSoThu}', N'{maSoThue}', N'{thang}', N'{nam}', {tongTien}, N'{nguoiThu}', N'{ngayThu}' ,N'{ghiChu}')");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateThuTienNha(string maSoThu, string maSoThue, string thang, string nam, decimal tongTien, string nguoiThu, DateTime ngayThu, string ghiChu)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE ThuTienNha SET MaSoThue= N'{maSoThue}', Thang =N'{thang}', Nam = N'{nam}', TongTien = {tongTien}, NgayThu = N'{ngayThu}', GhiChu = N'{ghiChu}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteThuTienNha(string maSoThu)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE ThuTienNha WHERE MaSoThu = N'{maSoThu}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
