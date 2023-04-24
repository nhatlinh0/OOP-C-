using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vidu_KeThua
{
    class HinhTron:HinhHoc
    {
  
        public HinhTron(float bk):base(bk)
        {
        
        }
        public float TinhDT()
        {
            return (float) Math.Round( Math.PI * this.canh * this.canh, 2);
        }
        public override string ToString()
        {
            return String.Format("Hinh Tron bk={0}, S={1}", this.Canh, TinhDT());
        }
    }
}
