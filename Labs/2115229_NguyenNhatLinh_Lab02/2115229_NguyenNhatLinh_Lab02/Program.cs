using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab02
{
    class Program
    {
        enum Menu
        {
            Thoat,
            NhapDanhSachHT,
            NhapDSCoDinh,
            XuatDanhSachHT,
            InDSTheoHo,
            ChuanHoadsHT,
            DemSoNguoiCoTenX,
            XuatDSInHoa,
            TimHoTenCoChieuDaiLonNhat,
            TimHoTenCoChieuDaiNhoNhat,
            SapXepDSTangTheoHo,
            SapXepDSGiamTheoTen,
        }

        static string[] dshoten = new string[100];
        static int length = 0;

        static void XuatKeNgang(char kt, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(kt);
            Console.WriteLine();
        }

        static void XuatMenu()
        {
             XuatKeNgang('-', 40);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.Thoat, Menu.Thoat);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.NhapDanhSachHT, Menu.NhapDanhSachHT);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.NhapDSCoDinh, Menu.NhapDSCoDinh);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.XuatDanhSachHT, Menu.XuatDanhSachHT);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.InDSTheoHo, Menu.InDSTheoHo);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.ChuanHoadsHT, Menu.ChuanHoadsHT);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.DemSoNguoiCoTenX, Menu.DemSoNguoiCoTenX);
             Console.WriteLine("Nhap {0} de {1}", (int)Menu.XuatDSInHoa, Menu.XuatDSInHoa);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.TimHoTenCoChieuDaiLonNhat, Menu.TimHoTenCoChieuDaiLonNhat);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.TimHoTenCoChieuDaiNhoNhat, Menu.TimHoTenCoChieuDaiNhoNhat);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.SapXepDSTangTheoHo, Menu.SapXepDSTangTheoHo);
            Console.WriteLine("Nhap {0} de {1}", (int)Menu.SapXepDSGiamTheoTen, Menu.SapXepDSGiamTheoTen);
            XuatKeNgang('-', 40);
         }

        static int ChonMenu()
        {
            int chon;
            Console.Clear();
            XuatMenu();
            do
            {
                Console.Write("\nNhap chon [{0}...{1}]:",
                (int)Menu.Thoat, (int)Menu.SapXepDSGiamTheoTen);
                chon = int.Parse(Console.ReadLine());
                if ((int)Menu.Thoat <= chon && chon <= (int)Menu.SapXepDSGiamTheoTen)
                    break;
            } while (true);
            return chon;
        }

        static void XuLyMenu(Menu m)
        {
            string hoten;
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
                case Menu.ChuanHoadsHT:
                    Console.WriteLine("Nhap ho ten: ");
                    hoten = Console.ReadLine();
                    ChuanHoadshoten(hoten);
                    break;
                case Menu.DemSoNguoiCoTenX:
                    Console.WriteLine("Nhap ten:");
                    hoten = Console.ReadLine();
                    XuatDS();
                    Console.WriteLine("So nguoi co ten {0} la: {1}", LayTen(hoten) ,DemSoNguoiCoTenX(hoten));
       
                    break;
                case Menu.XuatDSInHoa:
                    XuatDSInHoa();
                    break;
                case Menu.TimHoTenCoChieuDaiLonNhat:
                    XuatDS();
                    Console.WriteLine("Ho ten theo chieu dai lon nhat: {0}",TimHoTenCoChieuDaiLonNhat());
                    break;
                case Menu.TimHoTenCoChieuDaiNhoNhat:
                    XuatDS();
                    Console.WriteLine("Ho ten theo chieu dai nho nhat: {0}", TimHoTenCoChieuDaiNhoNhat());
                    break;
                case Menu.SapXepDSTangTheoHo:
                    SapXepDSTangTheoHo();
                    XuatDS();
                    break;
                case Menu.SapXepDSGiamTheoTen:
                    SapXepDSGiamTheoTen();
                    XuatDS();
                    break;
            }
            Console.ReadKey();
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

        static void NhapCoDinh()
        {
            dshoten = new string[] 
            {
                 " Cao Anh tu ",
                 "Nguyen quoc Khanh ",
                  "Phan bao Linh",
                 " Le Hoang Bao",
                "Nguyen Lan Huong",
                "Phan Anh",
                " Le Tran nguyen quoc Khanh",
                "Do Thi Huong",
                "Nguyen thi thuy Anh",
                "le Viet anh "
             };
            length = 10;
        }

        static void XuatDS()
        {
            XuatKeNgang('=', 43);
            Console.WriteLine("|{0}|{1}|", "STT".ToString().PadRight(5), "Ho ten".PadLeft(35));
            XuatKeNgang('=', 43);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("|{0}|{1}|", (i + 1).ToString().PadRight(5),
               dshoten[i].PadRight(35));
            }
            XuatKeNgang('=', 43);
        }

        static string LayHo(string hoten)
        {
            string[] ss = hoten.Trim().Split(' ');
            return ss[0];
        }

        static void InDSTheoHo(string hotim)
        {
            int d = 0;
            for (int i = 0; i < length; i++)
            {
                if (LayHo(dshoten[i]).ToLower() == hotim.ToLower())
                    Console.WriteLine("{0}\t{1}", ++d, dshoten[i]);
            }

        }

        static void ChuanHoadshoten(string hoten)
        {
            string[] ss = hoten.Trim().Split(' ');
           
            for (int i = 0; i < ss.Length; i++)
            {
                ss[i].Trim().ToUpper();
               
                Console.WriteLine(ss[i]);
            }
            for (int i = 0; i < ss.Length; i++)
            {
               

                Console.WriteLine(ss[i]);
            }
        }

        static int DemSoNguoiCoTenX(string hoten)
        {
            int dem=0;
            for(int i=0;i<length;i++)
            {
                if(LayTen(dshoten[i]).ToLower() == LayTen(hoten).ToLower())
                {
                    dem++;
                }
                
            }
            return dem;
        }

        static string LayTen(string hoten)
        {
            
            string[] ss = hoten.Trim().Split(' ');

            return ss[ss.Length - 1];

        }

        static void XuatDSInHoa()
        {
            XuatKeNgang('=', 43);
            Console.WriteLine("|{0}|{1}|", "STT".ToString().PadRight(5), "Ho ten".PadLeft(35));
            XuatKeNgang('=', 43);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("|{0}|{1}|", (i + 1).ToString().PadRight(5).ToUpper(),
               dshoten[i].PadRight(35).ToUpper());
            }
            XuatKeNgang('=', 43);
        }

        static string TimHoTenCoChieuDaiLonNhat()
        {
            string max = dshoten[0];
            for(int i=0;i<length-1;i++)
            {
                for (int j = 1; j < length; j++)
                {
                   if(max.Length < dshoten[j].Length)
                   {
                       max = dshoten[j];
                   }

                }
            }
            return max;
        }

        static string TimHoTenCoChieuDaiNhoNhat()
        {
            string min = dshoten[0];
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if (min.Length > dshoten[j].Length)
                    {
                        min = dshoten[j];
                    }

                }
            }
            return min;
        }

        static void SapXepDSTangTheoHo()
        {
            int i;
            string temp;
            for (i = 0; i < length-1; i++) 
            {
                for (int j = i+1; j < length; j++) 
                {
                    if (String.Compare(LayHo(dshoten[i]), LayHo(dshoten[j])) > 0) 
                    {
                       temp = dshoten[i];
                        dshoten[i] = dshoten[j];
                        dshoten[j] = temp;

                    }
                }
            }
        }
        
        static void SapXepDSGiamTheoTen()
        {
            string temp;
            for(int i=0;i<length; i++)
            {
                for(int j=i+1;j<length; j++)
                {
                    if(String.Compare(LayTen(dshoten[i]).ToLower(), LayTen(dshoten[j]).ToLower()) <0)
                    {
                        temp = dshoten[i];
                        dshoten[i] = dshoten[j];
                        dshoten[j] = temp;
                    }
                            

                    
                }
            }
        }
           
            
           
        
        
      
            


            static void Main(string[] args)
        {
            ChayChuongTrinh();
            Console.ReadKey();
        }

        static void ChayChuongTrinh()
        {

            Menu m;
           
           do
           {
               m = (Menu)ChonMenu();
               XuLyMenu(m);
           } while (Menu.Thoat < m);
        }
    }
}
