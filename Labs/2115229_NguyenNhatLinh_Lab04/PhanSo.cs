using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab04
{
    class PhanSo
    {
        private int tu;
        private int mau;

        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }
        public int Mau
        {
            get { return mau; }
            set
            {
                if (value == 0)
                    value = 1;
                mau = value;
            }
        }
        public PhanSo()
        {
            this.Tu = 0;
            this.Mau = 0;
        }
        public PhanSo(int a, int b)
        {
            this.Tu = a;
            this.Mau = b;
        }

        public override string ToString()
        {
            return this.Tu + "/" + this.Mau;

        }
        public void Nhap()
        {
            Console.WriteLine("Nhap tu:");
            this.Tu =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau:");
            this.Mau = int.Parse(Console.ReadLine());
        }

        public int UCLN(int a, int b)
        {
            while (a * b != 0)
            {
                if (a > b)
                {
                    a %= b; 
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }

        public void RutGon()
        {

           int kq = UCLN(this.Tu,this.Mau);
            if(kq!=0)
            {
                this.Tu /= kq;
                this.Mau /= kq;
            }
            
        }
        public static PhanSo operator+ (PhanSo a, PhanSo b)
        {
            PhanSo kq= new PhanSo();
            kq.Tu = a.Tu * b.Mau +b.Tu *a.Mau;
            kq.Mau=a.Mau*b.Mau;
            return kq;
        }
        public static PhanSo operator+(PhanSo a, int b)
        {
            return a + new PhanSo(b, 1);
        }
        public static PhanSo operator +(int b, PhanSo a)
        {
            return a + new PhanSo(b, 1);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = a.Tu * b.Mau - b.Tu * a.Mau;
            kq.Mau = a.Mau * b.Mau;
            return kq;
        }
        public static PhanSo operator -(PhanSo a, int b)
        {
            return a - new PhanSo(b, 1);
        }
        public static PhanSo operator -(int b, PhanSo a)
        {
            return a - new PhanSo(b, 1);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = a.Tu * b.Tu;
            kq.Mau = a.Mau * b.Mau;
            return kq;
        }
        public static PhanSo operator *(PhanSo a, int b)
        {
            return a * new PhanSo(b, 1);
        }
        public static PhanSo operator *(int b, PhanSo a)
        {
            return a * new PhanSo(b, 1);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = a.Tu * b.Mau;
            kq.Mau = a.Mau * b.Tu;
            return kq;
        }
        public static PhanSo operator /(PhanSo a, int b)
        {
            return a / new PhanSo(b, 1);
        }
        public static PhanSo operator /(int b, PhanSo a)
        {
            return a / new PhanSo(b, 1);
        }

        public static PhanSo operator++(PhanSo a)
        {
            return a + 1;
        }
        public static PhanSo operator --(PhanSo a)
        {
            return a - 1;
        }

        public static bool operator >(PhanSo a, PhanSo b)
        {
            return (a.Tu * b.Mau) >( b.Tu * a.Mau);
        }
        public static bool operator <(PhanSo a, PhanSo b)
        {
            return (a.Tu * b.Mau) < (b.Tu * a.Mau);
        }
        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return (a.Tu * b.Mau) >= (b.Tu * a.Mau);
        }
        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return (a.Tu * b.Mau) <= (b.Tu * a.Mau);
        }
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            return (a.Tu * b.Mau) == (b.Tu * a.Mau);
        }
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return (a.Tu * b.Mau) != (b.Tu * a.Mau);
        }

        public static implicit operator PhanSo(int x)
        {
            return new PhanSo(x, 1);    
        }

        public static explicit operator double(PhanSo a)
        {
            return Math.Round((double)a.Tu / (double)a.Mau, 2);
        }
        public PhanSo StrToPS(string a)
        {
            PhanSo b = new PhanSo();
            string []ss = a.Split('/');
            b.Tu = int.Parse(ss[0]);
            b.Mau = int.Parse(ss[1]);
            return b;
        }
    }
}
