using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiKetThucHocPhan
{
    internal class KhachHang
    {
        string maKhachHang;
        string hoTenKhachHang;
        string diaChi;
        DateTime NgayChotSo;
        int soThangTruoc;
        int soThangNay;

        public KhachHang(string maKhachHang, string hoTenKhachHang, string diaChi, DateTime ngayChotSo, int soThangTruoc, int soThangNay)
        {
            this.MaKhachHang = maKhachHang;
            this.HoTenKhachHang = hoTenKhachHang;
            this.DiaChi = diaChi;
            NgayChotSo1 = ngayChotSo;
            this.SoThangTruoc = soThangTruoc;
            this.SoThangNay = soThangNay;
        }

        public KhachHang()
        {

        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoTenKhachHang { get => hoTenKhachHang; set => hoTenKhachHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayChotSo1 { get => NgayChotSo; set => NgayChotSo = value; }
        public int SoThangTruoc { get => soThangTruoc; set => soThangTruoc = value; }
        public int SoThangNay { get => soThangNay; set => soThangNay = value; }
    }
}
