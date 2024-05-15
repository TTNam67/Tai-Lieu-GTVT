using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HinhThucThanhToanDTO
    {
        private string _maHinhThucTT;
        private string _tenHinhThucTT;

        public HinhThucThanhToanDTO(string maHinhThucTT, string tenHinhThucTT)
        {
            this._maHinhThucTT = maHinhThucTT;
            this._tenHinhThucTT = tenHinhThucTT;
        }

        public string MaHinhThucTT { get => _maHinhThucTT; set => _maHinhThucTT = value; }
        public string TenHinhThucTT { get => _tenHinhThucTT; set => _tenHinhThucTT = value; }

        public HinhThucThanhToanDTO(DataRow row)
        {
            this.MaHinhThucTT = row["MaHinhThucTT"].ToString();
            this.TenHinhThucTT = row["TenHinhThucTT"].ToString();
        }
    }
}
