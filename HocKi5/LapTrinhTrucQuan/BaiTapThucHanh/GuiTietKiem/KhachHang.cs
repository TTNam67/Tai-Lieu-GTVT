using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiTietKiem
{
    class KhachHang
    {
        private string maKH;
        private string hoTenKH;
        private string diaChi;
        private float soTienGui;
        private DateTime ngayGui;
        private int thoiHanGui;
        private int phatLoc;
        private double tienLai;
        private Dictionary<int, float> _tyLeLai = new Dictionary<int, float>() 
        {
            {1, 0.06F},
            {3, 0.07F},
            {6, 0.08F},
            {12, 0.09F}
        };

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public float SoTienGui { get => soTienGui; set => soTienGui = value; }
        public DateTime NgayGui { get => ngayGui; set => ngayGui = value; }
        public int ThoiHanGui { get => thoiHanGui; set => thoiHanGui = value; }
        public int Phatloc { get => phatLoc; set => phatLoc = value; }
        public double TienLai { get => tienLai; set => tienLai = value; }

        public KhachHang(string maKH, string hoTenKH, string diaChi, float soTienGui, DateTime ngayGui, int thoiHanGui, int phatLoc)
        {
            MaKH = maKH;
            HoTenKH = hoTenKH;
            DiaChi = diaChi;
            SoTienGui = soTienGui;
            NgayGui = ngayGui;
            ThoiHanGui = thoiHanGui;
            Phatloc = phatLoc;
            TinhTien();
        }

        public KhachHang() 
        {
            Phatloc = 0;
        }

        public void TinhTien()
        {
            TienLai = soTienGui * ((_tyLeLai[thoiHanGui] + phatLoc * 0.01F) /12 * thoiHanGui);
            TienLai = Math.Round(TienLai, 2);
        }

        public override string ToString()
        {
            string hinhThucGui;
            if (Phatloc == 0)
                hinhThucGui = "loai thuong";
            else
                hinhThucGui = "loai phat loc";

            string res = $"Ma: {maKH}, HoTen: {HoTenKH}, DiaChi: {diaChi}, NgayGui: {ngayGui.ToString()}, ThoiHanGui: {thoiHanGui.ToString()}, SoTienGui: {soTienGui.ToString()}, TienLai: {TienLai}, TongTien = {TienLai + SoTienGui}";

            return res;

        }

        public string ThongTin()
        {
            string res = $"Ma: {maKH}, HoTen: {HoTenKH}, DiaChi: {diaChi}";
            return res;
        }

       
    }
}
