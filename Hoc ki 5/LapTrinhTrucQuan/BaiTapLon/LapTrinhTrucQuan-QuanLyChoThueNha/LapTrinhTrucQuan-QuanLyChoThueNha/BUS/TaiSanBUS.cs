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
    public class TaiSanBUS
    {
        private TaiSanDAO taiSanDAO;
        public TaiSanBUS()
        {
            taiSanDAO = new TaiSanDAO();
        }
        public List<TaiSanDTO> GetListTaiSan()
        {
            List<TaiSanDTO> list = new List<TaiSanDTO>();
            DataTable data = taiSanDAO.GetListTaiSan();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new TaiSanDTO(item));
            }

            return list;
        }
    }
}
