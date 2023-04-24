using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab03
{
    
    class Menu
    {

       

        public enum menu
        {
            Thoat,
            TaoQuanLySV,
            ThemSV,
            NhapDSSV,
            NhapCoDinh,
            XuatDSSV,
            TinhTBC,
            TimTheoTen,
            TimSVCoDiemTBMax,
            TimDSSVCoTenX,
            ThongKeSVKhongDat,
            SapXepDSSV,
            SapXepDSSVGiamDanTheoChieuDaiHoTen,
            SapXepDSSVGiamDanTheoDiemTB,
            ChenSV,
            XoaSV,
            XoaSVDauTienCoTenX,
            XoaTatCaSVCoTenX,

        }

        static public void XuatMenu()
        {
            Console.WriteLine("=================================== MENU ==================================");
            Console.WriteLine("Chon {0} de {1}", (int)menu.Thoat, menu.Thoat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TaoQuanLySV, menu.TaoQuanLySV);
            Console.WriteLine("Chon {0} de {1}", (int)menu.ThemSV, menu.ThemSV);
            Console.WriteLine("Chon {0} de {1}", (int)menu.NhapDSSV, menu.NhapDSSV);
            Console.WriteLine("Chon {0} de {1}", (int)menu.NhapCoDinh, menu.NhapCoDinh);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XuatDSSV, menu.XuatDSSV);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TinhTBC, menu.TinhTBC);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimTheoTen, menu.TimTheoTen);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimSVCoDiemTBMax, menu.TimSVCoDiemTBMax);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimDSSVCoTenX, menu.TimDSSVCoTenX);
            Console.WriteLine("Chon {0} de {1}", (int)menu.ThongKeSVKhongDat, menu.ThongKeSVKhongDat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SapXepDSSV, menu.SapXepDSSV);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SapXepDSSVGiamDanTheoChieuDaiHoTen, menu.SapXepDSSVGiamDanTheoChieuDaiHoTen);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SapXepDSSVGiamDanTheoDiemTB, menu.SapXepDSSVGiamDanTheoDiemTB);
            Console.WriteLine("Chon {0} de {1}", (int)menu.ChenSV, menu.ChenSV);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaSV, menu.XoaSV);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaSVDauTienCoTenX, menu.XoaSVDauTienCoTenX);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaTatCaSVCoTenX, menu.XoaTatCaSVCoTenX);
            Console.WriteLine("===========================================================================");


        }

        static public int ChonMenu()
        {
            int stt;
            for (; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.Write("Nhap 1 so tu [{0}..{1}]=", (int)menu.Thoat, (int)menu.XoaTatCaSVCoTenX);
                stt = int.Parse(Console.ReadLine());
                if ((int)menu.Thoat <= stt && stt <= (int)menu.XoaTatCaSVCoTenX)
                    break;
            }
            return stt;
        }

        static public void XuLyMenu(menu m)
        {
            string ten = "";
            string ms = "";
            string Ten="";
            int vt = 0;
            QuanLySInhVien ql = new QuanLySInhVien();
            ql.NhapCoDinh();
            QuanLySInhVien kq2 = new QuanLySInhVien();
            SinhVien a = new SinhVien();
            float kq;
            switch (m)
            {
                case menu.Thoat:
                    break;

                case menu.TaoQuanLySV:
                    ql = new QuanLySInhVien();
                    Console.WriteLine("Tao lap thanh cong");
                    break;

                case menu.ThemSV:
                    a.Nhap();
                    ql.Them(a);
                    ql.XuatDSSV();
                    break;

                case menu.NhapDSSV:
                    ql.NhapDSSV();
                    ql.XuatDSSV();
                    break;

                case menu.NhapCoDinh:
                    Console.Clear();
                   
                    ql.XuatDSSV();
                    break;
           
                case menu.XuatDSSV:
                   
                    ql.XuatDSSV();
                    break;
                case menu.TinhTBC:
                    Console.Clear();
                  
                    kq = ql.DiemTBC();
                    Console.WriteLine("Diem trung binh cong la: {0}", kq);
                    break;
                case menu.TimTheoTen:
                    Console.WriteLine("Nhap Ten sinh vien:");
                    Ten = Console.ReadLine();
                    kq2 = ql.TimSVTheoTen(Ten);
                    kq2.XuatDSSV();
                    break;
                case menu.TimSVCoDiemTBMax:
                    
                    Console.WriteLine("Sinh vien co diem trung binh max la:");
                    kq2 = ql.TimSVCoDTBMax();
                    kq2.XuatDSSV();
                    break;
                case menu.TimDSSVCoTenX:
                    Console.WriteLine("Nhap Ten sinh vien:");
                    Ten = Console.ReadLine();
                    kq2 = ql.TimSVTheoTenX(Ten);
                    kq2.XuatDSSV();
                    break;
                   
                case menu.ThongKeSVKhongDat:
                    kq2 = ql.ThongKeSVKhongDat();
                    Console.WriteLine("Danh sach sinh vien khong dat: ");
                    kq2.XuatDSSV();
                    break;
                case menu.SapXepDSSV:
                    Console.WriteLine("Danh sach sinh vien ban dau: ");
                    ql.XuatDSSV();
                    ql.SXTangTheoTen();
                    Console.WriteLine("Danh sach sinh vien da sap xep: ");
                    ql.XuatDSSV();
                    break;
                case menu.SapXepDSSVGiamDanTheoChieuDaiHoTen:
                    Console.WriteLine("Danh sach sinh vien ban dau: ");
                    ql.XuatDSSV();
                    ql.SXGiamDanChieuDaiHoTen();
                    Console.WriteLine("Danh sach sinh vien da sap xep: ");
                    ql.XuatDSSV();
                    break;
                case menu.SapXepDSSVGiamDanTheoDiemTB:
                    Console.WriteLine("Danh sach sinh vien ban dau: ");
                    ql.XuatDSSV();
                    ql.SXGiamDanTheoDTB();
                    Console.WriteLine("Danh sach sinh vien da sap xep: ");
                    ql.XuatDSSV();
                    break;
                case menu.ChenSV:
                    Console.WriteLine("Nhap SV can chen:");

                    a.Nhap();
                    Console.WriteLine("Nhap vi tri can chen:");
                    vt = int.Parse(Console.ReadLine());

                    ql.ChenSV(vt,a);
                    ql.XuatDSSV();
                    break;
                case menu.XoaSV:
                    Console.WriteLine("Nhap ma so sinh vien can xoa: ");
                    ms = Console.ReadLine();
                    Console.WriteLine("Danh sach sinh vien ban dau: ");
                    ql.XuatDSSV();
                    ql.XoaSVTheoMaSo(ms);
                    Console.WriteLine("Danh sach sinh vien sau khi xoa: ");
                    ql.XuatDSSV();
                    break;
                case menu.XoaSVDauTienCoTenX:
                    Console.WriteLine("Nhap ten sinh vien can xoa: ");
                    ten = Console.ReadLine();
                    Console.WriteLine("Danh sach sinh vien ban dau: ");
                    ql.XuatDSSV();
                    ql.XoaSVDauTienCoTenX(ten);
                    Console.WriteLine("Danh sach sinh vien sau khi xoa: ");
                    ql.XuatDSSV();
                    break;
                case menu.XoaTatCaSVCoTenX:
                    Console.WriteLine("Nhap ten sinh vien can xoa: ");
                    ten = Console.ReadLine();
                    Console.WriteLine("Danh sach sinh vien ban dau: ");
                    ql.XuatDSSV();
                    ql.XoaTatCaSVTenX(ten);
                    Console.WriteLine("Danh sach sinh vien sau khi xoa: ");
                    ql.XuatDSSV();
                    break;
            }
            Console.ReadKey();
        }

    }
}
