using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Chuong2_Vidu1
{
    internal class Run
    {
        static void Main()
        {
            QuanLySinhVien ql = new QuanLySinhVien();
            Console.WriteLine("Chuong trinh quan ly sinh vien");
            ql.NhapCoDinh();
            ql.Xuat();
            Console.WriteLine("Tong dien tb: {0}", ql.TongDiem());
            string ten = "Anh";
            QuanLySinhVien kq = ql.TimTheoTen(ten);
            Console.WriteLine("Danh sach sinh vien co ten: {0}", ten);
            kq.Xuat();
            Console.WriteLine("Tong dien tb cua sinh vien ten {0} la: {1}", ten, kq.TongDiem());

            kq = ql.TimTheoDiemTB(ql.DiemTBMAX);
            Console.WriteLine("Danh sach sinh vien co diem trung binh cao nhat");
            kq.Xuat();


            /*SinhVien sv = new SinhVien("2130302", "Nguyen Van Anh", 7.4f, new DateTime(2000, 3, 4));
            //Console.WriteLine(sv.hoTen);
            sv.NgaySinh = DateTime.Parse("4/20/2000");
            sv.DiemTB = -8.3f;
            

            Console.WriteLine("Nam sinh: {0}", sv.NgaySinh.Year);
            //sv.Xuat();
            Console.WriteLine("Thong tin sinh vien: \n{0}", sv);

            Console.WriteLine("ten la: {0}", sv.Ten);
            */
        }
    }
}

