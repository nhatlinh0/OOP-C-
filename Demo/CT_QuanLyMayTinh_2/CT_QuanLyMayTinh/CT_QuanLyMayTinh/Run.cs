using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_QuanLyMayTinh
{
    class Run
    {
        static void Main()
        {
            QuanLyMayTinh ql = new QuanLyMayTinh();
            ql.NhapCD();
            Console.WriteLine(ql);
            // ql.SapXep(KieuSapXep.SapGiamTheoNSX);
            //ql.SapXepDelegate(Run.SoSanhTheoGia);
            //Console.WriteLine("Danh sach tang theo gia:{0}", ql);

            ql.kieusx = KieuSapXep.SapGiamTheoNSX;
            ql.SapXepList();
            Console.WriteLine("Danh sach giam theo nam sx:{0}", ql);


        }
        static int SoSanhTheoGia(object x, object y)
        {
            MayTinh mt1 = (MayTinh)x;
            MayTinh mt2 = (MayTinh)y;
            return mt1.Gia.CompareTo(mt2.Gia);
        }


    }
}
