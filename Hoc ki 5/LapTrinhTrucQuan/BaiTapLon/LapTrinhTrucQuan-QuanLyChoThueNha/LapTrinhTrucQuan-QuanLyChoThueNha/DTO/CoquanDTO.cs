using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoQuanDTO
    {
        private string _maCQ;
        private string _tenCQ;

        public string MaCQ { get => _maCQ; set => _maCQ = value; }
        public string TenCQ { get => _tenCQ; set => _tenCQ = value; }

        public CoQuanDTO(string maCQ, string tenCQ)
        {
            _maCQ = maCQ;
            _tenCQ = tenCQ;
        }

        public CoQuanDTO(DataRow row)
        {
            this.MaCQ = row["MaCQ"].ToString();
            this.TenCQ = row["TenCQ"].ToString();
        }
    }
}
