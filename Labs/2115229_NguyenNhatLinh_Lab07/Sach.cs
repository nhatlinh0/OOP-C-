using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab07
{
    class Sach:IAnPham
    {
        private float giaTien;
        private string nhaXuatBan;
        public int SoTrang;
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

        public Sach()
        {

        }
        public Sach(string line)
        {
            string[] ss = line.Split(',');
            this.Ten = ss[1];
            this.NhaXuatBan = ss[2];
            this.GiaTien = float.Parse(ss[3]);
            this.SoTrang = int.Parse(ss[4]);
        }

        public Sach(string ten, string nhaXuatBan, float giaTien, int soTrang)
        {
            this.Ten = ten;
            this.NhaXuatBan = nhaXuatBan;
            this.GiaTien = giaTien;
            this.SoTrang = soTrang;
        }
        public void Nhap()
        {
            string ten;
            string nhaxuatban;
            float giatien;
            int sotrang;
            Console.WriteLine("Nhap Ten sach:");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap nha xuat ban:");
            nhaxuatban = Console.ReadLine();
            Console.WriteLine("Nhap gia tien:");
            giatien = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so trang:");
            sotrang = int.Parse(Console.ReadLine());

            this.Ten = ten;
            this.NhaXuatBan = nhaxuatban;
            this.GiaTien = giatien;
            this.SoTrang = sotrang;
        }
        public override string ToString()
        {
            return String.Format("Ten Sach: {0}, Nha Xuat Ban: {1}, Gia Tien: {2}, SoTrang: {3}", Ten, NhaXuatBan,GiaTien, SoTrang);
        }


    }
}
