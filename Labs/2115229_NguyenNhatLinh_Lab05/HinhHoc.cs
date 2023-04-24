using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab05
{
    class HinhHoc
    {
        protected float canh;
        public HinhHoc(float c)
        {
            this.canh = c;
        }

        public HinhHoc()
        {

        }

        public virtual float TinhDT()
        {
            return 0;
        }

        public float Canh
        {
            get { return this.canh; }
        }
    }
}
