using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu_KeThua
{
    class Run
    {
        static void Main()
        {
            QuanLyHinhHoc ql = new QuanLyHinhHoc();
            ql.NhapCD();
            Console.WriteLine(ql);
            Console.WriteLine("Tong dien tich hinh tron: {0}", ql.TongDTHinhTron());
            /*HinhHoc hh = new HinhHoc(2);
            HinhTron ht = new HinhTron(3);
            HinhVuong hv = new HinhVuong(4);
            HinhCN hcn = new HinhCN(10,20);

            Console.WriteLine("Dien tich hinh hoc: {0}, Hinh tron: {1}", hh.TinhDT(), ht.TinhDT());
            Console.WriteLine(ht);
            Console.WriteLine(hcn);
            hh = ht;
            float s = 0;
            if (hh is HinhVuong)
                s = ((HinhVuong)hh).TinhDT();
            else if(hh is HinhTron)
                s = ((HinhTron)hh).TinhDT();
            Console.WriteLine("Hinh hoc c={0}, s= {1}",hh.Canh,s);


            hh = hcn;
            Console.WriteLine("Hinh hoc c={0}, s= {1}", hh.Canh, ((HinhVuong)hh).TinhDT());
            */


        }
    }
}
