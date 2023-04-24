using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab06
{
    class MayTinh
    {
       
        private List<IThietBi> dsThietBi = new List<IThietBi>();
        private string maso;
        private DateTime ngaysx;
        private string ten;

        public string Ten
        {
            get { return ten; }
        }
        public int Gia
        {
            get { return TongGia(); }
        }

        public string MaSo
        {
            get { return this.maso; }
            set { this.maso = value; }
        }
        public int NamSX
        {
            get { return this.ngaysx.Year; }
        }
         public int SoTB
        {
            get { return dsThietBi.Count; }
        }

        public IThietBi this[int index]
        {
            get { return this.dsThietBi[index]; }
            set { this.dsThietBi[index] = value; }
        }
            


        public MayTinh()
        {

        }

        public MayTinh(string ms, DateTime ngay, string t)
        {
            dsThietBi = new List<IThietBi>();
            this.maso = ms;
            this.ngaysx = ngay;
            this.ten = t;
            
        }
        
        public MayTinh(string ms, DateTime ngay, string t, List<IThietBi> dstb)
        {
            this.dsThietBi = dstb;
            this.maso = ms;
            this.ngaysx = ngay;
            this.ten = t;
        }

        public void ThemTB(IThietBi tb)
        {
            this.dsThietBi.Add(tb);
        }

        public int TongGia()
        {
            int s = 0;
            foreach(var tb in dsThietBi)
            {
                s = s + tb.Gia;
            }
            return s;
        }

        public int DemRam()
        {
            int dem = 0;
            foreach (var tb in this.dsThietBi)
            {
                if(tb is Ram)
                {
                    dem++;
                }
            }
            return dem;                                
        }

        public int TongRam()
        {
            int s = 0;
            foreach(var tb in dsThietBi)
            {
                if(tb is Ram)
                {
                    s = s + tb.Gia;
                    
                }
            }
            return s;
        }
        
        public float TongTocDoCPU()
        {
            float s = 0;
            foreach(var tb in dsThietBi)
            {
                if (tb is CPU)
                {
                    s = s + ((CPU)(tb)).TocDo;
                }
                    
            }
            return s;
        }

        public int TongLinhKien()
        {
            int dem = 0;
            foreach(var tb in dsThietBi)
            {
                if (tb is CPU || tb is Ram)
                    dem++;
                        
            }
            return dem;
        }

        public void NhapCPU(MayTinh mt)
        {
            float td;
            int g;
            Console.WriteLine("Nhap toc do CPU:");
            td = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia CPU:");
            g = int.Parse(Console.ReadLine());
            mt.ThemTB(new CPU(td, g));
        }

        public void NhapRam(MayTinh mt)
        {
            float dl;
            int g;
            Console.WriteLine("Nhap dung luong Ram:");
            dl = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia Ram:");
            g = int.Parse(Console.ReadLine());
            mt.ThemTB(new Ram(dl, g));
        }

        public override string ToString()
        {
            string s = String.Format("May Tinh {0}\t{1}\t{2}\t{3}\n\t Danh sach thiet bi: ", this.maso, this.ten, this.ngaysx, this.Gia);
            foreach(var tb in dsThietBi)
            {
                s = s + "\n\t" + tb;
            }
            return s;
        }

    }

}
