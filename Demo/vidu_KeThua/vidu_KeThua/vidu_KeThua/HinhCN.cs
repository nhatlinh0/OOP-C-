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
        public float TinhDT()
        {
            return this.rong * this.canh;
        }
        public override string ToString()
        {
            return String.Format("Hinh chu nhat ({0}, {1}), s={2}", this.rong, this.canh, TinhDT());
        }
    }
}
