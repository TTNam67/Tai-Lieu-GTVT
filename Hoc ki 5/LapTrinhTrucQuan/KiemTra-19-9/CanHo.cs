using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra_19_9
{

    enum TinhTrang
    {
        DaDatCoc,
        DaBan,
        ConTrong
    }
    internal class CanHo
    {
        Dictionary<string, float> MapChietKhau = new Dictionary<string, float>
        {
            {"Bac", 0f },
            {"Nam", 0f },
            {"Tay", -0.1f},
            { "TayBac", -0.05f },
            { "TayNam", -0.02f },
            {"Dong", 0f },
            {"DongBac", 0f },
            {"DongNam", 0.01f }
        };

        string diaChi;
        int soPhongNgu;
        int soNhaVeSinh;
        float giaTien;
        float chietKhau;
        string huongBanCong;
        TinhTrang tinhTrang;
        

        public CanHo(string diaChi, int soPhongNgu, int soNhaVeSinh, float giaTien, string huongBanCong, TinhTrang tinhTrang)
        {
            this.DiaChi = diaChi;
            this.SoPhongNgu = soPhongNgu;
            this.SoNhaVeSinh = soNhaVeSinh;
            this.GiaTien = giaTien;
            this.ChietKhau = MapChietKhau[huongBanCong];
            this.HuongBanCong = huongBanCong;
            this.TinhTrang = tinhTrang;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SoPhongNgu { get => soPhongNgu; set => soPhongNgu = value; }
        public int SoNhaVeSinh { get => soNhaVeSinh; set => soNhaVeSinh = value; }
        public string HuongBanCong { get => huongBanCong; set => huongBanCong = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public float ChietKhau { get => chietKhau; set => chietKhau = value; }
        public TinhTrang TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public override string ToString()
        {
            string tmpTinhTrang;
            if (tinhTrang == TinhTrang.DaDatCoc)
            {
                tmpTinhTrang = "Da Dat Coc";
            }
            else if (tinhTrang == TinhTrang.DaBan)
            {
                tmpTinhTrang = "Da Ban";
            }
            else
            {
                tmpTinhTrang = "Con Trong";
            }

            giaTien = giaTien * (1 - chietKhau);
            return diaChi + ", So phong ngu: " + soPhongNgu.ToString() + ", So nha ve sinh: " + soNhaVeSinh.ToString() + ", huong ban cong: " + huongBanCong + ", gia tien: " + giaTien.ToString() + ", tinh trang: " + tmpTinhTrang;
        }
    }
}
