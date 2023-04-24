using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _2115229_NguyenNhatLinh_Lab06
{
    class QuanLyMayTinh
    {
        public List<MayTinh> dsMayTinh = new List<MayTinh>();

        public int Count
        {
            get { return dsMayTinh.Count; }
        }

        public MayTinh this[int index]
        {
            get { return this.dsMayTinh[index]; }
             
        }

        public void Them(MayTinh mt)
        {
            this.dsMayTinh.Add(mt);
        }
        public void NhapCD()
        {
            MayTinh mt = new MayTinh("MT02", new DateTime(2020, 10, 13), "Sony");
            mt.ThemTB(new CPU(3.0f, 100));
            mt.ThemTB(new Ram(32, 30));
            Them(mt);

            mt = new MayTinh("MT01", new DateTime(2021, 10, 5), "HP");
            mt.ThemTB(new CPU(3.5f, 200));
            mt.ThemTB(new CPU(5.0f, 500));
            mt.ThemTB(new Ram(32, 30));
            mt.ThemTB(new Ram(128, 100));
            mt.ThemTB(new Ram(32, 50));
            Them(mt);

            mt = new MayTinh("MT03", new DateTime(1999, 12, 1), "LG");
            mt.ThemTB(new CPU(3.0f, 100));
            mt.ThemTB(new CPU(4.0f, 90));
            mt.ThemTB(new Ram(64, 20));
            mt.ThemTB(new Ram(64, 20));
            Them(mt);

            mt = new MayTinh("MT06", new DateTime(1990, 5, 1), "SamSung");
            mt.ThemTB(new CPU(3.0f, 100));
            mt.ThemTB(new Ram(8, 50));
            Them(mt);

            mt = new MayTinh("MT05", new DateTime(2002, 5, 1), "Sharp");
            mt.ThemTB(new CPU(5.0f, 290));
            mt.ThemTB(new CPU(3.5f, 110));
            mt.ThemTB(new CPU(4.0f, 200));
            mt.ThemTB(new Ram(16, 40));
            Them(mt);
        }
        public QuanLyMayTinh()
        {
            this.dsMayTinh = new List<MayTinh>();
        }

        public void SapGiamTheoGia()
        {
            for (int i = 0; i < this.Count - 1; i++)
                for (int j = i + 1; j < this.Count; j++)
                {
                    bool dk = this.dsMayTinh[i].Gia < this.dsMayTinh[j].Gia;
                    if (dk)
                    {
                        MayTinh t = dsMayTinh[i];
                        dsMayTinh[i] = dsMayTinh[j];
                        dsMayTinh[j] = t;
                    }
                }
        }

        public QuanLyMayTinh TimMTCoGiaMax()
        {
            int max = TimMaxMT();
            QuanLyMayTinh kq = new QuanLyMayTinh();
            
            foreach (var mt in dsMayTinh)
            {
                if (mt.Gia == max)
                    kq.dsMayTinh.Add(mt);
            }
            return kq;
        }

        public int TimMaxMT()
        {
            int max = 0;
            foreach (var mt in dsMayTinh)
            {
                if (mt.Gia > max)
                    max = mt.Gia;
            }
            return max;
        }

        

        public QuanLyMayTinh HienThiMTTheoGia(int g)
        {
            QuanLyMayTinh kq = new QuanLyMayTinh();
            foreach(var mt in dsMayTinh)
            {
                if(mt.Gia == g)
                {
                    kq.dsMayTinh.Add(mt);
                }                
            }
            
            return kq;
        }

        public int TongGiaDSMT()
        {
            int s = 0;   
            foreach(var mt in dsMayTinh )
            {
                s = s + mt.Gia;
            }
            return s;
        }

        public void SXDSMTGiamTheoTen()
        {
            for (int i = 0; i < dsMayTinh.Count - 1; i++)
            {
                for (int j = i; j < dsMayTinh.Count; j++)
                {
                    if (string.Compare(dsMayTinh[i].Ten, dsMayTinh[j].Ten) < 0)
                    {
                        MayTinh mt = dsMayTinh[i];
                        dsMayTinh[i] = dsMayTinh[j];
                        dsMayTinh[j] = mt;
                    }
                }
            }
        }

        public void XoaMTTruocNam(int nam)
        {
            for (int i=0;i<dsMayTinh.Count-1;i++)
            {
                if (dsMayTinh[i].NamSX < nam)
                {
                    this.dsMayTinh.RemoveAt(i);
                    i--;
                }
            }
        }

        public QuanLyMayTinh ChenMT(int vitri, MayTinh mt)
        {
            int soRam, soCPU;

            QuanLyMayTinh kq = new QuanLyMayTinh();
            kq.NhapCD();
            Console.WriteLine("Nhap so luong CPU:");
            soCPU = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong Ram:");
            soRam = int.Parse(Console.ReadLine());

            for(int i=0;i<soCPU;i++)
            {
                Console.WriteLine("Nhap CPU thu {0}:",i);
                mt.NhapCPU(mt);
            }

            for(int i=0;i<soRam;i++)
            {
                Console.WriteLine("Nhap Ram thu {0}:",i);
                mt.NhapRam(mt);
            }

            kq.dsMayTinh.Insert(vitri+1, mt);
            return kq;
        }

        public QuanLyMayTinh TimMTCo2Ram()
        {    
            QuanLyMayTinh kq = new QuanLyMayTinh();
           
            foreach (var mt in this.dsMayTinh)
            {
                if (mt.DemRam() == 2)
                    kq.dsMayTinh.Add(mt);
            }
            return kq;
        }

        public int TimRamMAX()
        {
            int max = 0;
            foreach (var mt in dsMayTinh)
            {
                if (mt.TongRam() > max)
                    max = mt.TongRam();

            }
            return max;
        }

        public QuanLyMayTinh TimMTRamMax()
        {
            int max = TimRamMAX();
            QuanLyMayTinh kq = new QuanLyMayTinh();
            
            foreach (var mt in dsMayTinh)
            {
                if (mt.TongRam() == max)
                    kq.dsMayTinh.Add(mt);

            }
            return kq;


        }

        public int TimRamMin()
        {
            int min = int.MaxValue;
            foreach (var mt in dsMayTinh)
            {
                if (mt.TongRam() < min)
                    min = mt.TongRam();

            }
            return min;
        }
        public QuanLyMayTinh TimMTCoRamMin()
        {
            int min = TimRamMin();
            QuanLyMayTinh kq = new QuanLyMayTinh();
            
            foreach (var mt in dsMayTinh)
            {
                if (mt.TongRam() == min)
                    kq.dsMayTinh.Add(mt);

            }
            return kq;
        }

        public float TocDoCPUMax()
        {
            float max = 0;
            foreach (var mt in this.dsMayTinh)
            {
                if (mt.TongTocDoCPU() > max)
                    max = mt.TongTocDoCPU();
            }
            return max;
        }
        public QuanLyMayTinh TimCPUMax()
        {
            QuanLyMayTinh kq = new QuanLyMayTinh();
            float max = TocDoCPUMax();
           
            foreach (var mt in dsMayTinh)
            {
                if (mt.TongTocDoCPU() == max)
                    kq.dsMayTinh.Add(mt);
            }
            return kq;
        }

        public float TocDoCPUMin()
        {
            float min = int.MaxValue;
            foreach (var mt in this.dsMayTinh)
            {
                if (mt.TongTocDoCPU() < min)
                    min = mt.TongTocDoCPU();
            }
            return min;
        }
        public QuanLyMayTinh TimCPUMin()
        {
            QuanLyMayTinh kq = new QuanLyMayTinh();
            float min = TocDoCPUMin();
            
            foreach (var mt in dsMayTinh)
            {
                if (mt.TongTocDoCPU() == min)
                    kq.dsMayTinh.Add(mt);
            }
            return kq;
        }

        public int MTNhieuLKNhat()
        {
            int max = 0;
            foreach (var mt in dsMayTinh)
            {
                if (mt.TongLinhKien() > max)
                    max = mt.TongLinhKien();
            }
            return max;
        }
        public QuanLyMayTinh TimMTCoNhieuLinhKienNhat()
        {
            QuanLyMayTinh kq = new QuanLyMayTinh();
            int max = MTNhieuLKNhat();
            foreach(var mt in dsMayTinh)
            {
                if (mt.TongLinhKien() == max)
                    kq.dsMayTinh.Add(mt);
            }
            return kq;
        }

        public void DocFile()
        {
            StreamReader sr = new StreamReader("dsmaytinh.txt");
            string line;
            MayTinh mt = null;
            
            while ((line = sr.ReadLine()) != null)
            {
                IThietBi tb = new CPU() ;
                string[] parts = line.Split('*');
                if (parts.Contains("MT"))// parts[0] == "MT"
                {
                    if (mt != null)
                        dsMayTinh.Add(mt);
                    mt = new MayTinh(parts[1], DateTime.Parse(parts[3], new CultureInfo("en-US")), parts[2]);
                }
                else if (parts.Contains("CPU"))
                {
                    tb = new CPU(float.Parse(parts[1]), int.Parse(parts[2]));
                   
                }
                else //(parts.Contains("RAM"))
                {
                    tb= new Ram(int.Parse(parts[1]), int.Parse(parts[2]));
                    
                }
                mt.ThemTB(tb);
            }
            if (!dsMayTinh.Contains(mt) && mt != null)
                dsMayTinh.Add(mt);
        }
        public override string ToString()
        {
            string s = String.Format("Danh sach may tinh:\n");
            foreach(var mt in dsMayTinh)
            {
                s = s + "\n\t" + mt;
            }
            return s;
        }

        
    }
}
