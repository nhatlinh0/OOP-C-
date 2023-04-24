using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_Lab01_Bai05
{
    class Program
    {
        static int length = 0;
        static int[] a = new int[100];
        enum Menu
        {
            Thoat,
            XoaPhanTuDauTien,
            TimViTriDauTien,
            XoaPhanTuTaiViTri,
            NhapNgauNhien,
            Nhap,
            Xuat,
            TimPhanTuLonNhat,
            DemSoLanXuatHienCuaX,
            ThayThePhanTuXThanhY,
            DaoNguocMang,
            XoaXTrongMang,
            SapTang,
            So0DauAmGiuaDuongCuoi,
            ChenXTaiViTri,
            KiemTraPhanTu01
    }

        static void XuatMenu()
        {
             Console.WriteLine("================================HE THONG MENU==============================");
             Console.WriteLine("0. Thoat");
             Console.WriteLine("1. Xoa phan tu dau tien");
             Console.WriteLine("2. Tim vi tri dau tien");
             Console.WriteLine("3. Xoa phan tu tai vi tri");
             Console.WriteLine("4. Nhap ngau nhien");
             Console.WriteLine("5. Nhap");
             Console.WriteLine("6. Xuat");
             Console.WriteLine("7. Tim phan tu lon nhat");
             Console.WriteLine("8. Dem so lan X xuat hien trong mang");
             Console.WriteLine("9. Thay the X thanh Y");
             Console.WriteLine("10. Dao nguoc mang");
             Console.WriteLine("11. Xoa tat ca phan tu X");
             Console.WriteLine("12. Sap tang cac phan tu");
             Console.WriteLine("13. Sap cac phan tu sao cho so 0 dau, so am giua giam dan, so duong cuoi tang dan");
             Console.WriteLine("14. Chen X tai 1 vi tri cho truoc");
             Console.WriteLine("15. Kiem tra mang co chua 0 va 1");
             Console.WriteLine("============================================================================");
        }

        static int ChonMenu()
        {
            int Chon=0;
            for(;;)
            {
            Console.Clear();
            XuatMenu();
            Console.WriteLine("Chon 1 so [{0}..{1}]=", (int)Menu.Thoat, (int)Menu.KiemTraPhanTu01);
            Chon = int.Parse(Console.ReadLine());
            if ((int)Menu.Thoat <= Chon && Chon <= (int)Menu.KiemTraPhanTu01)
                break;
            }
            return Chon;

        }

        static void XuLyMenu(Menu m)
        {
            int x, y, vt=0;
            
            switch(m)
            {
                   
                case Menu.Thoat:
                    break;
                case Menu.XoaPhanTuDauTien:
                    Xuat();
                    Console.WriteLine("");
                    Console.WriteLine("Nhap X=");
                    x = int.Parse(Console.ReadLine());
                    XoaPhanTuDauTien(x);
                    Xuat();
                    break;

                case Menu.TimViTriDauTien:
                    Xuat();
                    Console.WriteLine("");
                    Console.WriteLine("Nhap X=");
                    x = int.Parse(Console.ReadLine());
                    TimViTriDauTien(x);
                    Console.WriteLine("Vi tri dau tien cua {0} la {1}",x,TimViTriDauTien(x));
                    break;
                case Menu.XoaPhanTuTaiViTri:
                    Xuat();
                    Console.WriteLine("");
               
                    Console.WriteLine("Nhap vi tri=");
                    vt = int.Parse(Console.ReadLine());
                    XoaPhanTuTaiViTri(vt);
                    Xuat();
                    
                    break;
                case Menu.NhapNgauNhien:
                    NhapNgauNghien();
                    Xuat();
                    break;
                case Menu.Nhap:
                    Nhap();
                    Xuat();
                    break;
                case Menu.Xuat:
                    Xuat();
                    break;
                case Menu.TimPhanTuLonNhat:
                    Console.WriteLine("Phan tu lon nhat la:{0} ",TimPhanTuLonNhat());
                    break;
                case Menu.DemSoLanXuatHienCuaX:
                    Console.WriteLine("Nhap X=");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("So lan xuat hien cua {0} la {1} ",x,DemSoLanXuatHienCuaX(x));

                    break;
                case Menu.ThayThePhanTuXThanhY:
                    Console.WriteLine("Nhap X=");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap Y=");
                    y = int.Parse(Console.ReadLine());
                    ThayPhanTuXThanhY(x,y);
                    Xuat();
                    break;
                case Menu.DaoNguocMang:
                    Xuat();
                    Console.WriteLine("");
                    DaoNguocMang();
                    
                    break;
                case Menu.XoaXTrongMang:
                    Xuat();
                    Console.WriteLine("Nhap X=");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    XoaTatCaPhanTuX(x);
                    Xuat();
                    break;
                case Menu.SapTang:
                    Xuat();
                    SapTang();
                    Console.WriteLine("");
                    Xuat();
                    break;
                case Menu.So0DauAmGiuaDuongCuoi:
                    break;
                case Menu.ChenXTaiViTri:
                    Xuat();
                    Console.WriteLine("");
                    Console.WriteLine("Nhap X=");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap Vi tri=");
                    vt = int.Parse(Console.ReadLine());

                    ChenX(x, vt);
                    Console.WriteLine("");
                    Xuat();
                    break;
                case Menu.KiemTraPhanTu01:
                    if (KiemTraCo01() == 1)
                        Console.WriteLine("Mang khong chua 0 va 1");
                    else
                        Console.WriteLine("Mang co chua 0 va 1");
                    break;

            }
            Console.ReadKey();
        }
        
        static void ChayCT()
        {
             Menu soMenu;
            do
            {
               
                soMenu = (Menu)ChonMenu();
                XuLyMenu(soMenu);
            } while (Menu.Thoat < soMenu);

        }




        

        static void Main(string[] args)
        {
           
            ChayCT();
            Console.ReadKey();
        }
       

        static void XoaPhanTuDauTien(int x)
        {
            XoaPhanTuTaiViTri(TimViTriDauTien(x));
        }

        static int TimViTriDauTien(int x)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }

        static void XoaPhanTuTaiViTri(int vt)
        {
            for (int i = vt; i < length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            length--;
        }

        static void NhapNgauNghien()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = r.Next(10);
            }
        }

        static void Nhap()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write(" a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static int TinhTong()
        {
            int tong = 0;
            for (int i = 0; i < length; i++)
            {
                tong += a[i];

            }
            return tong;
        }

        static void Xuat()
        {
            Console.WriteLine("Mang vua nhap la ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("\t " + a[i]);
            }


        }

        static int TimPhanTuLonNhat()
        {
            int max = a[0];
            for(int i=0;i<length;i++)
               {
                    if (a[i]>max)
                    {
                        max = a[i];
                    }
               }
            return max;
        }
        
        static int DemSoLanXuatHienCuaX(int x)
        {
            int dem = 0;
            for(int i=0;i<length;i++)
            {
                if (a[i] == x)
                    dem++;
            }
            return dem;
        }

        static void ThayPhanTuXThanhY(int x, int y)
        {
            for(int i=0;i<length;i++)
            {
                if (a[i] == x)
                    a[i] = y;
            }
        }

        static void DaoNguocMang()
        {
            for(int i=length-1;i>=0;i--)
            {
                Console.Write("\t" + a[i]);
            }
        }
        static void XoaTatCaPhanTuX(int x)
        {
            for(int i=0;i<length;i++)
            {
                if (a[i] == x)
                {
                    for (int j =i; j < length; j++)
                    {
                        a[j] = a[j + 1];
                        
                    }
                    length--;
                }
                
            }
        }

        static void SapTang()
        {
            for(int i=0;i<length;i++)
            {
                for(int j=0;j<length;j++)
                {
                    if (a[i]<a[j])
                    {
                        HoanVi(ref a[i],ref a[j]);
                    }
                }
            }
        }

        static void HoanVi(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void ChenX(int x,int vt)
        {
            for(int i=length;i >= vt;i--)
            {
                a[i+1]=a[i];
            }
            a[vt]=x;
            length++;
        }

        static int KiemTraCo01()
        {
            int kq = 1;
            for(int i=0;i<length;i++)
            {
                if (a[i] == 0 )
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (a[j]==1)
                            kq = 0;
                    }
                   
                    
                }
            }
            return kq;
        }
    }
}
