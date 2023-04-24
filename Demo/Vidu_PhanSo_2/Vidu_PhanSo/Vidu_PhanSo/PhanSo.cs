using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidu_PhanSo
{
    class PhanSo
    {
        public int Tu { get; set; }
        private int mau;
        public int Mau
        {
            get { return mau; }
            set {
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
        public PhanSo(int tu, int mau)
        {

            this.Tu = tu;
            this.Mau = mau;
        }

        public override string ToString()
        {
            return this.Tu + "/" + this.Mau;
        }

        public static PhanSo operator+(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = ps1.Tu * ps2.Mau + ps1.Mau * ps2.Tu;
            kq.Mau = ps1.Mau * ps2.Mau;
            return kq;
        }

        public static PhanSo operator +(PhanSo ps, int x)
        {
            /*PhanSo kq = new PhanSo();
            kq.Tu = ps.Tu + ps.Mau * x;
            kq.Mau = ps.Mau;
            return kq;*/

            return ps + new PhanSo(x, 1);

        }

        public static PhanSo operator +(int x, PhanSo ps)
        {
            /*PhanSo kq = new PhanSo();
            kq.Tu = ps.Tu + ps.Mau * x;
            kq.Mau = ps.Mau;
            return kq;*/

            return ps + x;

        }

        public static PhanSo operator ++(PhanSo ps)
        {
            return ps + 1;
        }

        public static bool operator ==(PhanSo ps1, PhanSo ps2)
        {
           
            return ps1.Tu*ps2.Mau == ps1.Mau*ps2.Tu;
        }
        public static bool operator !=(PhanSo ps1, PhanSo ps2)
        {
            return ps1.Tu * ps2.Mau != ps1.Mau * ps2.Tu;
        }

        public static implicit operator PhanSo(int x)
        {
            return new PhanSo(x, 1);
        }

        public static explicit operator double(PhanSo ps)
        {
            return Math.Round( (double)ps.Tu / ps.Mau, 2);
        }

        public PhanSo StrToPhanSo(string line)
        {
            string[] ss = line.Split('/');//"1/3"
            this.Tu = int.Parse(ss[0]);
            this.Mau = int.Parse(ss[1]);
            return this;
        }
    }
}
