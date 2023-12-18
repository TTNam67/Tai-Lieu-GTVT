using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraGiuaKy
{
    internal class TacPham
    {
        string tenTacGia;
        int maTacPham;
        string tenTacPham;
        string loaiTacPham;

        public TacPham(string tenTacGia, int maTacPham, string tenTacPham, string loaiTacPham)
        {
            this.TenTacGia = tenTacGia;
            this.MaTacPham = maTacPham;
            this.TenTacPham = tenTacPham;
            this.LoaiTacPham = loaiTacPham;
        }

        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public int MaTacPham { get => maTacPham; set => maTacPham = value; }
        public string TenTacPham { get => tenTacPham; set => tenTacPham = value; }
        public string LoaiTacPham { get => loaiTacPham; set => loaiTacPham = value; }
    }
}
