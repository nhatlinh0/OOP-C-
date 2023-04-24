using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab04
{
    class Program
    {

        static void ChayChuongTrinh()
        {
            Menu.menu m;
            int soMenu;
            do
            {
                soMenu = Menu.ChonMenu();
                m = (Menu.menu)soMenu;
                Menu.XuLyMenu(m);
            } while ((int)Menu.menu.Thoat < m);
        }

        static void Main(string[] args)
        {
            ChayChuongTrinh();
            Console.ReadKey();
        }

        
    }
}
