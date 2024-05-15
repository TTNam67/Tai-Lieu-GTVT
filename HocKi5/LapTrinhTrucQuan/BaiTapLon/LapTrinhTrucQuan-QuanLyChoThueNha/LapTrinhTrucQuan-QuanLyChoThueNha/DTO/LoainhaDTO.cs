using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNhaDTO
    {
        private string _maLoai;
        private string _tenLoai;

        public LoaiNhaDTO(string maLoai, string tenLoai)
        {
            this._maLoai = maLoai;
            this._tenLoai = tenLoai;
        }

        public string MaLoai { get => _maLoai; set => _maLoai = value; }
        public string TenLoai { get => _tenLoai; set => _tenLoai = value; }

        public LoaiNhaDTO(DataRow row)
        {
            this.MaLoai = row["MaLoai"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
        }
    }
}
