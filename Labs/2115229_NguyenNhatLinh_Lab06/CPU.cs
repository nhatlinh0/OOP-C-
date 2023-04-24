using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab06
{
    class CPU:IThietBi
    {
        private int gia;
        private float tocdo;

        public int Gia
        {
            get { return gia; }
        }
        public float TocDo
        {
            get { return tocdo; }
            set { tocdo = value; }
        }

       public CPU()
        {

        }

        public CPU(float td, int g)
        {
            this.gia = g;
            this.TocDo = td;
        }

        

        public override string ToString()
        {
            return String.Format("CPU co gia={0}, toc do={1} ", gia, TocDo);
        }

    }
}
