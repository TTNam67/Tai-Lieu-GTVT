using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachThueDTO
    {
        private string _maKhach;
        private string _tenKhach;
        private DateTime _ngaySinh;
        private int _gioiTinh;
        private string _soCMND;
        private string _diaChiThuongTru;
        private string _maNghe;
        private string _maCQ;

        public KhachThueDTO(string maKhach, string tenKhach, DateTime ngaySinh, int gioiTinh,
            string soCMND, string diaChiThuongTru, string maNghe, string maCQ)
        {
            this._maKhach = maKhach;
            this._tenKhach = tenKhach;
            this._ngaySinh = ngaySinh;
            this._gioiTinh = gioiTinh;
            this._soCMND = soCMND;
            this._diaChiThuongTru = diaChiThuongTru;
            this._maNghe = maNghe;
            this._maCQ = maCQ;
        }

        public string MaKhach { get => _maKhach; set => _maKhach = value; }
        public string TenKhach { get => _tenKhach; set => _tenKhach = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public int GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string SoCMND { get => _soCMND; set => _soCMND = value; }
        public string DiaChiThuongTru { get => _diaChiThuongTru; set => _diaChiThuongTru = value; }
        public string MaNghe { get => _maNghe; set => _maNghe = value; }
        public string MaCQ { get => _maCQ; set => _maCQ = value; }

        public KhachThueDTO(DataRow row)
        {
            this.MaKhach = row["MaKhach"].ToString();
            this.TenKhach = row["TenKhach"].ToString();
            this.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            this.GioiTinh = int.Parse(row["GioiTinh"].ToString());
            this.SoCMND = row["SoCMND"].ToString();
            this.MaNghe = row["MaNghe"].ToString();
            this.MaCQ = row["MaCQ"].ToString();
        }
    }
}
