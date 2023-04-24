using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab07
{
    class TapChi:IAnPham
    {
        public string diachi;
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

        public TapChi()
        {

        }

        public TapChi(string line)
        {
            string[] ss= line.Split(',');
            this.Ten = ss[1];
            this.NhaXuatBan = ss[2];
            this.GiaTien = int.Parse(ss[3]);
            this.diachi = ss[4];
        }

        public TapChi(string ten, string nhaXuatBan, float giaTien, string diachi)
        {
            this.Ten = ten;
            this.NhaXuatBan = NhaXuatBan;
            this.GiaTien = giaTien;
            this.diachi = diachi;
        }
        public void Nhap()
        {
            string ten;
            string nhaxuatban;
            float giatien;
            string dc;
            Console.WriteLine("Nhap Ten Tap chi:");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap nha xuat ban:");
            nhaxuatban = Console.ReadLine();
            Console.WriteLine("Nhap gia tien:");
            giatien = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dia chi:");
            dc = Console.ReadLine();
            this.Ten = ten;
            this.NhaXuatBan = nhaxuatban;
            this.GiaTien = giatien;
            this.diachi = dc;
        }
        public override string ToString()
        {
            return string.Format("Ten Tap Chi: {0}, Nha Xuat Ban: {1}, Gia Tien: {2}, Dia Chi: {3}", Ten, NhaXuatBan, GiaTien, diachi);
        }


    }
}
