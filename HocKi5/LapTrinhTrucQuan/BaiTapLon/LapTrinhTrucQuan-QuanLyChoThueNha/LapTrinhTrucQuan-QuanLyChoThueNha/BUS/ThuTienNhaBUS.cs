using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ThuTienNhaBUS
    {
        private ThuTienNhaDAO thuTienNhaDAO;
        public ThuTienNhaBUS()
        {
            thuTienNhaDAO = new ThuTienNhaDAO();
        }
        public List<ThuTienNhaDTO> GetListThuTienNha()
        {
            List<ThuTienNhaDTO> list = new List<ThuTienNhaDTO>();
            DataTable data = thuTienNhaDAO.GetListThuTienNha();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new ThuTienNhaDTO(item));
            }

            return list;
        }
        public bool InsertThuTienNha(string maSoThu, string maSoThue, string thang, string nam, decimal tongTien, string nguoiThu, DateTime ngayThu, string ghiChu)
        {
            return thuTienNhaDAO.InsertThuTienNha(maSoThu, maSoThue, thang, nam, tongTien, nguoiThu, ngayThu, ghiChu);
        }
        public bool UpdateThuTienNha(string maSoThu, string maSoThue, string thang, string nam, decimal tongTien, string nguoiThu, DateTime ngayThu, string ghiChu)
        {
            return thuTienNhaDAO.UpdateThuTienNha(maSoThu, maSoThue, thang, nam, tongTien, nguoiThu, ngayThu, ghiChu);
        }
        public bool DeleteThuTienNha(string maSoThu)
        {
            return thuTienNhaDAO.DeleteThuTienNha(maSoThu);
        }
    }
}
