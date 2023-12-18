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
    public class DanhMucNhaBUS
    {
        private DanhMucNhaDAO danhMucNhaDAO;
        public DanhMucNhaBUS()
        {
            danhMucNhaDAO = new DanhMucNhaDAO();
        }
        public DataTable GetListDanhMucNha()
        {
            DataTable data = danhMucNhaDAO.GetListDanhMucNha();
            return data;
        }

        public DataTable FindingDanhMucNha(string maLoai = "", string maDTSD = "", string diaChi = "")
        {
            /*
            List<DanhMucNhaDTO> list = new List<DanhMucNhaDTO>();
            DataTable data = danhMucNhaDAO.FindingDanhMucNha(dauVao);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new DanhMucNhaDTO(item));
            }
            return list;
            */
            DataTable data = danhMucNhaDAO.FindingDanhMucNha(maLoai, maDTSD, diaChi);
            return data;

        }

        public bool InsertDanhMucNha(string maNha, string tenChuNha, string dienThoai, string maLoai,
            string maDTSD, string diaChi, decimal? donGiaThue, string tinhTrang, int daThue, string ghiChu)
        {
            return danhMucNhaDAO.InsertDanhMucNha(maNha, tenChuNha, dienThoai, maLoai, maDTSD, diaChi, donGiaThue, tinhTrang, daThue, ghiChu);
        }
        public bool UpdateDanhMucNha(string maNha, string tenChuNha, string dienThoai, string maLoai,
            string maDTSD, string diaChi, decimal? donGiaThue, string tinhTrang, int daThue, string ghiChu)
        {
            return danhMucNhaDAO.UpdateDanhMucNha(maNha, tenChuNha, dienThoai, maLoai, maDTSD, diaChi, donGiaThue, tinhTrang, daThue, ghiChu);
        }
        public bool DeleteDanhMucNha(string maNha)
        {
            return danhMucNhaDAO.DeleteDanhMucNha(maNha);
        }
    }
}
