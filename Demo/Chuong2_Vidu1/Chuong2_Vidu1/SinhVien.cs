using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Vidu1
{
    public class SinhVien
    {
        private string maSV;
        public string hoTen;
        private float diemTB;
        private DateTime ngaySinh;
        public DateTime NgaySinh
        { 
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public float DiemTB
        {
            get { return diemTB; }
            set {
                if (value < 0)
                    value=0;

                diemTB = value;            
            }
        }
        public string Ten
        {
            get
            {
                string[] x = hoTen.Trim().Split(' ');

                return x[x.Length - 1];
            }
        }


        public SinhVien()
        {

        }
        public SinhVien(string maSV, string hoTen, float diemTB, DateTime ngaySinh)
        { 
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diemTB = diemTB;
            this.ngaySinh = ngaySinh;
        }

        private void Nhap()
        {
            Console.Write("\nNhap ma so:");
            this.maSV = Console.ReadLine();
            Console.Write("\nNhap Ho ten:");
            this.hoTen = Console.ReadLine();
            Console.Write("\nNhap DTB:");
            this.DiemTB =float.Parse( Console.ReadLine());
            Console.Write("\nNhap Ngay sinh (m/d/yyyy):");
            this.NgaySinh =DateTime.Parse(Console.ReadLine());

        }
        public void Xuat()
        {            
            Console.WriteLine(maSV + '\t'+ hoTen+'\t'+ diemTB+'\t'+ngaySinh.ToString());
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", this.maSV, this.hoTen, this.DiemTB, this.NgaySinh);
        }
     
    }
}
