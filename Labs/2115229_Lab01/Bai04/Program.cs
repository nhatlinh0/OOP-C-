using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int kq;
            Console.WriteLine("Nhap n");
            n = Int32.Parse(Console.ReadLine());
            kq=GiaiThua(n);
            Console.WriteLine("Giai thua cua {0} la: {1}",n, kq);
            Console.ReadKey();
        }

        static int GiaiThua(int n)
        {
            int kq = 1;
           
            while (n >= 1) 
            {
                kq = kq * (n);
                n--;
            }
            return kq;
        }
    }
}
