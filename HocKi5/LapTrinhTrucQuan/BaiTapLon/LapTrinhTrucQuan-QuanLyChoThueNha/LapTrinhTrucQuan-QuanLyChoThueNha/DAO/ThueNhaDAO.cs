using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThueNhaDAO
    {
        DataProvider Instance = new DataProvider();

        public ThueNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable GetListThueNha()
        {
            return Instance.ExecuteQuery($"Select * from ThueNha");
        }

        public DataTable GetListThueNha_ChuaTra()
        {
            return Instance.ExecuteQuery($"select * from ThueNha where NgayKT > getdate()");
        }

        public bool InsertThueNha(string maSoThue, string maKhach, string maNha, string maMucdichSD, DateTime ngayBD, DateTime ngayKT, decimal tienDatCoc, string maHinhthucTT)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT ThueNha (MaSoThue, MaKhach, MaNha, MaMucDichSD, NgayBD, NgayKT, TienDatCoc, MaHinhThucTT)" + $"VALUES (N'{maSoThue}', N'{maKhach}', N'{maNha}', N'{maMucdichSD}', N'{ngayBD}', N'{ngayKT}', {tienDatCoc}, N'{maHinhthucTT}')");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateThueNha(string maSoThue, string maKhach, string maNha, string maMucdichSD, DateTime ngayBD, DateTime ngayKT, decimal tienDatCoc, string maHinhthucTT)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE ThueNha SET MaKhach = N'{maKhach}', MaNha= N'{maNha}', MaMucDichSD=N'{maMucdichSD}', NgayBD = N'{ngayBD}', NgayKT = N'{ngayKT}', TienDatCoc = '{tienDatCoc}', MaHinhThucTT = N'{maHinhthucTT}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteThueNha(string maSoThue)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE ThueNha WHERE MaSoThue = N'{maSoThue}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public DataTable TinhTongTien()
        {
            return Instance.ExecuteQuery($"Select ThueNha.MaNha, sum(ThuTienNha.TongTien) as tiennhan from ThueNha join ThuTienNha on ThuTienNha.MaSoThue = ThueNha.MaSoThue group by ThueNha.MaNha");
        }

        public DataTable TienThueChuaThanhToan()
        {
            return Instance.ExecuteQuery("select * from ThueNha where MaNha in (select MaNha from DanhMucNha where DaThue = 1) and MaSoThue not in (select MaSoThue from ThuTienNha where (Thang like '%'+convert(varchar(5),MONTH(getDate()))+ '%' or Thang = '12 tháng') and Nam like '%'+convert(varchar(5),Year(getDate()))+ '%')");
        }
    }
}
