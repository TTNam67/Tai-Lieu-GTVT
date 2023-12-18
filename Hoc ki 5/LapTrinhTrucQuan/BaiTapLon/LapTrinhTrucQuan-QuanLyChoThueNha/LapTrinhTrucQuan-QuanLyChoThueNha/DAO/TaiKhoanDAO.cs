using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class TaiKhoanDAO
    {
        DataProvider Instance = new DataProvider();

        public TaiKhoanDAO()
        {
            Instance = new DataProvider();
        }

        public DataTable CheckLogin(string userName, string passWord)
        {
            return Instance.ExecuteQuery($"SELECT * FROM TaiKhoan WHERE Username = N'{userName}' AND _Password = N'{passWord}'");
        }

        public DataTable GetAccountByUserName(string userName)
        {
            DataTable data = Instance.ExecuteQuery($"SELECT * FROM TaiKhoan WHERE Username = N'{userName}'");
            if (data.Rows.Count <= 0)
            {
                return null;
            }
            return data;
        }

        public bool InsertTK(string userName, string passWord, string displayName, int phanQuyen)
        {
            try
            {
                Instance.ExecuteNonQuery($"INSERT TaiKhoan (Username, _Password, DisplayName, PhanQuyen) " +
                    $"VALUES (N'{userName}', N'{passWord}', N'{displayName}', {phanQuyen})");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateTK(string userName, string passWord, string displayName, int phanQuyen)
        {
            try
            {
                Instance.ExecuteNonQuery($"UPDATE TaiKhoan SET _Password = N'{passWord}', DisplayName = N'{displayName}', PhanQuyen = {phanQuyen} WHERE Username = N'{userName}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteTK(string userName)
        {
            try
            {
                Instance.ExecuteNonQuery($"DELETE TaiKhoan WHERE Username = N'{userName}'");
            }
            catch
            {
                return false;
            }
            return true;
        }

        public string GetTenHienThiTK(string userName)
        {
            return Instance.ExecuteScalar($"Select DisplayName from TaiKhoan where Username = N'{userName}'").ToString();
        }
    }
}