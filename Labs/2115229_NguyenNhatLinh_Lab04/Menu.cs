using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2115229_NguyenNhatLinh_Lab04
{
    internal class Menu
    {
        public enum menu
        {
            Thoat,
            DongGoiInDex,
            TaoLapQLPS,
            ThemPS,
            NhapDSPS,
            NhapCoDinh,
            DocFile,
            XuatDSPS,
            RutGonDSPS,
            TimDSPSCoMau,
            TimDSPSBangX,
            TongDSPS,
            TimDSPSMax,
            SapXepDSPSTang,
            SapXepDSPSGiam,
            ChenPS,
            XoaPSNhoNhat,
            XoaTatCaPSNhoNhat,

        }

        public static void XuatMenu()
        {
            Console.WriteLine("===================HE THONG MENU==================");
            Console.WriteLine("Chon {0} de {1}", (int)menu.Thoat, menu.Thoat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.DongGoiInDex, menu.DongGoiInDex);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TaoLapQLPS, menu.TaoLapQLPS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.ThemPS, menu.ThemPS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.NhapDSPS, menu.NhapDSPS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.NhapCoDinh, menu.NhapCoDinh);
            Console.WriteLine("Chon {0} de {1}", (int)menu.DocFile, menu.DocFile);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XuatDSPS, menu.XuatDSPS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.RutGonDSPS, menu.RutGonDSPS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimDSPSCoMau, menu.TimDSPSCoMau);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimDSPSBangX, menu.TimDSPSBangX);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TongDSPS, menu.TongDSPS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.TimDSPSMax, menu.TimDSPSMax);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SapXepDSPSTang, menu.SapXepDSPSTang);
            Console.WriteLine("Chon {0} de {1}", (int)menu.SapXepDSPSGiam, menu.SapXepDSPSGiam);
            Console.WriteLine("Chon {0} de {1}", (int)menu.ChenPS, menu.ChenPS);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaPSNhoNhat, menu.XoaPSNhoNhat);
            Console.WriteLine("Chon {0} de {1}", (int)menu.XoaTatCaPSNhoNhat, menu.XoaTatCaPSNhoNhat);
            Console.WriteLine("====================================================");

        }

        public static int ChonMenu()
        {
            int stt;
            for(; ; )
            {
                Console.Clear();
                XuatMenu();
                Console.WriteLine("Nhap mot so[{0}..{1}]",(int)menu.Thoat, (int)menu.XoaTatCaPSNhoNhat);
                stt=int.Parse(Console.ReadLine());
                if ((int)menu.Thoat <= stt && stt <= (int)menu.XoaTatCaPSNhoNhat)
                    break;
            }
            return stt;
        }

        public static void XuLyMenu(menu m)
        {
            QuanLyPhanSo ql = new QuanLyPhanSo();
            QuanLyPhanSo kq = new QuanLyPhanSo();
            PhanSo ps = new PhanSo();
            int vt;
            string filename = "dsPhanSo.txt";
            

            switch (m)
            {
                case menu.Thoat:
                    break;
                case menu.DongGoiInDex:
                    int id;
                    ps.Nhap();
                    Console.WriteLine("Nhap vi tri can sua:");
                    id = int.Parse(Console.ReadLine());
                    ql.DocFile(filename);
                    ql[id] = ps;
                    ql.XuatDSPS();
                    break;
                case menu.TaoLapQLPS:
                    Console.WriteLine("Da tao lap!");
                    break;
                case menu.ThemPS:
                    ql.DocFile(filename);
                    Console.WriteLine("Nhap phan so can them:");
                    ps = new PhanSo();
                    ps.Nhap();
                    Console.WriteLine("danh sach truoc khi them:");
                    ql.XuatDSPS();
                    ql.Them(ps);
                    Console.WriteLine("danh sach sau khi them:");
                    ql.XuatDSPS();
                    break;
                case menu.NhapDSPS:
                    
                    kq.NhapPS();
                    kq.XuatDSPS();
                    break;
                case menu.NhapCoDinh:
                    ql.NhapCoDinh();
                    ql.XuatDSPS();
                    break;
                case menu.DocFile:
                    ql.DocFile(filename);
                    
                    ql.XuatDSPS();
                    break;
                case menu.XuatDSPS:
                    ql.DocFile(filename);
                    ql.XuatDSPS();
                    break;
                case menu.RutGonDSPS:
                    ql.DocFile(filename);
                    Console.WriteLine("DSPS chua rut gon");
                    ql.XuatDSPS();
                    ql.RutGon();
                    Console.WriteLine("DSPS da rut gon");
                    ql.XuatDSPS();

                    break;
                case menu.TimDSPSCoMau:
                    ql.DocFile(filename);
                    int x;
                    Console.WriteLine("Nhap mau can tim:");
                    x = int.Parse(Console.ReadLine());
                    kq = ql.TimDSPSCoMau(x);
                    if(kq == null || kq.SoPT == 0)
                        Console.WriteLine("Khong ton tai phan so co mau :{0}", x);
                    else 
                        kq.XuatDSPS();
                    break;
                case menu.TimDSPSBangX:
                    ql.DocFile(filename);
                    Console.WriteLine("Nhap phan so can tim:");
                    ps.Nhap();
                    kq = ql.TimDSPSBangX(ps);
                    if (kq == null || kq.SoPT ==0)
                        Console.WriteLine("Khong ton tai phan so :{0}",ps);
                    else 
                        kq.XuatDSPS();
                    break;
                case menu.TongDSPS:
                    ql.DocFile(filename);
                    
                    ql.XuatDSPS();
                    Console.WriteLine("Tong cua DSPS: {0}", ql.TongDSPS());
                    break;
                case menu.TimDSPSMax:
                    ql.DocFile(filename);
                    Console.WriteLine("Phan so max:{0}", ql.Max);
                    break;
                case menu.SapXepDSPSTang:
                    ql.DocFile(filename);
                    Console.WriteLine("danh sach truoc khi sap xep:");
                    ql.XuatDSPS();
                    Console.WriteLine("danh sach sau khi sap xep:");
                    ql.SapXepDSPSTang();
                    ql.XuatDSPS();
                    break;
                case menu.SapXepDSPSGiam:
                    ql.DocFile(filename);
                    Console.WriteLine("danh sach truoc khi sap xep:");
                    ql.XuatDSPS();
                    Console.WriteLine("danh sach sau khi chen:");
                    ql.SapXepDSPSGiam();
                    ql.XuatDSPS();
                    break;
                case menu.ChenPS:
                    ql.DocFile(filename);
                    Console.WriteLine("Nhap vi tri can chen:");
                    vt = int.Parse(Console.ReadLine());
                    ps.Nhap();
                    Console.WriteLine( "danh sach truoc khi chen:" );
                    ql.XuatDSPS();
                    Console.WriteLine("danh sach sau khi chen:");
                    ql.ChenPS(vt,ps);
                    ql.XuatDSPS();
                    break;
                case menu.XoaPSNhoNhat:
                    ql.DocFile(filename);
                    Console.WriteLine("danh sach truoc khi xoa:");
                    ql.XuatDSPS();
                    ps = ql.Min;
                    Console.WriteLine("danh sach sau khi xoa:");
                    ql.XoaPSNhoNhat(ps);
                    ql.XuatDSPS();
                    break;
                case menu.XoaTatCaPSNhoNhat:
                    ql.DocFile(filename);
                    Console.WriteLine("danh sach truoc khi xoa:");
                    ql.XuatDSPS();
                    ps = ql.Min;
                    Console.WriteLine("danh sach sau khi xoa:");
                    ql.XoaTatCaPSNhoNhat(ps);
                    ql.XuatDSPS();
                    break;
            }
            Console.ReadKey();

        }

    }
}
