using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucNhaDTO
    {
        private string _maNha;
        private string _tenChuNha;
        private string _dienThoai;
        private string _maLoai;
        private string _maDTSD;
        private string _diaChi;
        private decimal? _donGiaThue;
        private string _tinhTrang;
        private int _daThue;
        private string _ghiChu;

        public string MaNha { get => _maNha; set => _maNha = value; }
        public string TenChuNha { get => _tenChuNha; set => _tenChuNha = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string MaLoai { get => _maLoai; set => _maLoai = value; }
        public string MaDTSD { get => _maDTSD; set => _maDTSD = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public decimal? DonGiaThue { get => _donGiaThue; set => _donGiaThue = value; }
        public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
        public int DaThue { get => _daThue; set => _daThue = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }

        public DanhMucNhaDTO(string maNha, string tenChuNha, string dienThoai, string maLoai,
            string maDTSD, string diaChi, decimal? donGiaThue, string tinhTrang, int daThue, string ghiChu)
        {
            this._maNha = maNha;
            this._tenChuNha = tenChuNha;
            this._dienThoai = dienThoai;
            this._maLoai = maLoai;
            this._maDTSD = maDTSD;
            this._diaChi = diaChi;
            this._donGiaThue = donGiaThue;
            this._tinhTrang = tinhTrang;
            this._daThue = daThue;
            this._ghiChu = ghiChu;
        }

        public DanhMucNhaDTO(DataRow row)
        {
            this.MaNha = row["MaNha"].ToString();
            this.TenChuNha = row["TenChuNha"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.MaLoai = row["MaLoai"].ToString();
            this.MaDTSD = row["MaDTSD"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.DonGiaThue = decimal.Parse(row["DonGiaThue"].ToString());
            this.TinhTrang = row["TinhTrang"].ToString();
            this.DaThue = int.Parse(row["DaThue"].ToString());
            this.GhiChu = row["GhiChu"].ToString();
        }
    }
}
