using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThueNhaDTO
    {
        private string _maSoThue;
        private string _maKhach;
        private string _maNha;
        private string _maMucdichSD;
        private DateTime _ngayBD;
        private DateTime _ngayKT;
        private decimal _tienDatCoc;
        private string _maHinhthucTT;

        public ThueNhaDTO(string maSoThue, string maKhach, string maNha, string maMucdichSD, DateTime ngayBD, DateTime ngayKT, decimal tienDatCoc, string maHinhthucTT)
        {
            this._maSoThue = maSoThue;
            this._maKhach = maKhach;
            this._maNha = maNha;
            this._maMucdichSD = maMucdichSD;
            this._ngayBD = ngayBD;
            this._ngayKT = ngayKT;
            this._tienDatCoc = tienDatCoc;
            this._maHinhthucTT = maHinhthucTT;
        }

        public string MaSoThue { get => _maSoThue; set => _maSoThue = value; }
        public string MaKhach { get => _maKhach; set => _maKhach = value; }
        public string MaNha { get => _maNha; set => _maNha = value; }
        public string MaMucdichSD { get => _maMucdichSD; set => _maMucdichSD = value; }
        public DateTime NgayBD { get => _ngayBD; set => _ngayBD = value; }
        public DateTime NgayKT { get => _ngayKT; set => _ngayKT = value; }
        public decimal TienDatCoc { get => _tienDatCoc; set => _tienDatCoc = value; }
        public string MaHinhthucTT { get => _maHinhthucTT; set => _maHinhthucTT = value; }

        public ThueNhaDTO(DataRow row)
        {
            this.MaSoThue = row["MaSoThue"].ToString();
            this.MaKhach = row["MaKhach"].ToString();
            this.MaNha = row["MaNha"].ToString();
            this.MaMucdichSD = row["MaMucDichSD"].ToString();
            this.NgayBD = DateTime.Parse(row["NgayBD"].ToString());
            this.NgayKT = DateTime.Parse(row["NgayKT"].ToString());
            this.TienDatCoc = decimal.Parse(row["TienDatCoc"].ToString());
            this.MaHinhthucTT = row["MaHinhThucTT"].ToString();
        }
    }
}
