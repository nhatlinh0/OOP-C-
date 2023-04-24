using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Vidu1
{
    internal class QuanLySinhVien
    {
        SinhVien[] dsSinhVien;
        int soSV;
        public int SoSV
        {
            get { return soSV; }
            set { soSV = value; }
        }

        public QuanLySinhVien()
        {
            this.dsSinhVien = new SinhVien[100];
            this.SoSV = 0;
        }

        private void Them(SinhVien sv)
        { 
            this.dsSinhVien[soSV++] = sv;
        }
        public void NhapCoDinh()
        {
            this.Them(new SinhVien("2130302", "Tran Van Anh", 7.4f, new DateTime(2000, 8, 23)));
            this.Them(new SinhVien("2003344", "Nguyen Thi Huong", 6.0f, new DateTime(2001, 3, 4)));
            this.Them(new SinhVien("2134545", "Le Van Nguyet", 8.0f, new DateTime(2005, 8, 29)));
            this.Them(new SinhVien("2111111", "Nguyen Hung", 3.5f, new DateTime(1998, 10, 15)));
            this.Them(new SinhVien("2143322", "Nguyen Van Anh", 8.0f, new DateTime(2000, 2, 5)));
        }
        public void Xuat()
        {
            for (int i = 0; i < this.SoSV; i++)
            {
                Console.WriteLine("{0}\t{1}", i+1, this.dsSinhVien[i]);
            }
        }
        public float TongDiem()
        {
            float s = 0;
            for (int i = 0; i < this.SoSV; i++)
            {
                s += dsSinhVien[i].DiemTB;
            }
            return s;
        }
        public QuanLySinhVien TimTheoTen(string ten)
        {
            QuanLySinhVien kq = new QuanLySinhVien();
            for (int i = 0; i < this.SoSV; i++)
            {
                if (dsSinhVien[i].Ten.CompareTo(ten) == 0)
                    kq.Them(dsSinhVien[i]);
            }
            return kq;
        }
        public float DiemTBMAX
        {
            get
            {
                float max = dsSinhVien[0].DiemTB;
                for (int i = 1; i < this.SoSV; i++)
                {
                    if (max < dsSinhVien[i].DiemTB)
                        max = dsSinhVien[i].DiemTB;
                }
                return max;
            }
        }
        public QuanLySinhVien TimTheoDiemTB(float diem)
        {
            QuanLySinhVien kq = new QuanLySinhVien();
            for (int i = 0; i < this.SoSV; i++)
            {
                if (diem == dsSinhVien[i].DiemTB)
                    kq.Them(dsSinhVien[i]);
            }
            return kq;
        }
    }
}
