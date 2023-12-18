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
    public class DoiTuongSuDungBUS
    {
        private DoiTuongSuDungDAO doiTuongSuDungDAO;
        public DoiTuongSuDungBUS()
        {
            doiTuongSuDungDAO = new DoiTuongSuDungDAO();
        }
        public List<DoiTuongSuDungDTO> GetListDoiTuongSuDung()
        {
            List<DoiTuongSuDungDTO> list = new List<DoiTuongSuDungDTO>();
            DataTable data = doiTuongSuDungDAO.GetListDoiTuongSuDung();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new DoiTuongSuDungDTO(item));
            }

            return list;
        }
        public bool InsertDoiTuongSuDung(string maDTSD, string tenDTSD)
        {
            return doiTuongSuDungDAO.InsertDoiTuongSuDung(maDTSD, tenDTSD);

        }
    }
}
