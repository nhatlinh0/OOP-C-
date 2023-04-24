using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab07
{
    class menu
    {
        public enum Menu
        {
            Thoat,
            DocFile,
            XuatDSAP,
            TimAPLonNhat,
            TimDSAPCuaNXB,
            HienThiAPTheoGia,
            TongTienDSAP,
            SXDSAPGiamTheoTenVaGia,
            SXDSAPTangTheoTenVaGia,
            TimAPCoGiaThapNhat,
            XoaAPCoGiaThapNhat,
            ChenAP,
        }
        public static void XuatMenu()
        {
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.Thoat, Menu.Thoat);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.DocFile, Menu.DocFile);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.XuatDSAP, Menu.XuatDSAP);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.TimAPLonNhat, Menu.TimAPLonNhat);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.TimDSAPCuaNXB, Menu.TimDSAPCuaNXB);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.HienThiAPTheoGia, Menu.HienThiAPTheoGia);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.TongTienDSAP, Menu.TongTienDSAP);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.SXDSAPGiamTheoTenVaGia, Menu.SXDSAPGiamTheoTenVaGia);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.SXDSAPTangTheoTenVaGia, Menu.SXDSAPTangTheoTenVaGia);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.TimAPCoGiaThapNhat, Menu.TimAPCoGiaThapNhat);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.XoaAPCoGiaThapNhat, Menu.XoaAPCoGiaThapNhat);
            Console.WriteLine("Chon {0} de {1} :", (int)Menu.ChenAP, Menu.ChenAP);
        }
        public static int ChonMenu()
        {
            int stt;
            for (; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.Write("Chon 1 so [{0}..{1}]= ", (int)Menu.Thoat, (int)Menu.ChenAP);
                stt = int.Parse(Console.ReadLine());
                if ((int)Menu.Thoat <= stt && stt <= (int)Menu.ChenAP)
                    break;
            }
            return stt;
        }
        
        public static void XuLyMenu(Menu m)
        {
            int kieu;
            string NXB;
            float gia;
            DanhSachAnPham ds = new DanhSachAnPham();
            DanhSachAnPham kq = new DanhSachAnPham();
            ds.NhapTuFile();
            switch(m)
            {
                case Menu.Thoat:
                    break;
                case Menu.DocFile:
                    Console.WriteLine("Da doc!");
                    break;
                case Menu.XuatDSAP:
                    Console.WriteLine(ds);
                    break;
                case Menu.TimAPLonNhat:
                    kq = ds.TimAPGiaLonNhat();
                    Console.WriteLine(kq);
                    break;
                case Menu.TimDSAPCuaNXB:
                    Console.WriteLine("Nhap ten nha xuat ban:");
                    NXB = Console.ReadLine();
                    kq = ds.TimDSAPCoNXB(NXB);
                    Console.WriteLine(kq);
                    break;
                case Menu.HienThiAPTheoGia:
                    Console.WriteLine("Nhap gia tien:");
                    gia = float.Parse(Console.ReadLine());
                    kq = ds.HienThiAPTheoGia(gia);
                    Console.WriteLine(kq);
                    break;
                case Menu.TongTienDSAP:
                    ds.TongTienDSAP();
                    Console.WriteLine("Tong Tien danh sach an pham: {0}",ds.TongTienDSAP());
                    break;
                case Menu.SXDSAPGiamTheoTenVaGia:
                    Console.WriteLine("Nhap 0 de sap xep giam theo ten, 1 de sap xep giam theo gia");
                    kieu = int.Parse(Console.ReadLine());
                    ds.ChonKieuSXDelegate((KieuSapXep)kieu);
                    Console.WriteLine(ds) ;
                    break;
                case Menu.SXDSAPTangTheoTenVaGia:
                    Console.WriteLine("Nhap 0 de sap xep tang theo ten, 1 de sap xep tang theo gia:");
                    kieu = int.Parse(Console.ReadLine());
                    ds.kieusx = (KieuSapXep)kieu;
                    ds.SapXepComparer();
                    Console.WriteLine(ds);
                    break;
                case Menu.TimAPCoGiaThapNhat:
                    kq = ds.TimAPCoGiaThapNhat();
                    Console.WriteLine(kq);
                    break;
                case Menu.XoaAPCoGiaThapNhat:
                    ds.XoaAPCoGiaThapNhat();
                    Console.WriteLine(ds);
                    break;
                case Menu.ChenAP:
                    Console.WriteLine("Nhap 0 de chen Bao, 1 de chen tap chi, 2 de chen sach:");
                    kieu = int.Parse(Console.ReadLine());
                    ds.ChenLoaiAnPham((KieuAnPham)kieu);
                    Console.WriteLine(ds) ;
                    break;
            }
            Console.ReadKey();
        }
    }
}
