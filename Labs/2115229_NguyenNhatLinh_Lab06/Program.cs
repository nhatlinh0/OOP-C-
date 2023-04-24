using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            ChayCT();
            Console.ReadKey();
        }

        public static void ChayCT()
        {
            Menu.menu m;
            int soMenu;
            do
            {
                soMenu = Menu.ChonMenu();
                Menu.XuLyMenu((Menu.menu)soMenu);
            } while (soMenu > (int)Menu.menu.Thoat);
        }
    }
}
