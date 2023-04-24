using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab05
{

    public enum LoaiHinh
    {
        TatCa,
        HinhTron,
        HinhVuong,
        HinhCN,
        HinhTG,
    }


    class QuanLyHinhHoc
    {
        List<HinhHoc> dsHinhHoc = new List<HinhHoc>();

        public HinhHoc this[int index]
        {
            get { return this.dsHinhHoc[index]; }
            set
            {
                this.dsHinhHoc[index] = value;
            }
        }



        public QuanLyHinhHoc()
        {
            dsHinhHoc = new List<HinhHoc>();
        }

        public void Them(HinhHoc hh)
        {
            dsHinhHoc.Add(hh);
        }

        public void NhapCD()
        {
            Them(new HinhVuong(3));
            Them(new HinhCN(3, 10));
            Them(new HinhTG(2, 4));
            Them(new HinhTG(6, 1));
            Them(new HinhTron(2.5f));
            Them(new HinhVuong(6));
            Them(new HinhTG(8, 3));
            Them(new HinhCN(4, 5));
            Them(new HinhVuong(8));
            Them(new HinhTG(5, 9));
            Them(new HinhVuong(3));
            Them(new HinhCN(2, 7));
            Them(new HinhTG((float)3.46, 4));
            Them(new HinhTron(10));
        }

        public float TongDT()
        {
            float s = 0;
            foreach (var hh in dsHinhHoc)
            {
                if (hh is HinhTron)
                    s = s + ((HinhTron)hh).TinhDT();
            }
            return s;
        }

       

        public int DemHinh(LoaiHinh hinh)
        {
            int dem = 0;
            switch (hinh)
            {
                case LoaiHinh.TatCa:
                    dem = dsHinhHoc.Count;
                    break;
                case LoaiHinh.HinhTron:
                    foreach (var hh in dsHinhHoc)
                    {
                        if (hh is HinhTron)
                            dem++;
                    }
                    break;
                case LoaiHinh.HinhVuong:
                    foreach (var hh in dsHinhHoc)
                    {
                        if (hh is HinhVuong && !(hh is HinhCN))
                            dem++;
                    }
                    break;
                case LoaiHinh.HinhCN:
                    foreach (var hh in dsHinhHoc)
                    {
                        if (hh is HinhCN)
                            dem++;
                    }
                    break;
            }
            return dem;
        }

        public QuanLyHinhHoc XoaTheoLoaiHinh(LoaiHinh hinh)
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            
            switch (hinh)
            {
                case LoaiHinh.TatCa:
                    kq.NhapCD();
                    for (int i = 0; i < kq.dsHinhHoc.Count; i++)
                    {
                        kq.dsHinhHoc.RemoveAt(i);
                        i--;


                    }
                    Console.WriteLine("Da xoa tat ca hinh");
                    break;
                case LoaiHinh.HinhTron:
                    kq.NhapCD();
                    for(int i=0; i< kq.dsHinhHoc.Count;i++)
                    {
                        if(kq.dsHinhHoc[i] is HinhTron)
                        {
                            kq.dsHinhHoc.RemoveAt(i);
                            i--;
                        }
                        
                           
                    }
                    break;
                case LoaiHinh.HinhVuong:
                    kq.NhapCD();
                    int y = 0;
                    
                    foreach(var hh in dsHinhHoc)
                    {
                        if (kq.dsHinhHoc[y] is HinhVuong && !(kq.dsHinhHoc[y] is HinhCN))
                        {
                            kq.dsHinhHoc.RemoveAt(y);
                            y--;
                        }
                        y++;



                    }
                    break;
                case LoaiHinh.HinhCN:
                    kq.NhapCD();
                    for (int i = 0; i < kq.dsHinhHoc.Count; i++)
                    {
                        if (kq.dsHinhHoc[i] is HinhCN)
                        {
                            kq.dsHinhHoc.RemoveAt(i);
                            i--;
                        }


                    }
                    break;
            }
            return kq;
        }

        public QuanLyHinhHoc TimSLonNhat()
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            float max = 0;
            foreach (var hh in dsHinhHoc)
            {
                if (hh.TinhDT() > max)
                    max = hh.TinhDT();

            }

            foreach (var hh in dsHinhHoc)
            {
                if (hh.TinhDT() == max)
                    kq.dsHinhHoc.Add(hh);

            }

            return kq;

        }

        public QuanLyHinhHoc ChenHinhTron(HinhTron ht)
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            int vt = 0;
            float max = 0;
            kq.NhapCD();
            for(int i=0;i<dsHinhHoc.Count;i++)
            {
                if (kq.dsHinhHoc[i].TinhDT() > max)
                {
                    max = kq.dsHinhHoc[i].TinhDT();
                    vt = i;
                }

            }
            kq.dsHinhHoc.Insert(vt+1, ht);
            return kq;
            
        }

        public QuanLyHinhHoc XoaHinhVuongNhoNhat()
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            kq.NhapCD();
            float max = 0;
            float min = 0;
            foreach (var hh in dsHinhHoc)
            {
                if (hh.TinhDT() > max)
                    max = hh.TinhDT();
            }
            min = max;
            foreach (var hh in dsHinhHoc)
            {
                if (hh is HinhVuong && !(hh is HinhCN))
                {
                    if (hh.TinhDT() < min)
                        min = hh.TinhDT();
                }
            }

            for(int i=0;i<kq.dsHinhHoc.Count;i++)
            {
                if (kq.dsHinhHoc[i].TinhDT() == min)
                    if (kq.dsHinhHoc[i] is HinhVuong && !(kq.dsHinhHoc[i] is HinhCN))
                    {
                        kq.dsHinhHoc.RemoveAt(i);
                        i--;
                    }
                    
            }
            return kq;

        }
        public QuanLyHinhHoc SXTheoYeuCau()
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            kq.NhapCD();
            HinhHoc temp = new HinhHoc();
            for (int i = 0; i < dsHinhHoc.Count - 1; i++)
            {
                for (int j = i; j < dsHinhHoc.Count; j++)
                {
                    if (kq.dsHinhHoc[j] is HinhTron && !(dsHinhHoc[i] is HinhTron))
                    {
                        temp = kq.dsHinhHoc[i];
                        kq.dsHinhHoc[i] = kq.dsHinhHoc[j];
                        kq.dsHinhHoc[j] = temp;

                    }
                }
            }

            for (int i = 0; i < dsHinhHoc.Count - 1; i++)
            {
                for (int j = i; j < dsHinhHoc.Count; j++)
                {
                    if (dsHinhHoc[i] is HinhTron && dsHinhHoc[j] is HinhTron)
                    {
                        if (kq.dsHinhHoc[j].TinhDT() > dsHinhHoc[i].TinhDT())
                        {
                            temp = kq.dsHinhHoc[i];
                            kq.dsHinhHoc[i] = kq.dsHinhHoc[j];
                            kq.dsHinhHoc[j] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < dsHinhHoc.Count - 1; i++)
            {
                for (int j = i; j < dsHinhHoc.Count; j++)
                {
                    if( !(kq.dsHinhHoc[i] is HinhTron) && !(kq.dsHinhHoc[j] is HinhTron))
                    {
                        if(kq.dsHinhHoc[j].TinhDT() < kq.dsHinhHoc[i].TinhDT())
                        {
                            temp = kq.dsHinhHoc[i];
                            kq.dsHinhHoc[i] = kq.dsHinhHoc[j];
                            kq.dsHinhHoc[j] = temp;
                        }
                    }
                }
            }
            return kq;
        }

        public QuanLyHinhHoc TimHVNhoNhat()
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            float max = 0;
            float min = 0;
            foreach (var hh in dsHinhHoc)
            {
                if (hh.TinhDT() > max)
                    max = hh.TinhDT();
            }
            min = max;
            foreach (var hh in dsHinhHoc)
            {
                if (hh is HinhVuong && !(hh is HinhCN))
                {
                    if (hh.TinhDT() < min)
                        min = hh.TinhDT();
                }
            }

            foreach (var hh in dsHinhHoc)
            {
                if (hh is HinhVuong && !(hh is HinhCN))
                {
                    if (hh.TinhDT() == min)
                    {
                        kq.dsHinhHoc.Add(hh);
                       
                    }

                }
            }
            return kq;
        }

        public void SXTangTheoS()
        {
            HinhHoc a = new HinhHoc();
            for (int i = 0; i < dsHinhHoc.Count - 1; i++)
            {
                for (int j = i; j < dsHinhHoc.Count; j++)
                {
                    if (dsHinhHoc[i].TinhDT() > dsHinhHoc[j].TinhDT())
                    {
                        a = dsHinhHoc[i];
                        dsHinhHoc[i] = dsHinhHoc[j];
                        dsHinhHoc[j] = a;
                    }
                }
            }
        }

        public void SXHinhTron()
        {
            HinhHoc a = new HinhHoc();
            for (int i = 0; i < dsHinhHoc.Count - 1; i++)
            {
                for (int j = i; j < dsHinhHoc.Count; j++)
                {
                    if (dsHinhHoc[i] is HinhTron && dsHinhHoc[j] is HinhTron)
                    {
                        if (dsHinhHoc[i].TinhDT() > dsHinhHoc[j].TinhDT())
                        {
                            a = dsHinhHoc[i];
                            dsHinhHoc[i] = dsHinhHoc[j];
                            dsHinhHoc[j] = a;
                        }
                    }
                }
            }
        }

        public QuanLyHinhHoc TimHinhCoSNhoHonX(float x)
        {
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            foreach (var hh in dsHinhHoc)
            {
                if (hh.TinhDT() < x)
                    kq.dsHinhHoc.Add(hh);
            }
            return kq;
        }

       
        public void SaxXepHinhTG()
        {
            HinhHoc temp;
            for(int i=0;i<dsHinhHoc.Count -1;i++)
            {
                for(int j=i+1;j<dsHinhHoc.Count;j++)
                {
                    if(dsHinhHoc[i] is HinhTG && dsHinhHoc[j] is HinhTG)
                    {
                        if(dsHinhHoc[i].TinhDT() < dsHinhHoc[j].TinhDT() )
                        {
                            temp = dsHinhHoc[i];
                            dsHinhHoc[i] = dsHinhHoc[j];
                            dsHinhHoc[j] = temp;
                        }
                            
                    }
                }
            }
        }

        public void XoaHinhTGCoSNhoNhat()
        {
            float min,max=0;
            

            for (int i = 0; i < dsHinhHoc.Count; i++)
            {
                if(dsHinhHoc[i] is HinhTG)
                {
                    if(dsHinhHoc[i].TinhDT() > max)
                    {
                        max = dsHinhHoc[i].TinhDT();
                    }
                }
            }
            min = max;

            for (int i = 0; i < dsHinhHoc.Count; i++)
            {
                if (dsHinhHoc[i] is HinhTG)
                {
                    if (dsHinhHoc[i].TinhDT() < min)
                    {
                        min = dsHinhHoc[i].TinhDT();
                    }
                }
            }
            for (int i = 0; i < dsHinhHoc.Count; i++)
            {
                if(dsHinhHoc[i] is HinhTG)
                {
                    if(dsHinhHoc[i].TinhDT() == min)
                    {
                        this.dsHinhHoc.RemoveAt(i);
                    }
                }
            }

        }
        public override string ToString()
        {
            string s = "";
            foreach (var hh in dsHinhHoc)
            {
                s = s + hh + "\n";
            }
            return s;
        }

        
    }
}
