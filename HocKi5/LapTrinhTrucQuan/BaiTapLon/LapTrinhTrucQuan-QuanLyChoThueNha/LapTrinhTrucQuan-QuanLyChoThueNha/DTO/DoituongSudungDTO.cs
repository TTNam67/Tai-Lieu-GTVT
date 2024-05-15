using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiTuongSuDungDTO
    {
        private string _maDTSD;
        private string _tenDTSD;

        public string MaDTSD { get => _maDTSD; set => _maDTSD = value; }
        public string TenDTSD { get => _tenDTSD; set => _tenDTSD = value; }

        public DoiTuongSuDungDTO(string maDTSD, string tenDTSD)
        {
            this._maDTSD = maDTSD;
            this._tenDTSD = tenDTSD;
        }

        public DoiTuongSuDungDTO(DataRow row)
        {
            this.MaDTSD = row["MaDTSD"].ToString();
            this.TenDTSD = row["TenDTSD"].ToString();
        }
    }
}
