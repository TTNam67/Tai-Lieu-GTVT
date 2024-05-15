using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuTienNhaDTO
    {
        private string _maSoThu;
        private string _maSoThue;
        private string _thang;
        private string _nam;
        private decimal _tongTien;
        private string _nguoiThu;
        private DateTime _ngayThu;
        private string _ghiChu;

        public ThuTienNhaDTO(string maSoThu, string maSoThue, string thang, string nam, decimal tongTien, string nguoiThu, DateTime ngayThu, string ghiChu)
        {
            this._maSoThu = maSoThu;
            this._maSoThue = maSoThue;
            this._thang = thang;
            this._nam = nam;
            this._tongTien = tongTien;
            this._nguoiThu = nguoiThu;
            this._ngayThu = ngayThu;
            this._ghiChu = ghiChu;
        }

        public string MaSoThu { get => _maSoThu; set => _maSoThu = value; }
        public string MaSoThue { get => _maSoThue; set => _maSoThue = value; }
        public string Thang { get => _thang; set => _thang = value; }
        public string Nam { get => _nam; set => _nam = value; }
        public decimal TongTien { get => _tongTien; set => _tongTien = value; }
        public string NguoiThu { get => _nguoiThu; set => _nguoiThu = value; }
        public DateTime NgayThu { get => _ngayThu; set => _ngayThu = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }

        public ThuTienNhaDTO(DataRow row)
        {
            this.MaSoThu = row["MaSoThu"].ToString();
            this.MaSoThue = row["MaSoThue"].ToString();
            this.Thang = row["Thang"].ToString();
            this.Nam = row["Nam"].ToString();
            this.TongTien = decimal.Parse(row["TongTien"].ToString());
            this.NguoiThu = row["NguoiThu"].ToString();
            this.NgayThu = DateTime.Parse(row["NgayThu"].ToString());
            this.GhiChu = row["GhiChu"].ToString();
        }
    }
}
