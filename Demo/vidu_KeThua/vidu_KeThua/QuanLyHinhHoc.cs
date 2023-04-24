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
            Them(new HinhTron(3));
            Them(new HinhCN(3, 4));
            Them(new HinhTron(2));
            Them(new HinhVuong(6));
            Them(new HinhCN(4, 5));
            Them(new HinhVuong(8));
            Them(new HinhVuong(13));
            Them(new HinhCN(2, 7));
            Them(new HinhTron(7));
            Them(new HinhVuong(13));
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


        public void SapGiamHinhTron()
        {
            int i, j;
            bool dk;
            for (i = 0; i < dsHinhHoc.Count - 1; i++)
                for (j = i + 1; j < dsHinhHoc.Count; j++)
                {
                    dk =dsHinhHoc[i] is HinhTron && dsHinhHoc[j] is HinhTron &&
                        dsHinhHoc[i].TinhDT()< dsHinhHoc[j].TinhDT();
                    if (dk)
                    {
                        HinhHoc tam = dsHinhHoc[i];
                        dsHinhHoc[i] = dsHinhHoc[j];
                        dsHinhHoc[j] = tam;
                    }
                }
        }

        public float MaxDT()
        {
            //Cach 1
             float max = 0.0f;
             foreach (var hh in this.dsHinhHoc)
             {
                 if (max < hh.TinhDT())
                     max = hh.TinhDT();

             }
             return max;

            //Cach 2

            //return this.dsHinhHoc.Max(hh => hh.TinhDT());
        }
        
        public QuanLyHinhHoc DanhSachHVMax()
        {

            //Cach 1
            float max = this.MaxDT();
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            foreach (var hh in this.dsHinhHoc)
            {
                if (hh is HinhVuong && max == hh.TinhDT())
                    kq.Them(hh);

            }
            return kq;
            
            //float max = MaxDT();
            //QuanLyHinhHoc kq = new QuanLyHinhHoc();
            //List<HinhHoc> ds = dsHinhHoc.FindAll(hh => hh is HinhVuong && hh.TinhDT() == max);
            //kq.dsHinhHoc = ds;
            //return kq;
        }

        public QuanLyHinhHoc DSHinhVuongMax()
        {
            float max = dsHinhHoc.Max(hh => hh.TinhDT());
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            List<HinhHoc> ds = dsHinhHoc.FindAll(hh => hh is HinhVuong && hh.TinhDT() == max);
            kq.dsHinhHoc = ds;
            return kq;           
        }

    }
}
