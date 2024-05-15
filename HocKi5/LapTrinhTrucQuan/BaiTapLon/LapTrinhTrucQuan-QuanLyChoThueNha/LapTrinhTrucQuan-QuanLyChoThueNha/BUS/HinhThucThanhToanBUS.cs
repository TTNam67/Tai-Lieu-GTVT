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
    public class HinhThucThanhToanBUS
    {
        private HinhThucThanhToanDAO hinhThucThanhToanDAO;
        public HinhThucThanhToanBUS()
        {
            hinhThucThanhToanDAO = new HinhThucThanhToanDAO();
        }
        public List<HinhThucThanhToanDTO> GetListHinhThucThanhToan()
        {
            List<HinhThucThanhToanDTO> list = new List<HinhThucThanhToanDTO>();
            DataTable data = hinhThucThanhToanDAO.GetListHinhThucThanhToan();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new HinhThucThanhToanDTO(item));
            }

            return list;
        }
    }
}
