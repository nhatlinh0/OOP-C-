using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu_KeThua
{
    class HinhVuong:HinhHoc
    {
        public HinhVuong(float c): base(c)
        {

        }
        public float TinhDT()
        {
            return this.canh * this.canh;

        }
        public override string ToString()
        {
            return String.Format("Hinh vuong c={0}, S={1}",this.Canh, TinhDT());
        }
       
    }
}
