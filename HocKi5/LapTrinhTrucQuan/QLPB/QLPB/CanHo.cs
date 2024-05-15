using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPB
{
    internal class CanHo
    {
        string DiaChi, HBC, TT;
        int pn, wc, ck, gia;

        public CanHo()
        {
        }
        public CanHo(string diaChi, int wc, int pn, string hBC, int gia, int ck, string tT)
        {
            DiaChi = diaChi;
            HBC = hBC;
            TT = tT;
            this.pn = pn;
            this.wc = wc;
            this.ck = ck;
            this.gia = gia;
        }
    }

}
