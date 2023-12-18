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
    public class CoQuanBUS
    {
        private CoQuanDAO coQuanDAO;
        public CoQuanBUS()
        {
            coQuanDAO = new CoQuanDAO();
        }
        public List<CoQuanDTO> GetListCoQuan()
        {
            List<CoQuanDTO> list = new List<CoQuanDTO>();
            DataTable data = coQuanDAO.GetListCoQuan();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new CoQuanDTO(item));
            }

            return list;
        }

        public bool InsertCoQuan(string maCQ, string tenCQ)
        {
            return coQuanDAO.InsertCoQuan(maCQ, tenCQ);
        }
        //public bool UpdateCoQuan(string MaCQ, string TenCQ)
        //{
        //    return coQuanDAO.UpdateCoQuan(MaCQ, TenCQ);
        //}
        //public bool DeleteCoQuan(string MaCQ)
        //{
        //    return coQuanDAO.DeleteCoQuan(MaCQ);
        //}
    }
}
