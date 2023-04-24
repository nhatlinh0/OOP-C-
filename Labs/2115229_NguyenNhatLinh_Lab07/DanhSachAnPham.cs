using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2115229_NguyenNhatLinh_Lab07
{
    delegate int SoSanh(object x, object y);
    public enum KieuSapXep
    {
        TangTheoTen,
        TangTheoGia,
        GiamTheoNam,
    }
    public enum KieuAnPham
    {
        Bao,
        TapChi,
        Sach,
    }

    class DanhSachAnPham : List<IAnPham>, IComparer<IAnPham>
    {
        public List<IAnPham> Collection = new List<IAnPham>();

       
    

        public void NhapTuFile()
        {
            string filename = "dsanpham.txt";
            StreamReader sr = new StreamReader(filename);
            string line = "";
            while((line =sr.ReadLine()) != null)
            {
                string[] ss = line.Split(',');
                if(ss[0]=="Sach")
                {
                    Collection.Add(new Sach(line));
                }
                if (ss[0] == "Tap chi")
                {
                    Collection.Add(new TapChi(line));
                }
                if (ss[0] == "Bao")
                {
                    Collection.Add(new Bao(line));
                }
            }

        }

        public float AnPhamGiaMax()
        {
            float max = 0;
            foreach(var item in Collection)
            {
               if(item.GiaTien > max)
                {
                    max = item.GiaTien;
                }

            }
            return max;
        }
        public float AnPhamGiaMin()
        {
            float min = float.MaxValue;
            foreach (var item in Collection)
            {
                if (item.GiaTien < min)
                {
                    min = item.GiaTien;
                }

            }
            return min;
        }

        public DanhSachAnPham TimAPGiaLonNhat()
        {
            float max = AnPhamGiaMax();
            DanhSachAnPham kq = new DanhSachAnPham();
            
            
            foreach(var item in Collection)
            {
                if(item.GiaTien == max )
                {
                    kq.Collection.Add(item);
                }
            }
            return kq;
        }

        public DanhSachAnPham TimDSAPCoNXB(string NXB)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach(var item in Collection)
            {
                if (String.Compare(item.NhaXuatBan, NXB) == 0)
                {
                    kq.Collection.Add(item);
                }
            }
            return kq;

        }

         public DanhSachAnPham HienThiAPTheoGia(float gia)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var item in Collection)
            {
                if (item.GiaTien == gia)
                {
                    kq.Collection.Add(item);
                }
            }
            return kq;
        }

        public float TongTienDSAP()
        {
            float sum = 0;
            foreach(var item in Collection)
            {
                
                    sum = sum + item.GiaTien;
            }
            return sum;
        }

        public DanhSachAnPham TimAPCoGiaThapNhat()
        {
            DanhSachAnPham kq = new DanhSachAnPham();

            foreach(var item in Collection)
            {
                if(item.GiaTien == AnPhamGiaMin())
                {
                    kq.Collection.Add(item);
                }
            }
            return kq;
        }

        public void XoaAPCoGiaThapNhat()
        {
            int vt=0;
            for (int i = 0; i < Collection.Count; i++)
            {
                if (Collection[i].GiaTien == AnPhamGiaMin())
                    vt = i;
            }
            Collection.RemoveAt(vt);
        }

        public void ChenAnPham(int vt, IAnPham a)
        {
            Collection.Insert(vt, a); 
        }

        public void ChenLoaiAnPham(KieuAnPham k)
        {
            int vt = 0;
            Bao a = new Bao();
            TapChi b = new TapChi();
            Sach c = new Sach();
            switch (k)
            {
                case KieuAnPham.Bao:
                    
                    a.Nhap();
                    Console.WriteLine("Nhap vi tri can chen:");
                    vt = int.Parse(Console.ReadLine());
                    ChenAnPham(vt,a);
                    break;
                case KieuAnPham.TapChi:
                    b.Nhap();
                    Console.WriteLine("Nhap vi tri can chen:");
                    vt = int.Parse(Console.ReadLine());
                    ChenAnPham(vt, b);
                    break;
                case KieuAnPham.Sach:
                    c.Nhap();
                    Console.WriteLine("Nhap vi tri can chen:");
                    vt = int.Parse(Console.ReadLine());
                    ChenAnPham(vt, c);
                    break;
            }

        }
        public KieuSapXep kieusx;
        public int Compare(IAnPham x, IAnPham y)
        {
            
            switch (kieusx)
            {
                case KieuSapXep.TangTheoGia:
                    return x.GiaTien.CompareTo(y.GiaTien);
                    
                case KieuSapXep.TangTheoTen:
                    return x.Ten.CompareTo(y.Ten);
                   
                   
            }
            return x.GiaTien.CompareTo(y.GiaTien);

        }

        public void SapXepDelegate(SoSanh ss)
        {
            for(int i=0;i<Collection.Count-1;i++)
            {
                for(int j=i;j<Collection.Count;j++)
                {
                    if(ss(Collection[i], Collection[j]) == 1)
                    {
                        IAnPham temp = Collection[i];
                        Collection[i] = Collection[j];
                        Collection[j] = temp;
                    }
                }
            }
        }
        public static int SapXepGia(object x, object y)
        {
            IAnPham a = (IAnPham)x;
            IAnPham b = (IAnPham)y;
            return -a.GiaTien.CompareTo(b.GiaTien);
        }
        public static int SapXepTen(object x, object y)
        {
            IAnPham a = (IAnPham)x;
            IAnPham b = (IAnPham)y;
            return -a.Ten.CompareTo(b.Ten);
        }
        public void SapXepComparer()
        {
            this.Collection.Sort(this);
        }

        public void ChonKieuSXDelegate(KieuSapXep k)
        {
            switch(k)
            {
                case KieuSapXep.TangTheoTen:
                    SapXepDelegate(SapXepTen);
                    break;
                case KieuSapXep.TangTheoGia:
                    SapXepDelegate(SapXepGia);
                    break;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach(var item in Collection)
            {
                s = s + item + "\n";
            }
            return s;
        }
    }
}
