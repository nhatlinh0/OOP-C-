using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Vidu_PhanSo
{
    class QuanLyPhanSo
    {
        ArrayList dsPhanSo = new ArrayList();

        public QuanLyPhanSo()
        {
            dsPhanSo = new ArrayList();
        }

        public int Count
        {
            get { return dsPhanSo.Count; }
        }
        public PhanSo this[int index]
        {
            get { return (PhanSo)this.dsPhanSo[index]; }
            set { this.dsPhanSo[index] = value; }
        }

        public void Them(PhanSo ps)
        {
            this.dsPhanSo.Add(ps);

        }
        public void DocFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    PhanSo ps = new PhanSo();
                    this.Them(ps.StrToPhanSo(line));
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Loi doc file (Co the file khong ton tai)");
            }

        }

        public PhanSo getIndex(int id)
        {
            return (PhanSo)this.dsPhanSo[id];

        }
        public override string ToString()
        {
            string s = "";
            foreach (var ps in this.dsPhanSo)
                s += ps + "\t";
            return s;
        }

        public void XoaTaiViTri(int vitri)
        { 
            this.dsPhanSo.RemoveAt(vitri);
            this.dsPhanSo.Remove(new PhanSo(4, 5));
            this.dsPhanSo.Insert(vitri, new PhanSo(4, 5));  
            this.dsPhanSo.IndexOf(new PhanSo(4, 5));
            this.dsPhanSo.LastIndexOf(new PhanSo(4, 5));
            this.dsPhanSo.Sort();
        }
    }
}
