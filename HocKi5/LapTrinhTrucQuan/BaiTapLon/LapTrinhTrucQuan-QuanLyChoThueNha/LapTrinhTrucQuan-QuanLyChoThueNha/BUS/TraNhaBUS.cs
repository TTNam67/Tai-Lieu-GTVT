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
    public class TraNhaBUS
    {
        private TraNhaDAO traNhaDAO;
        public TraNhaBUS()
        {
            traNhaDAO = new TraNhaDAO();
        }
        public DataTable GetListTraNha()
        {
            
            DataTable data = traNhaDAO.GetListTraNha();
            return data;
        }

        public DataTable GetListTraNha_ChuaTra()
        {
            DataTable data = traNhaDAO.GetListTraNha_ChuaTra();
            return data;
        }

        public DataTable FindingTraNha(string maSoThue)
        {
            DataTable data = traNhaDAO.FindingTraNha(maSoThue);
            return data;
        }

        public bool InsertTraNha(string maSoThue, DateTime ngayTra, decimal tongTien)
        {
            return traNhaDAO.InsertTraNha(maSoThue, ngayTra, tongTien);
        }
        public bool UpdateTraNha(string maSoThue, DateTime ngayTra)
        {
            return traNhaDAO.UpdateTraNha(maSoThue, ngayTra);
        }
        public bool DeleteTraNha(string maSoThue)
        {
            return traNhaDAO.DeleteTraNha(maSoThue);
        }
    }
}