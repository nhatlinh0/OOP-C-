using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu_KeThua
{
    class QuanLyHinhHoc
    {
        List<HinhHoc> dsHinhHoc = new List<HinhHoc>();
        public QuanLyHinhHoc()
        {
            dsHinhHoc = new List<HinhHoc>();
        }

        public void Them(HinhHoc hh)
        {
            this.dsHinhHoc.Add(hh);
        }

        public void NhapCD()
        {
            Them(new HinhVuong(3));
            Them(new HinhCN(3, 10));
            Them(new HinhTron(2.5f));
            Them(new HinhVuong(6));
            Them(new HinhCN(4, 5));
            Them(new HinhVuong(8));
            Them(new HinhVuong(3));
            Them(new HinhCN(2, 7));
            Them(new HinhTron(10));
        }

        public override string ToString()
        {
            string s = "";
            foreach (var hh in this.dsHinhHoc)
            {
                s += hh + "\n";
            }

            return s;
        }

        //Tong dien tich cua cac hinh tron
        public float TongDTHinhTron()
        {
            float s = 0;
            foreach (var hh in this.dsHinhHoc)
            {
                if (hh is HinhTron)
                    s += ((HinhTron)hh).TinhDT();
            }
            return s;          

        }

        // return this.dsHinhHoc.Sum(x => x is HinhTron);
    }
}
