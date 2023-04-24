using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab05
{
    class HinhTG:HinhHoc
    {
        private float canhday;
        public HinhTG(float dc, float canhday):base (dc)
        {
            this.canhday = canhday;
        }

        public override float TinhDT()
        {
            if(this.canh == this.canhday * (float)Math.Sqrt(3) /2)
            {
                return (float)((this.canh * this.canh) * (float)Math.Sqrt(3) /4);
            }
            return (float)(Math.Round(this.canh * 1 / 2 * this.canhday,2));
        }

        public override string ToString()
        {
            return String.Format("Hinh tam giac co duong cao:{0}, canh day:{1}, S={2}", this.canh, this.canhday, TinhDT());
        }
    }
}

