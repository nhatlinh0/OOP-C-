using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab06
{
    class Menu
    {
        public enum menu
        {
            Thoat,
            NhapDSMT,
            XuatDSMT,
            TimMTCoGiaLonNhat,
            TimDSMTCo2Ram,
            HienThiMTTheoGia,
            TinhTongGiaDSMT,
            SXDSMTGiamTheoTen,
            TimMTCoRamMaxMin,
            TimMTCoCPUMaxMin,
            TimMTCoNhieuLinhKienNhat,
            XoaMTSXTruoc2000,
            ChenMT,
            NhapDSMTTuFile,

        }

        static public void XuatMenu()
        {
            Console.WriteLine("Chon {0} de {1}", (int)menu.Thoat, menu.Thoat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.NhapDSMT, menu.NhapDSMT);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XuatDSMT, menu.XuatDSMT);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimMTCoGiaLonNhat, menu.TimMTCoGiaLonNhat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimDSMTCo2Ram, menu.TimDSMTCo2Ram);
            Console.WriteLine("Chon {0} de {1}", (int)menu.HienThiMTTheoGia, menu.HienThiMTTheoGia);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TinhTongGiaDSMT, menu.TinhTongGiaDSMT);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SXDSMTGiamTheoTen, menu.SXDSMTGiamTheoTen);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimMTCoRamMaxMin, menu.TimMTCoRamMaxMin);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimMTCoCPUMaxMin, menu.TimMTCoCPUMaxMin);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimMTCoNhieuLinhKienNhat, menu.TimMTCoCPUMaxMin);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaMTSXTruoc2000, menu.XoaMTSXTruoc2000);
            Console.WriteLine("Chon {0} de {1}", (int)menu.ChenMT, menu.ChenMT);
            Console.WriteLine("Chon {0} de {1}", (int)menu.NhapDSMTTuFile, menu.NhapDSMTTuFile);
        }
        static public int ChonMenu()
        {
            int stt;
            for(; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.WriteLine("Chon 1 so [{0}..{1}]= ", (int)menu.Thoat, (int)menu.NhapDSMTTuFile);
                stt = int.Parse(Console.ReadLine());
                if ((int)menu.Thoat <= stt && stt <= (int)menu.NhapDSMTTuFile)
                    break;
            }
            return stt;
    
        }

        static public void XuLyMenu(menu m)         
        {
            QuanLyMayTinh ql = new QuanLyMayTinh();
            QuanLyMayTinh kq = new QuanLyMayTinh();
            ql.NhapCD();
            switch (m)
            {
                case menu.Thoat:
                    break;
                case menu.NhapDSMT:
                    Console.WriteLine("Nhap co dinh:");
                    ql.NhapCD();
                    Console.WriteLine(ql);

                    break;
                case menu.XuatDSMT:
                    Console.WriteLine("Xuat danh sach may tinh:");
                    Console.WriteLine(ql) ;
                    break;
                case menu.TimMTCoGiaLonNhat:
                    Console.WriteLine("May tinh co gia lon nhat:");
                    kq = ql.TimMTCoGiaMax();
                    Console.WriteLine(kq);
                    break;
                case menu.TimDSMTCo2Ram:
                    Console.WriteLine("Tim may tinh co 2 thanh ram:");
                    kq = ql.TimMTCo2Ram();
                    Console.WriteLine(kq);
                    break;
                case menu.HienThiMTTheoGia:
                    int g;
                    Console.WriteLine("Nhap gia:");
                    g = int.Parse(Console.ReadLine());
                    kq = ql.HienThiMTTheoGia(g);
                    if (kq.dsMayTinh.Count == 0)
                        Console.WriteLine("Khong co may tinh co gia {0}", g);
                    else Console.WriteLine(kq) ;
                    break;
                case menu.TinhTongGiaDSMT:
                    Console.WriteLine("Tong gia danh sach may tinh: {0}",ql.TongGiaDSMT());
                    
                    break;
                case menu.SXDSMTGiamTheoTen:
                    Console.WriteLine("Danh sach truoc khi sap xep:");
                    Console.WriteLine(ql);
                    ql.SXDSMTGiamTheoTen();
                    Console.WriteLine("Danh sach sau khi sap xep:");
                    Console.WriteLine(ql);
                    break;
                case menu.TimMTCoRamMaxMin:
                    Console.WriteLine("May tinh co gia ram cao nhat:");
                    kq = ql.TimMTCoGiaMax();
                    Console.WriteLine(kq);
                    Console.WriteLine("May tinh co gia ram thap nhat:");
                    kq = ql.TimMTCoRamMin();
                    Console.WriteLine(kq);
                    break;
                case menu.TimMTCoCPUMaxMin:
                    Console.WriteLine("May tinh co CPU cao nhat:");
                    kq = ql.TimCPUMax();
                    Console.WriteLine(kq);
                    Console.WriteLine("May tinh co CPU thap nhat:");
                    kq = ql.TimCPUMin();
                    Console.WriteLine(kq);
                    break;
                case menu.TimMTCoNhieuLinhKienNhat:
                    Console.WriteLine("Tim may tinh co nhieu linh kien nhat");
                    kq = ql.TimMTCoNhieuLinhKienNhat();
                    Console.WriteLine(kq);
                    break;
                case menu.XoaMTSXTruoc2000:
                    Console.WriteLine("Xoa may tinh san xuat truoc nam 2000");
                    Console.WriteLine("Danh sach truoc khi xoa:");
                    Console.WriteLine(ql);
                    Console.WriteLine("Danh sach sau khi xoa:");
                    ql.XoaMTTruocNam(2000);
                    Console.WriteLine(ql);
                    
                    break;
                case menu.ChenMT:
                    int vt;
                    string ms;
                    DateTime ngay;
                    string ten;


                    Console.WriteLine("Danh sach truoc khi chen:");
                    Console.WriteLine(ql);
                    
                    Console.WriteLine("Nhap ma so:");
                    ms = Console.ReadLine();
                    Console.WriteLine("Nhap ngay thang nam sx:");
                    ngay = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap ten may tinh:");
                    ten = Console.ReadLine();
                    Console.WriteLine("Nhap vi tri can chen:");
                    MayTinh mt = new MayTinh(ms, ngay, ten);
                    vt = int.Parse(Console.ReadLine());


                    

                    kq = ql.ChenMT(vt, mt);
                    Console.WriteLine("Danh sach sau khi chen:");
                    Console.WriteLine("\n"+kq+"\n");
                    break;
                case menu.NhapDSMTTuFile:
                    ql.DocFile();
                    Console.WriteLine( ql);
                    break;
            }
            Console.ReadKey();
        }
    }
}
