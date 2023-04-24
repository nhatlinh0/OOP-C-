using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu_KeThua
{
    class HinhHoc
    {
        protected float canh;

        public HinhHoc(float c)
        {
            this.canh = c;
        }

        public float TinhDT()
        {
            return 0;
        }
        public float Canh
        {
            get { return canh; }    
        }
    }
}
