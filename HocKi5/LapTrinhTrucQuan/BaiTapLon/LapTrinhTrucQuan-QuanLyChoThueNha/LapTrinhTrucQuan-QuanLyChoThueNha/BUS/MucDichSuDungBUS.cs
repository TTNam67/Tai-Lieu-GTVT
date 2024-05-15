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
    public class MucDichSuDungBUS
    {
        private MucDichSuDungDAO mucDichSuDungDAO;
        public MucDichSuDungBUS()
        {
            mucDichSuDungDAO = new MucDichSuDungDAO();
        }
        public List<MucDichSuDungDTO> GetListMucDichSuDung()
        {
            List<MucDichSuDungDTO> list = new List<MucDichSuDungDTO>();
            DataTable data = mucDichSuDungDAO.GetListMucDichSuDung();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new MucDichSuDungDTO(item));
            }

            return list;
        }
    }
}
