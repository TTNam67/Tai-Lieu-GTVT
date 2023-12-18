using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiSanDTO
    {
        private string _maTaisan;
        private string _tenTaisan;

        public TaiSanDTO(string maTaisan, string tenTaisan)
        {
            this._maTaisan = maTaisan;
            this._tenTaisan = tenTaisan;
        }

        public string MaTaisan { get => _maTaisan; set => _maTaisan = value; }
        public string TenTaisan { get => _tenTaisan; set => _tenTaisan = value; }

        public TaiSanDTO(DataRow row)
        {
            this.MaTaisan = row["Mataisan"].ToString();
            this.TenTaisan = row["Tentaisan"].ToString();
        }
    }
}
