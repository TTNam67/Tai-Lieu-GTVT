using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nha_TaiSanDTO
    {
        private string _maNha;
        private string _maTaisan;
        private int _soLuong;
        private decimal? _giaTri;
        private string _tinhTrang;

        public Nha_TaiSanDTO(string maNha, string maTaisan, int soLuong, decimal? giaTri, string tinhTrang)
        {
            this._maNha = maNha;
            this._maTaisan = maTaisan;
            this._soLuong = soLuong;
            this._giaTri = giaTri;
            this._tinhTrang = tinhTrang;
        }

        public string MaNha { get => _maNha; set => _maNha = value; }
        public string MaTaisan { get => _maTaisan; set => _maTaisan = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public decimal? GiaTri { get => _giaTri; set => _giaTri = value; }
        public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }

        public Nha_TaiSanDTO(DataRow row)
        {
            this.MaNha = row["MaNha"].ToString();
            this.MaTaisan = row["MaTaisan"].ToString();
            this.SoLuong = int.Parse(row["SoLuong"].ToString());
            this.GiaTri = decimal.Parse(row["GiaTri"].ToString());
            this.TinhTrang = row["TinhTrang"].ToString();
        }
    }
}
