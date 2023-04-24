using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab07
{
    class Bao:IAnPham
    {
        private float giaTien;
        private string nhaXuatBan;
        private string ten;
        public float GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }

        public string NhaXuatBan
        {
            get { return nhaXuatBan; }
            set { nhaXuatBan = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public Bao()
        {

        }

        public Bao(string line)
        {
            string[] ss = line.Split(',');
            this.Ten = ss[1];
            this.NhaXuatBan = ss[2];
            this.GiaTien = float.Parse(ss[3]);
        }

        public Bao(string ten, string nhaXuatBan, float giaTien)
        {
            this.Ten = ten;
            this.NhaXuatBan = nhaXuatBan;
            this.GiaTien = giaTien;
        }

        public void Nhap()
        {
            string ten;
            string nhaxuatban;
            float giatien;
            Console.WriteLine("Nhap Ten Bao:");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap nha xuat ban:");
            nhaxuatban = Console.ReadLine();
            Console.WriteLine("Nhap gia tien:");
            giatien = float.Parse(Console.ReadLine());
            this.Ten = ten;
            this.NhaXuatBan = nhaxuatban;
            this.GiaTien = giatien;
        }
        public override string ToString()
        {
            return String.Format("Ten Bao: {0}, Nha Xuat Ban: {1}, Gia Tien: {2}", Ten, NhaXuatBan, GiaTien);
        }
    }
}
