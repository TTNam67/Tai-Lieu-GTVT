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
    public class NgheNghiepBUS
    {
        private NgheNghiepDAO ngheNghiepDAO;
        public NgheNghiepBUS()
        {
            ngheNghiepDAO = new NgheNghiepDAO();
        }
        public List<NgheNghiepDTO> GetListNgheNghiep()
        {
            List<NgheNghiepDTO> list = new List<NgheNghiepDTO>();
            DataTable data = ngheNghiepDAO.GetListNgheNghiep();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new NgheNghiepDTO(item));
            }

            return list;
        }
        public bool InsertNgheNghiep(string maNghe, string tenNghe)
        {
            return ngheNghiepDAO.InsertNgheNghiep(maNghe, tenNghe);

        }
    }
}
