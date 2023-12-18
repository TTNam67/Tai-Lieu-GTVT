using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string _userName;
        private string _displayName;
        private string _passWord;
        private int _phanQuyen;

        public string UserName { get => _userName; set => _userName = value; }
        public string DisplayName { get => _displayName; set => _displayName = value; }
        public string PassWord { get => _passWord; set => _passWord = value; }
        public int PhanQuyen { get => _phanQuyen; set => _phanQuyen = value; }

        public TaiKhoanDTO(string userName, string passWord, string displayName, int phanQuyen)
        {
            UserName = userName;
            PassWord = passWord;
            DisplayName = displayName;
            PhanQuyen = phanQuyen;
        }

        public TaiKhoanDTO(DataRow row)
        {
            UserName = row["UserName"].ToString();
            PassWord = row["_PassWord"].ToString();
            DisplayName = row["DisplayName"].ToString();
            PhanQuyen = (int)row["PhanQuyen"];
        }
    }
}
