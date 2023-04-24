using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace _2115229_NguyenNhatLinh_Lab04
{
    class QuanLyPhanSo
    {
        public ArrayList dsPhanSo = new ArrayList();


        public int SoPT
        {
            get {
                return dsPhanSo.Count;
            }


        }

        public QuanLyPhanSo()
        {
            dsPhanSo = new ArrayList();

        }

        public PhanSo Max
        {
            get
            {
                if (dsPhanSo == null || SoPT == 0)
                    throw new Exception("Chua co phan so nao trong mang");
                PhanSo max;
                max = ((PhanSo)dsPhanSo[0]);
                for (int i = 1; i < this.SoPT; i++)
                {
                    if ((PhanSo)dsPhanSo[i] > max)
                    {
                        max = (PhanSo)dsPhanSo[i];
                    }
                }
                return max;
            }
        }

        public PhanSo Min
        {
            get
            {
                if (dsPhanSo == null || SoPT == 0)
                    throw new Exception("Chua co phan so nao trong mang");
                PhanSo min;
                min = ((PhanSo)dsPhanSo[0]);
                for (int i = 1; i < this.SoPT; i++)
                {
                    if ((PhanSo)dsPhanSo[i] < min)
                    {
                        min = (PhanSo)dsPhanSo[i];
                    }
                }
                return min;
            }
        }


        public PhanSo this[int index]
        {
            get { return (PhanSo)this.dsPhanSo[index]; }
            set
            {
                this.dsPhanSo[index] = value;
            }
        }

        public void Them(PhanSo a)
        {
            this.dsPhanSo.Add(new PhanSo(a.Tu, a.Mau));
        }

        public void NhapPS()
        {
            int a;
            int t, m;

            Console.WriteLine("Nhap so luong phan so:");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Nhap phan so thu {0}", i + 1);
                Console.WriteLine("Nhap tu:");
                t = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau:");
                m = int.Parse(Console.ReadLine());
                this.dsPhanSo.Add(new PhanSo(t, m));


            }
        }
        public void NhapCoDinh()
        {
            this.dsPhanSo.Add(new PhanSo(4, 5));
            this.dsPhanSo.Add(new PhanSo(5, 45));
            this.dsPhanSo.Add(new PhanSo(4, 15));
            this.dsPhanSo.Add(new PhanSo(7, 19));
            this.dsPhanSo.Add(new PhanSo(19, 3));
            this.dsPhanSo.Add(new PhanSo(5, 1));
            this.dsPhanSo.Add(new PhanSo(1, 5));
            this.dsPhanSo.Add(new PhanSo(3, 12));
            this.dsPhanSo.Add(new PhanSo(5, 45));
            this.dsPhanSo.Add(new PhanSo(4, 9));
        }

        public void DocFile(string filename)
        {
            try
            {
                
                StreamReader sr = new StreamReader(filename);
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    PhanSo a = new PhanSo();
                    this.dsPhanSo.Add((a.StrToPS(line)));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Loi mo file!");
            }
        }
        public void XuatDSPS()
        {
            Console.WriteLine("{0}||{1}", "STT".ToString().PadRight(10), "PhanSo".ToString().PadLeft(10));
            for (int i = 0; i < this.SoPT; i++)
            {
                Console.WriteLine("{0}||{1}", i.ToString().PadRight(10), dsPhanSo[i].ToString().PadLeft(10));

            }
        }

        public void RutGon()
        {
            for (int i = 0; i < SoPT; i++)
            {
                ((PhanSo)dsPhanSo[i]).RutGon();
            }
        }
        public QuanLyPhanSo TimDSPSCoMau(int x)
        {
            QuanLyPhanSo kq = new QuanLyPhanSo();
            for (int i = 0; i < SoPT; i++)
            {
                if (((PhanSo)dsPhanSo[i]).Mau == x)
                {
                    kq.dsPhanSo.Add(this.dsPhanSo[i]);
                }
            }
            return kq;
        }
        public double TongDSPS()
        {
            PhanSo kq = new PhanSo();
            double sum = 0;
            if (SoPT == 0 || dsPhanSo == null)
                throw new Exception("khong co phan tu nao trong mang");
            for (int i = 0; i < SoPT; i++)
            {
               
                kq =  (PhanSo)dsPhanSo[i];
                sum = sum + (double)kq;
            }
            return sum;
        }
        public QuanLyPhanSo TimDSPSBangX(PhanSo x)
        {
            QuanLyPhanSo kq= new QuanLyPhanSo();

            for(int i=0;i<SoPT;i++)
            {
                if ((PhanSo)dsPhanSo[i] == x)
                {
                    kq.dsPhanSo.Add(this.dsPhanSo[i]);
                }
            }
            return kq;
        }

        public void SapXepDSPSTang()
        {
            PhanSo temp = new PhanSo();
           for(int i=0;i<SoPT-1;i++)
            {
                for (int j = i; j < SoPT; j++)
                {
                    if ((PhanSo)dsPhanSo[i] > (PhanSo)dsPhanSo[j])
                    {
                        temp = (PhanSo)dsPhanSo[i];
                        dsPhanSo[i] = dsPhanSo[j];
                        dsPhanSo[j] = temp;
                    }
                }
            }
        }

        public void SapXepDSPSGiam()
        {
            PhanSo temp = new PhanSo();
            for (int i = 0; i < SoPT - 1; i++)
            {
                for (int j = i; j < SoPT; j++)
                {
                    if ((PhanSo)dsPhanSo[i] < (PhanSo)dsPhanSo[j])
                    {
                        temp = (PhanSo)dsPhanSo[i];
                        dsPhanSo[i] = dsPhanSo[j];
                        dsPhanSo[j] = temp;
                    }
                }
            }
        }

        public void ChenPS(int vt, PhanSo ps)
        {
            this.dsPhanSo.Insert(vt, ps);
        }

        public void XoaPSNhoNhat(PhanSo ps)
        {
            
            this.dsPhanSo.Remove(ps);
            
            
        }

        public void XoaTatCaPSNhoNhat(PhanSo ps)
        {
            

            for (int i = 0; i < SoPT; i++)
            {
                if ((PhanSo)dsPhanSo[i] == ps)
                {
                    this.dsPhanSo.RemoveAt(i);
                }

            }
           
        }
    }
}
