using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NgheNghiepDTO
    {
        private string _maNghe;
        private string _tenNghe;

        public string MaNghe { get => _maNghe; set => _maNghe = value; }
        public string TenNghe { get => _tenNghe; set => _tenNghe = value; }

        public NgheNghiepDTO(string maNghe, string tenNghe)
        {
            this._maNghe = maNghe;
            this._tenNghe = tenNghe;
        }

        public NgheNghiepDTO(DataRow row)
        {
            this.MaNghe = row["MaNghe"].ToString();
            this.TenNghe = row["TenNghe"].ToString();
        }
    }
}
