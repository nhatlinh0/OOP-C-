using System;

namespace Lab2_XuLyChuoi
{
    class Program
    {
        enum Menu
        {
            Thoat, //0
            NhapDanhSachHT,
            NhapDSCoDinh,
            XuatDanhSachHT,
            InDSTheoHo,
        }
        static string[] dshoten = new string[100];
        static int length = 0;
        static void Main()
        {
            NhapCoDinh();
            ChayCT();
        }

        static void ChayCT()
        {
            int chon;
            do
            {
                XuatMenu();
                chon = ChonMenu();
                XuLyMenu((Menu)chon);
                Console.Clear();
            } while (chon != (int)Menu.Thoat);

        }
        static void XuatMenu()
        {
            XuatKeNgang('-', 40);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.Thoat, Menu.Thoat);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.NhapDanhSachHT, Menu.NhapDanhSachHT);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.NhapDSCoDinh, Menu.NhapDSCoDinh);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.XuatDanhSachHT, Menu.XuatDanhSachHT);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.InDSTheoHo, Menu.InDSTheoHo);          
            XuatKeNgang('-', 40);
        }

        static void XuatKeNgang(char kt, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(kt);
            Console.WriteLine();
        }
        static int ChonMenu()
        {
            int chon;
            do
            {
                Console.Write("\nNhap chon [{0}...{1}]:",
                    (int)Menu.Thoat, (int)Menu.InDSTheoHo);
                chon = int.Parse(Console.ReadLine());

                if ((int)Menu.Thoat <= chon && chon <= (int)Menu.InDSTheoHo)
                    break;

            } while (true);
            return chon;
        }

        static void XuLyMenu(Menu m)
        {
            string hotim;

            switch (m)
            {
                case Menu.Thoat:
                    Console.WriteLine("Thoat chuong trinh");
                    return;
                case Menu.NhapDanhSachHT:
                    Console.WriteLine("Nhap danh sach ho ten");
                    NhapDS();
                    break;
                case Menu.NhapDSCoDinh:
                    Console.WriteLine("Da nhap co dinh danh sach ho ten");
                    NhapCoDinh();
                    break;
                case Menu.XuatDanhSachHT:
                    Console.WriteLine("Danh sach ho ten");
                    XuatDS();
                    break;
                case Menu.InDSTheoHo:
                    XuatDS();
                    Console.Write("\nNhap ho can tim:");
                    hotim = Console.ReadLine();
                    Console.WriteLine("\nDanh sach co ho: {0}", hotim);
                    InDSTheoHo(hotim);
                    break;
                

            }
            Console.ReadKey();
        }
        static void NhapCoDinh()
        {
            dshoten = new string[] {
            "  Cao    Anh tu   ",
            "Nguyen     quoc     Khanh     ",
            "Phan    bao     Linh",
            "  Le Hoang Bao",
            "Nguyen Lan Huong",
            "Phan Anh",
            "  Le Tran   nguyen   quoc   Khanh",
            "Do Thi Huong",
            "Nguyen  thi   thuy Anh",
            "le Viet    anh   "
            };
            length = 10;
        }
        static void InDSTheoHo(string hotim)
        {
            int d = 0;
            for (int i = 0; i < length; i++)
            {
                if (LayHo(dshoten[i].Trim()).ToLower() == hotim.Trim().ToLower())
                    Console.WriteLine("{0}\t{1}", ++d, dshoten[i]);
            }

        }
        static void NhapDS()
        {
            Console.Write("Nhap chieu dai danh sach:");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("Nhap ho ten thu {0}:", i + 1);
                dshoten[i] = Console.ReadLine();
            }
        }
        static void XuatDS()
        {
            XuatKeNgang('=', 43);
            Console.WriteLine("|{0}|{1}|", "STT".ToString().PadRight(5), "Ho ten".PadLeft(35));
            XuatKeNgang('=', 43);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("|{0}|{1}|", (i + 1).ToString().PadRight(5), dshoten[i].PadRight(35));
            }
            XuatKeNgang('=', 43);
        }
        static string LayHo(string hoten)
        {
            string[] ss = hoten.Trim().Split(' ');
            return ss[0];
        }

        static string LayHoSubstring(string hoten)
        {
            int vt = hoten.Trim().IndexOf(' ');
            string ho = hoten.Substring(0, vt);
            return ho;
        }
        
    }
}
