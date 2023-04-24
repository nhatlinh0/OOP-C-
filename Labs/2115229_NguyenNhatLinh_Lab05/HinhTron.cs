using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab05
{
    class HinhTron : HinhHoc
    {
        public HinhTron(float bk)
            : base(bk)
        {

        }

        public override float TinhDT()
        {
            return (float)Math.Round(Math.PI * this.canh * this.canh, 2);
        }

        public override string ToString()
        {
            return String.Format("Hinh Tron bk={0}, S={1}", this.Canh, TinhDT());
        }
    }
}
