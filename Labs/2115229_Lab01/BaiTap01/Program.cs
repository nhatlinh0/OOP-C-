using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. a,b,d,g,h,j,k, ");
            Console.WriteLine("2. C");
            Console.WriteLine("3. D");
            PersonalInfo();
            Lyrics();
            Comments();
            StopSign();
            BigLetter();
            BurmaShave();
            Console.ReadKey();
        }

        static void PersonalInfo()
        {
            Console.WriteLine("Name: Linh");
            Console.WriteLine("Birthday: 23/09");
            Console.WriteLine("Phone Number: 0879862xxx");
        }

        static void Lyrics()
        {
            Console.WriteLine("I dont have favorite song");
            Console.WriteLine("I dont have favorite song");
            Console.WriteLine("I dont have favorite song");
            Console.WriteLine("I dont have favorite song");
        }

        static void Comments()
        {
                //123

            /* 1
               2
               3*/
        }

        static void StopSign()
        {
            Console.WriteLine("   XXXXXX");
            Console.WriteLine(" X        X");
            Console.WriteLine("X   STOP   X");
            Console.WriteLine(" X        X");
            Console.WriteLine("   XXXXXX");
            Console.WriteLine("      X");
            Console.WriteLine("      X");
            Console.WriteLine("      X");   
        }

        static void BigLetter()
        {
            Console.WriteLine("H      H");
            Console.WriteLine("H      H");
            Console.WriteLine("HHHHHHHH");
            Console.WriteLine("H      H");
            Console.WriteLine("H      H");
            Console.WriteLine("H      H"); ;
           
        }

        static void BurmaShave()
        {
            Console.WriteLine("Shaving brushes ");
            Console.WriteLine("You’ll soon see ’em ");
            Console.WriteLine("On a shelf ");
            Console.WriteLine("In some museum ");
            Console.WriteLine("Burma Shave");  

        }
    }
}
