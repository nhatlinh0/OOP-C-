using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab03
{
    class QuanLySInhVien
    {
        public SinhVien[] dsSinhVien;
        private int soSV;

        public int SoSV
        {
            get { return soSV; }
            set
            {
                soSV = value;
            }
        }

        public QuanLySInhVien()
        {
            this.dsSinhVien = new SinhVien[100];
            this.SoSV = 0;
        }

        public void Them( SinhVien sv)
        {
            this.dsSinhVien[SoSV++]= sv;
        }

       
        public void NhapDSSV()
        {
           
            Console.WriteLine("Nhap so luong sinh vien:");
            SoSV = int.Parse(Console.ReadLine());
            for(int i=0;i<this.SoSV;i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}:", i);
                this.dsSinhVien[i] = new SinhVien();
                this.dsSinhVien[i].Nhap();
            }
        }

        public void NhapCoDinh()
        {
            this.Them(new SinhVien ("2130302", "Tran Van Anh", new DateTime(2000, 8, 23), 7.4f));
            this.Them(new SinhVien("2003344", "Nguyen Thi Ly", new DateTime(2001, 3, 4), 6.0f));
            this.Them(new SinhVien("2134545", "Le Van Nguyet", new DateTime(2005, 8, 29),8.0f));
            this.Them(new SinhVien("2111111", "Nguyen Hung",   new DateTime(1998, 10, 15),3.5f));
            this.Them(new SinhVien("2143322", "Nguyen Van Anh",new DateTime(2000, 2, 5),8.0f));
            this.Them(new SinhVien("2143326", "Nguyen Van Tu", new DateTime(2000, 5, 5), 6.3f));
            this.Them(new SinhVien("2134546", "Le Van Luyen",  new DateTime(2001, 7, 21), 8.1f));
            this.Them(new SinhVien("2003347", "Le Viet Quang", new DateTime(2003, 9, 4), 5.6f));
            this.Them(new SinhVien("2003348", "Nguyen Thi Lan",new DateTime(1999, 3, 7), 1.0f));
            this.Them(new SinhVien("2003245", "Le Mai Huong",  new DateTime(2009, 5, 22), 2.0f));
            this.Them(new SinhVien("2234545", "Le Thi Nguyet", new DateTime(2008, 1, 29), 5.0f));


        }

        public QuanLySInhVien TimSVTheoTen(string Ten)
        {
            QuanLySInhVien kq = new QuanLySInhVien();
            for(int i=0;i<this.SoSV;i++)
            {
                if (Ten.CompareTo(dsSinhVien[i].Ten) == 0)
                     kq.Them(dsSinhVien[i]);

            }
            return kq;
        }

        public QuanLySInhVien TimSVCoDTBMax()
        {
            float max = dsSinhVien[0].DiemTB;
            QuanLySInhVien kq = new QuanLySInhVien();
            for(int i=1;i<SoSV;i++)
            {
                if (dsSinhVien[i].DiemTB > max)
                    max = dsSinhVien[i].DiemTB;
            }

            for (int i = 1; i < SoSV; i++)
            {
                if (dsSinhVien[i].DiemTB == max)
                    kq.Them(dsSinhVien[i]);
            }
            return kq;
        }

        public QuanLySInhVien TimSVTheoTenX(string Ten)
        {
            QuanLySInhVien kq = new QuanLySInhVien();
            for (int i = 0; i < this.SoSV; i++)
            {
                if (Ten.CompareTo(dsSinhVien[i].Ten) == 0)
                    kq.Them(dsSinhVien[i]);

            }
            if (kq.SoSV == 0)
                Console.WriteLine("Khong co sinh vien ten {0}", Ten);
            return kq;
        }

        public QuanLySInhVien ThongKeSVKhongDat()
        {
            QuanLySInhVien kq = new QuanLySInhVien();
            for(int i=0;i<SoSV;i++)
            {
                if (dsSinhVien[i].DiemTB < 5.5f)
                    kq.Them(dsSinhVien[i]);
            }
            return kq;
        }

        public void SXTangTheoTen()
        {
            SinhVien sv = new SinhVien();
            for(int i=0;i<this.SoSV-1;i++)
            {
                for(int j=i+1;j<this.SoSV;j++)
                {
                    if (dsSinhVien[i].Ten.CompareTo(dsSinhVien[j].Ten) > 0)
                    {

                        sv = dsSinhVien[i];
                        dsSinhVien[i] = dsSinhVien[j];
                        dsSinhVien[j] = sv;
                    }


                }
            }
        }

        public void SXGiamDanChieuDaiHoTen()
        {
            SinhVien sv = new SinhVien();
            for(int i=0;i<this.SoSV-1;i++)
            {
                for(int j=i+1;j<this.SoSV;j++)
                {
                    if (dsSinhVien[i].HoTen.Length < dsSinhVien[j].HoTen.Length)
                    { 
                        sv = dsSinhVien[i];
                        dsSinhVien[i] = dsSinhVien[j];
                        dsSinhVien[j] = sv;
                    }

                }
            }
        }

        public void SXGiamDanTheoDTB()
        {
            SinhVien sv = new SinhVien();
            for(int i=0; i<SoSV-1;i++)
            {
                for(int j=i+1;j<SoSV;j++)
                {
                    if(dsSinhVien[i].DiemTB < dsSinhVien[j].DiemTB)
                    {
                        sv = dsSinhVien[i];
                        dsSinhVien[i] = dsSinhVien[j];
                        dsSinhVien[j] = sv;
                    }

                    if (dsSinhVien[i].DiemTB == dsSinhVien[j].DiemTB)
                    {
                        if (dsSinhVien[i].Ho.CompareTo(dsSinhVien[j].Ho) < 0)
                        {
                            sv = dsSinhVien[i];
                            dsSinhVien[i] = dsSinhVien[j];
                            dsSinhVien[j] = sv;
                        }
                    }
                }
            }
        }

        public void ChenSV(int vt, SinhVien sv)
        {
            for(int i=SoSV-1;i >= vt;i--)
            {
                dsSinhVien[i+1] = dsSinhVien[i];
            }
            dsSinhVien[vt] = sv;
            SoSV++;
        }

        public void XoaSV(int vt)
        {
            for (int i = vt; i < SoSV; i++) 
            {
                dsSinhVien[i] = dsSinhVien[i + 1];
            }
            SoSV--;
        }

        public void XoaSVTheoMaSo(string ms)
        {
            for(int i=0;i<SoSV;i++)
            {
                if (dsSinhVien[i].MaSV.CompareTo(ms) == 0)
                    XoaSV(i);
            }
        }

        public void XoaSVDauTienCoTenX(string ten)
        {
            for (int i = 0; i < SoSV; i++)
            {
                if (dsSinhVien[i].Ten.CompareTo(ten) == 0)
                {
                    XoaSV(i);
                    break;
                }

            }
        }

        public void XoaTatCaSVTenX(string ten)
        {
            for (int i = 0; i < SoSV; i++)
            {
                if (dsSinhVien[i].Ten.CompareTo(ten) == 0)
                {
                    XoaSV(i);
                   
                }

            }
        }

        public void XuatDSSV()
        {
            Console.WriteLine("|{0}|  {1}", "STT".PadRight(10), "SINHVIEN".PadLeft(30));
            XuatKeNgang(); 
            for (int i = 0; i < this.SoSV; i++)
            {
                Console.WriteLine("|{0}|  {1}", i.ToString().PadRight(10), this.dsSinhVien[i].ToString().PadLeft(55));
            }
        }

        public void XuatKeNgang()
        {
            for(int i=1;i<80;i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public float DiemTBC()
        {
            float kq = 0;
            
            for(int i=0;i<this.SoSV;i++)
            {
                kq = kq + dsSinhVien[i].DiemTB;
                
            }
            kq = kq / this.SoSV;
            return kq;
        }

        
        
           
    }
}
