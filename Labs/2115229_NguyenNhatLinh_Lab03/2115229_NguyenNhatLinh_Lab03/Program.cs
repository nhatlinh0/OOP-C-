using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab03
{
    class Program
    {

  
        

        static void Main(string[] args)
        {
            Menu.menu m;
            int soMenu;
            do
            {
                soMenu = Menu.ChonMenu();
                m= (Menu.menu)soMenu;
                Menu.XuLyMenu(m);
            } while (m > Menu.menu.Thoat);
            
            Console.ReadKey();
        }

        
    }
}
