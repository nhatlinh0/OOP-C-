using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab05
{
    class Menu
    {
        public enum menu
        {
            Thoat,
            NhapCD,
            XuatDSHH,
            TimSLonNhat,
            TimHVNhoNhat,
            SXTangS,
            TongSHinhTron,
            SXHinhTronTangTheoS,
            XuatDSNhoHonX,
            DemSoLuongHinhTheoLoaiHinh,
            XoaTatCaHinhTheoLoaiHinh,
            ChenHinhTron,
            XoaHinhVuongCoSNhoNhat,
            SapXepTheoYeuCau,
            SapXepHinhTG,
            XoaTGNhoNhat,

        }

        public static void XuatMenu()
        {
            Console.WriteLine("Chon {0} de {1}", (int)menu.Thoat, menu.Thoat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.NhapCD, menu.NhapCD);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XuatDSHH, menu.XuatDSHH);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimSLonNhat, menu.TimSLonNhat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimHVNhoNhat, menu.TimHVNhoNhat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SXTangS, menu.SXTangS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TongSHinhTron, menu.TongSHinhTron);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SXHinhTronTangTheoS, menu.SXHinhTronTangTheoS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XuatDSNhoHonX, menu.XuatDSNhoHonX);
            Console.WriteLine("Chon {0} de {1}", (int)menu.DemSoLuongHinhTheoLoaiHinh, menu.DemSoLuongHinhTheoLoaiHinh);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaTatCaHinhTheoLoaiHinh, menu.XoaTatCaHinhTheoLoaiHinh);
            Console.WriteLine("Chon {0} de {1}", (int)menu.ChenHinhTron, menu.ChenHinhTron);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaHinhVuongCoSNhoNhat, menu.XoaHinhVuongCoSNhoNhat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SapXepTheoYeuCau, menu.SapXepTheoYeuCau);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SapXepHinhTG, menu.SapXepHinhTG);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaTGNhoNhat, menu.XoaTGNhoNhat);
        }

        public static int ChonMenu()
        {
            int stt;
            for (; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.WriteLine("Chon 1 so [{0}..{1}]=", (int)menu.Thoat, (int)menu.XoaTGNhoNhat);
                stt = int.Parse(Console.ReadLine());
                if ((int)menu.Thoat <= stt && stt <= (int)menu.XoaTGNhoNhat)
                    break;
            }
            return stt;
        }

        public static void XuLyMenu(menu m)
        {
            QuanLyHinhHoc ql = new QuanLyHinhHoc();
            QuanLyHinhHoc kq = new QuanLyHinhHoc();
            float x;
            ql.NhapCD();
            switch (m)
            {
                case menu.Thoat:
                    break;
                case menu.NhapCD:
                    break;
                case menu.XuatDSHH:
                    Console.WriteLine(ql);
                    break;
                case menu.TimSLonNhat:
                    kq = ql.TimSLonNhat();
                    Console.WriteLine(kq);
                    break;
                case menu.TimHVNhoNhat:
                    kq = ql.TimHVNhoNhat();
                    Console.WriteLine(kq);
                    break;
                case menu.SXTangS:
                    ql.SXTangTheoS();
                    Console.WriteLine(ql);
                    break;
                case menu.TongSHinhTron:
                    Console.WriteLine("Tong dien tich hinh tron: {0}", ql.TongDT());

                    break;
                case menu.SXHinhTronTangTheoS:
                    ql.SXHinhTron();
                    Console.WriteLine(ql);
                    break;
                case menu.XuatDSNhoHonX:
                    Console.WriteLine("Nhap X:");
                    x = float.Parse(Console.ReadLine());
                    kq = ql.TimHinhCoSNhoHonX(x);
                    Console.WriteLine(kq);
                    break;
                case menu.DemSoLuongHinhTheoLoaiHinh:
                    int a;
                    int dem;
                    Console.WriteLine("Ban muon dem hinh gi? Chon so (0. Tatca, 1.HinhTron, 2.HinhVuong, 3. HinhCN)");
                    a = int.Parse(Console.ReadLine());
                    dem = ql.DemHinh((LoaiHinh)a);
                    Console.WriteLine("Co {0} {1}", Enum.GetName(typeof(LoaiHinh), a), dem);

                    break;
                case menu.XoaTatCaHinhTheoLoaiHinh:
                    
                    Console.WriteLine("Ban muon xoa hinh gi? Chon so (0. Tatca, 1.HinhTron, 2.HinhVuong, 3. HinhCN)");
                    a = int.Parse(Console.ReadLine());
                    kq = ql.XoaTheoLoaiHinh((LoaiHinh)a);
                    Console.WriteLine(kq);
                    break;
                case menu.ChenHinhTron:
                    float c;
                    Console.WriteLine("Nhap canh hinh tron:");
                    c = float.Parse(Console.ReadLine());
                    HinhTron ht = new HinhTron(c);
                    kq = ql.ChenHinhTron((HinhTron)ht);
                    Console.WriteLine(kq) ;
                    break;
                case menu.XoaHinhVuongCoSNhoNhat:
                    kq = ql.XoaHinhVuongNhoNhat();
                    Console.WriteLine(kq) ;
                    break;
                case menu.SapXepTheoYeuCau:
                    kq = ql.SXTheoYeuCau();
                    Console.WriteLine(kq) ;
                    break;
                case menu.SapXepHinhTG:
                    ql.SaxXepHinhTG();
                    Console.WriteLine(ql) ;
                    break;
                case menu.XoaTGNhoNhat:
                    ql.XoaHinhTGCoSNhoNhat();
                    Console.WriteLine(ql); 
                    break;
            }
            Console.ReadKey();
        }
    }
}
