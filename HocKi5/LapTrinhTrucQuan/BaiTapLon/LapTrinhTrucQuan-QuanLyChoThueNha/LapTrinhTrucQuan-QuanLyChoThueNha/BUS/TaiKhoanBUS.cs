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
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO taiKhoanDAO;
        public TaiKhoanBUS()
        {
            taiKhoanDAO = new TaiKhoanDAO();
        }
        public bool CheckLogin(string userName, string passWord)
        {
            return taiKhoanDAO.CheckLogin(userName, passWord).Rows.Count > 0;
        }
        public TaiKhoanDTO GetAccountByUserName(string userName)
        {
            DataTable result = taiKhoanDAO.GetAccountByUserName(userName);
            if (result.Rows.Count <= 0)
            {
                return null;
            }
            return new TaiKhoanDTO(result.Rows[0]);
        }
        /*
        public List<TaiKhoanDTO> GetListTK()
        {
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            DataTable data = taiKhoanDAO.GetListTK();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new TaiKhoanDTO(item));
            }

            return list;
        }
        */
        public bool InsertTK(string userName, string passWord, string displayName, int phanQuyen)
        {
            return taiKhoanDAO.InsertTK(userName, passWord, displayName, phanQuyen);
        }
        public bool UpdateTK(string userName, string passWord, string displayName, int phanQuyen)
        {
            return taiKhoanDAO.UpdateTK(userName, passWord, displayName, phanQuyen);
        }
        public bool DeleteTK(string userName)
        {
            return taiKhoanDAO.DeleteTK(userName);
        }

        public string GetTenHienThiTK(string username)
        {
            return taiKhoanDAO.GetTenHienThiTK(username);
        }
    }
}
