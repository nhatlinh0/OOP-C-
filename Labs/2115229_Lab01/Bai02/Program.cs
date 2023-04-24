using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            GiaiPTBac2();
            Console.ReadKey();
        }

        static void GiaiPTBac2()
        {
            double a, b, c, x1, x2;
            double delta;
            Console.WriteLine("Pt: ax^2+by+c=0");
            do
            {
                Console.WriteLine("Nhap a:");
                a = Int32.Parse(Console.ReadLine());
            } while (a == 0);
            Console.WriteLine("Nhap b:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = Int32.Parse(Console.ReadLine());
            delta = b * b - (4 * a * c);
            if (delta < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (delta == 0)
            {
                x1 = x2 = -b / 2 * a;
                Console.WriteLine("Phuong trinh co nghiem kep: {0}, {1}", x1, x2);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: {0}, {1}", x1, x2);
            }


        }
    }
}
