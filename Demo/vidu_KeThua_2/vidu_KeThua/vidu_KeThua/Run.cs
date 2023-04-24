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
            float s = ql.TongDThh();
            Console.WriteLine(s);
            ql.SapGiamHinhTron();
            Console.WriteLine("ds sau khi sap xep giam hinh tron theo dien tich ");
            Console.WriteLine(ql);
            
            QuanLyHinhHoc kq = ql.DanhSachHVMax();
            //Console.WriteLine("Dien tich Max la: {0}", ql.MaxDT());
            Console.WriteLine("Danh sach hinh vuong co dt max: {0} la \n{1}", ql.MaxDT(), kq);
            /* HinhHoc hh = new HinhHoc(2);
            HinhTron ht = new HinhTron(3);
            HinhVuong hv = new HinhVuong(4);
            HinhCN hcn = new HinhCN(10,20);
            hh = ht;
            float s = hh.TinhDT();           
            Console.WriteLine("Hinh hoc c={0}, s= {1}",hh.Canh,s);


            hh = hcn;
            Console.WriteLine("Hinh hoc c={0}, s= {1}", hh.Canh, ((HinhVuong)hh).TinhDT());
           */

            //if (hh is HinhVuong)
            //    s = ((HinhVuong)hh).TinhDT();
            //else if (hh is HinhTron)
            //    s = ((HinhTron)hh).TinhDT();


        }
    }
}
