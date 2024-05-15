using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MucDichSuDungDTO
    {
        private string _maMucDichSD;
        private string _tenMucDichSD;

        public MucDichSuDungDTO(string maMucdichSD, string tenMucdichSD)
        {
            this._maMucDichSD = maMucdichSD;
            this._tenMucDichSD = tenMucdichSD;
        }

        public string MaMucDichSD { get => _maMucDichSD; set => _maMucDichSD = value; }
        public string TenMucDichSD { get => _tenMucDichSD; set => _tenMucDichSD = value; }

        public MucDichSuDungDTO(DataRow row)
        {
            this.MaMucDichSD = row["MaMucDichSD"].ToString();
            this.TenMucDichSD = row["TenMucDichSD"].ToString();
        }
    }
}
