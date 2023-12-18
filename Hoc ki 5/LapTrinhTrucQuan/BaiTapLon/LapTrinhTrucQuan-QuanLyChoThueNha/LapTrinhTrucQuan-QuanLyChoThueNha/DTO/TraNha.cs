using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraNhaDTO
    {
        private string _maSoThue;
        private DateTime _ngayTra;
        private decimal _tongTien;

        public TraNhaDTO(string maSoThue, DateTime ngayTra, decimal tongTien)
        {
            this._maSoThue = maSoThue;
            this._ngayTra = ngayTra;
            this._tongTien = tongTien;
        }

        public string MaSoThue { get => _maSoThue; set => _maSoThue = value; }
        public DateTime NgayTra { get => _ngayTra; set => _ngayTra = value; }
        public decimal TongTien { get => _tongTien; set => _tongTien = value; }

        public TraNhaDTO(DataRow row)
        {
            this.MaSoThue = row["MaSoThue"].ToString();
            this.NgayTra = DateTime.Parse(row["NgayTra"].ToString());
            this.TongTien = decimal.Parse(row["TongTien"].ToString());
        }
    }
}
