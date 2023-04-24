using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_PhanSo
{
    internal class Run
    {
        static void Main()
        {
            PhanSo ps1=new PhanSo(1,2);
            PhanSo ps2 = new PhanSo(2,5);
            PhanSo ps=new PhanSo();
            int x = 2;
            
            /*Console.WriteLine("{0}++={1}",ps1, ++ps1);
            Console.WriteLine("{0}", ps1);
            ps1 = x + ps1;

            ps = ps1 + ps2;
            Console.WriteLine("{0}+{1}={2}", ps1, ps2, ps);
           
            Console.WriteLine("{0}+{1}={2}", ps,x, ps + x);
            */
            ps1 = new PhanSo(1, 2);
            ps2 = new PhanSo(4, 6);
            ps1 =3;
            Console.WriteLine("ps1=3={0}", ps1);

            double z = (double)ps2;
            Console.WriteLine("(double){0}={1}", ps2, z);

            //int y =(int) 10.5;

            //float dtb = 5;
            //dtb = (double)ps1;

            if (ps1== ps2)
                Console.WriteLine("{0}=={1}", ps1, ps2);
            else
                Console.WriteLine("{0}!={1}", ps1, ps2);


        }
    }
}
