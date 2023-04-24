using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab03
{
    class SinhVien
    {
        private string maSV;
        private string hoTen;
        private float diemTB;
        private DateTime ngaySinh;
        
        public string MaSV
        {
            get { return maSV; }
            set
            {
                this.maSV = value;
            }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set{
                this.ngaySinh = value;
            }
        }
        
        public float DiemTB
        {
            get { return diemTB; }
            set{
                if (value < 0)
                    value = 0;
                if (value > 10)
                    value = 10;
                this.diemTB = value;
            }
        }
       
        public string Ho
        {
            get
            {
                string[] x = this.hoTen.Trim().Split(' ');
                return x[0];
            }
        }

        public string Ten
        {
            get
            {
                string[] x = this.hoTen.Trim().Split(' ');
                return x[x.Length - 1];
            }
        }
       
        public string HoTen
        {
            get
            { return hoTen; }
            

            
            set
            {
               
                string a = "";
                string b = "";
                string c = "";
                string hoten= "";
                string[] x = value.Trim().Split(' ');

                for (int i = 0; i < x.Length; i++)
                {
                    a = x[i].Trim().Substring(0, 1).ToUpper();
                    b = x[i].Trim().Substring(1, x[i].Length - 1);
                    c = a + b;
                    hoten = hoten + c + ' ';

                }
                value = hoten;
                hoTen = value;
                
            }
            
            
        }

        public SinhVien()
        {

        }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, float diemTB)
        {
            this.maSV = maSV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DiemTB = diemTB;
        }
         
        public void Nhap()
        {
            Console.WriteLine("Nhap ma so sinh vien:");
            this.maSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sinh vien:");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay thang nam sinh(dd/mm/yyyy):");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh sinh vien:");
            this.DiemTB = float.Parse(Console.ReadLine());
   
        }

        

         public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", this.maSV, this.HoTen, this.DiemTB, this.NgaySinh);
        }
            
            
            


        

    }
}
