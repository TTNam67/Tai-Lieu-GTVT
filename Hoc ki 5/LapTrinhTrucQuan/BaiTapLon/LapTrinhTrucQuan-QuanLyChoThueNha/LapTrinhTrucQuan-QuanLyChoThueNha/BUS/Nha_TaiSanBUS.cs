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
    public class Nha_TaiSanBUS
    {
        private Nha_TaiSanDAO nha_TaiSanDAO;
        public Nha_TaiSanBUS()
        {
            nha_TaiSanDAO = new Nha_TaiSanDAO();
        }
        public List<Nha_TaiSanDTO> GetListNha_TaiSan()
        {
            List<Nha_TaiSanDTO> list = new List<Nha_TaiSanDTO>();
            DataTable data = nha_TaiSanDAO.GetListNha_TaiSan();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Nha_TaiSanDTO(item));
            }
            return list;
        }
        public bool InsertNha_TaiSan(string maNha, string maTaisan, int soLuong, decimal? giaTri, string tinhTrang)
        {
            return nha_TaiSanDAO.InsertNha_TaiSan(maNha, maTaisan, soLuong, giaTri, tinhTrang);
        }
        public bool UpdateNha_TaiSan(string maNha, string maTaisan, int soLuong, decimal? giaTri, string tinhTrang)
        {
            return nha_TaiSanDAO.UpdateNha_TaiSan(maNha, maTaisan, soLuong, giaTri, tinhTrang);
        }
        public bool DeleteNha_TaiSan(string maNha, string maTaiSan)
        {
            return nha_TaiSanDAO.DeleteNha_TaiSan(maNha, maTaiSan);
        }
    }
}
