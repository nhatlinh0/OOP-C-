using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu_KeThua
{
    class HinhCN:HinhVuong
    {
        private float rong;
        public HinhCN(float rong, float dai) : base(dai)
        {
            this.rong = rong;
        }
        public override float TinhDT()
        {
            return this.rong * this.canh;
        }
        public override string ToString()
        {
            return String.Format("Hinh CN ({0}, {1}) \t\t s={2}", this.rong, this.canh, TinhDT());
        }
    }
}
