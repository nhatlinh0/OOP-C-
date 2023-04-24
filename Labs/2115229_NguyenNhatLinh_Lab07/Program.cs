using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab07
{
    class Program
    {
        static int Main(string[] args)
        {
            ChayChuongTrinh();
            Console.ReadKey();
            return 1;
        }

        static void ChayChuongTrinh()
        {
            
            int soMenu;
            do
            {
                soMenu = menu.ChonMenu();
                menu.XuLyMenu((menu.Menu)soMenu);
            } while (soMenu > (int)menu.Menu.Thoat);
        }
    }
}
