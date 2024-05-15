using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraNha_MatTaiSanDTO
    {
        private string _maSoThue;
        private string _maTaiSan;
        private int _soLuong;
        private decimal _giaTri;
        private decimal _thanhTien;

        public TraNha_MatTaiSanDTO(string maSoThue, string maTaiSan, int soLuong, decimal giaTri, decimal thanhTien)
        {
            this._maSoThue = maSoThue;
            this._maTaiSan = maTaiSan;
            this._soLuong = soLuong;
            this._giaTri = giaTri;
            this._thanhTien = thanhTien;
        }

        public string MaSoThue { get => _maSoThue; set => _maSoThue = value; }
        public string MaTaiSan { get => _maTaiSan; set => _maTaiSan = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public decimal GiaTri { get => _giaTri; set => _giaTri = value; }
        public decimal ThanhTien { get => _thanhTien; set => _thanhTien = value; }

        public TraNha_MatTaiSanDTO(DataRow row)
        {
            this.MaSoThue = row["MaSoThue"].ToString();
            this.MaTaiSan = row["MaTaiSan"].ToString();
            this.SoLuong = int.Parse(row["SoLuong"].ToString());
            this.GiaTri = decimal.Parse(row["GiaTri"].ToString());
            this.ThanhTien = decimal.Parse(row["ThanhTien"].ToString());
        }
    }
}
