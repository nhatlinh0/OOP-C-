using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            int kt;
            Console.WriteLine("Nhap a:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = Int32.Parse(Console.ReadLine());
            kt = PhanLoaiTamGiac(a, b, c);
            XuatKQ(kt);
            Console.ReadKey();
        }

        static int PhanLoaiTamGiac(double a, double b, double c)
        {
            int kt = 0;
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                kt = 1;
            }

            if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                kt = 1;
            }
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                kt = 1;
            }
            if ((a == b) && (a != c) && (b != c))
            {
                kt = 2;
            }
            if ((b == c) && (b != a) && (c != a))
            {
                kt = 2;
            }
            if ((c == a) && (c != b) && (a != b))
            {
                kt = 2;
            }
            if ((a == b) && (b == c))
            {
                kt = 3;
            }
            return kt;
        }

        static void XuatKQ(int kt)
        {
            if (kt == 0)
                Console.WriteLine("Day la tam giac thuong ");
            if (kt == 1)
                Console.WriteLine("Day la tam giac vuong");
            if (kt == 2)
                Console.WriteLine("Day la tam giac can");
            if (kt == 3)
                Console.WriteLine("Day la tam giac deu");
            if (kt == 1 && kt == 2)
                Console.WriteLine("Day la tam giac vuong can");



        }


    }
}




