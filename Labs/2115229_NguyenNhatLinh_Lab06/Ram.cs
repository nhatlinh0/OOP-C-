using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab06
{
    class Ram:IThietBi
    {
        private float dungluong;
        private int gia;

        public float DungLuong
        {
            get { return dungluong; }
            set { dungluong = value; }
        }

        public int Gia
        {
            get { return gia; }
        }

        public Ram()
        {

        }

        public Ram(float dl, int g)
        {
            this.gia = g;
            this.DungLuong = dl;
        }

       
        public override string ToString()
        {
            return String.Format("Ram co gia {0}, dung luong {1}", gia, DungLuong);
        }
    }
}
