using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAO
{
    public class DanhMucNhaDAO
    {
        DataProvider Instance = new DataProvider();
        

        public DanhMucNhaDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable FindingDanhMucNha(string maLoai = "", string maDTSD = "", string diaChi = "")
        {
            return Instance.ExecuteQuery($"SELECT * FROM DanhMucNha WHERE MaLoai like N'%{maLoai}%' and MaDTSD like N'%{maDTSD}%' and DiaChi like N'%{diaChi}%'"); // Day la cau truy van khi co dau vao

            
        }

        public DataTable GetListDanhMucNha()
        {
            return Instance.ExecuteQuery($"Select * from DanhMucNha");
        }

        //public DataTable GetListDanhMucNhaByDTSD(string maDTSD = "")
        //{
        //    return Instance.ExecuteQuery($"SELECT * FROM DanhMucNha WHERE maDTSD = N'{maDTSD}'"); // Day la cau truy van khi co dau vao
        //}

        //public DataTable GetListDanhMucNhaByDiaChi(string diaChi = "")
        //{
        //    return Instance.ExecuteQuery($"SELECT * FROM DanhMucNha WHERE diaChi = N'{diaChi}'"); // Day la cau truy van khi co dau vao
        //}

        public bool InsertDanhMucNha(string maNha, string tenChuNha, string dienThoai, string maLoai, string maDTSD, string diaChi, decimal? donGiaThue, string tinhTrang, int daThue, string ghiChu)
        {
            try
            {
                // Day la cau truy van khi co dau vao
                Instance.ExecuteNonQuery($"Insert DanhMucNha(maNha, tenChuNha, dienThoai, maLoai, maDTSD, diaChi, donGiaThue, tinhTrang, daThue, ghiChu) " +
                $"values (N'{maNha}', N'{tenChuNha}', N'{dienThoai}', N'{maLoai}', N'{maDTSD}', N'{diaChi}', {donGiaThue}, N'{tinhTrang}', {daThue}, N'{ghiChu}')"); 
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An exception of type {ex.ToString()} occurred");
                return false;
            }
            return true;
        }

        public bool UpdateDanhMucNha(string maNha, string tenChuNha, string dienThoai, string maLoai,
            string maDTSD, string diaChi, decimal? donGiaThue, string tinhTrang, int daThue, string ghiChu)
        {
            try
            {
                // Day la cau truy van khi co dau vao
                Instance.ExecuteNonQuery($"UPDATE DanhMucNha SET maNha = N'{maNha}', tenChuNha = N'{tenChuNha}', dienThoai = N'{dienThoai}', maLoai = N'{maLoai}', maDTSD = N'{maDTSD}', diaChi = N'{diaChi}', donGiaThue = {donGiaThue}, tinhTrang = N'{tinhTrang}', daThue = {daThue}, ghiChu = N'{ghiChu}' WHERE maNha = N'{maNha}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteDanhMucNha(string maNha)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE DanhMucNha WHERE maNha = N'{maNha}'");
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
