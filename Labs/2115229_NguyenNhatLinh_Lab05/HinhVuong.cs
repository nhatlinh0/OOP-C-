using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab05
{
    class HinhVuong : HinhHoc
    {
        public HinhVuong(float c)
            : base(c)
        {

        }

        public override float TinhDT()
        {
            return this.canh * this.canh;
        }

        public override string ToString()
        {
            return String.Format("Hinh Vuong c={0}, S={1}", this.canh, TinhDT());
        }
    }
}
