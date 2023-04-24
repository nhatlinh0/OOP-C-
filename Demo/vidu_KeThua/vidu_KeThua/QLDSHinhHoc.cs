using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu_KeThua
{
    class QLDSHinhHoc
    {
        List<HinhHoc> dsHinhHoc = new List<HinhHoc>();
        public QLDSHinhHoc()
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
            Them(new HinhCN(3, 4));
            Them(new HinhTron(2));
            Them(new HinhVuong(6));
            Them(new HinhCN(4, 5));
            Them(new HinhVuong(8));
            Them(new HinhVuong(3));
            Them(new HinhCN(2, 7));
            Them(new HinhTron(1));
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
                    s += hh.TinhDT();                   
            }
            return s;
        }
        public float TongDThh()
        {
            float s = 0;
            foreach ( var hh in this.dsHinhHoc)
            {
                //if (hh is HinhTron || hh is HinhVuong || hh is HinhCN)
                    s += hh.TinhDT();               
                
            }
            return s;
        }

       public void hoanvi(ref HinhHoc a,ref HinhHoc b)
        {
            HinhHoc temp = a;
            a = b;
            b = temp;
        }
        public void saptang()
        {
            int i, j;
            for (i = 0; i < dsHinhHoc.Count - 1; i++)
                for (j = i + 1; j < dsHinhHoc.Count; j++)
                {
                    if (dsHinhHoc[i].TinhDT() > dsHinhHoc[j].TinhDT())
                    {
                        HinhHoc tam = dsHinhHoc[i];
                        dsHinhHoc[i] = dsHinhHoc[j];
                        dsHinhHoc[j] = tam;
                    }
                }
        }
        public float MaxDTHinhTron()
        {
            List<HinhHoc> kq = dsHinhHoc.FindAll(x => x is HinhTron);
            return kq.Max(x => x.TinhDT());
        }

    }
}
