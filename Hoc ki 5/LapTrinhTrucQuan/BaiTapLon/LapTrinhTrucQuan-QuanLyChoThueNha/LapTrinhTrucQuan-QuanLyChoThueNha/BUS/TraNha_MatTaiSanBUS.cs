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
    public class TraNha_MatTaiSanBUS
    {
        private TraNha_MatTaiSanDAO traNha_MatTaiSanDAO;
        public TraNha_MatTaiSanBUS()
        {
            traNha_MatTaiSanDAO = new TraNha_MatTaiSanDAO();
        }
        public List<TraNha_MatTaiSanDTO> GetListTraNha_MatTaiSan()
        {
            List<TraNha_MatTaiSanDTO> list = new List<TraNha_MatTaiSanDTO>();
            DataTable data = traNha_MatTaiSanDAO.GetListTraNha_MatTaiSan();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new TraNha_MatTaiSanDTO(item));
            }

            return list;
        }
        public bool InsertTraNha_MatTaiSan(string maSoThue, string maTaiSan, int soLuong, decimal giaTri, decimal thanhTien)
        {
            return traNha_MatTaiSanDAO.InsertTraNha_MatTaiSan(maSoThue, maTaiSan, soLuong, giaTri, thanhTien);
        }
        public bool UpdateTraNha_MatTaiSan(string maSoThue, string maTaiSan, int soLuong, decimal giaTri, decimal thanhTien)
        {
            return traNha_MatTaiSanDAO.UpdateTraNha_MatTaiSan(maSoThue, maTaiSan, soLuong, giaTri, thanhTien);
        }
        public bool DeleteTraNha_MatTaiSan(string maSoThue, string maTaiSan)
        {
            return traNha_MatTaiSanDAO.DeleteTraNha_MatTaiSan(maSoThue, maTaiSan);
        }
    }
}
