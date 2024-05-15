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
    public class LoaiNhaBUS
    {
        private LoaiNhaDAO loaiNhaDAO;
        public LoaiNhaBUS()
        {
            loaiNhaDAO = new LoaiNhaDAO();
        }
        public List<LoaiNhaDTO> GetListLoaiNha()
        {
            List<LoaiNhaDTO> list = new List<LoaiNhaDTO>();
            DataTable data = loaiNhaDAO.GetListLoaiNha();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new LoaiNhaDTO(item));
            }

            return list;
        }
        public bool InsertLoaiNha(string maLoai, string tenLoai)
        {
            return loaiNhaDAO.InsertLoaiNha(maLoai, tenLoai);

        }
    }
}
