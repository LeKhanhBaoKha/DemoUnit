using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhanSo
{
    public class PhanSo
    {
        private int tu;
        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }

        private int mau;
        private PhanSo kq;

        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kg;
            kq = new PhanSo();
            kq.tu = tu * p.mau + mau * p.tu;
            kq.mau = mau * p.mau;
            return kq.RutGon();
        }

        public PhanSo Tru(PhanSo p)
        {
            PhanSo kg;
            kq = new PhanSo();
            kq.tu = tu * p.mau + mau * p.tu;
            kq.mau = mau * p.mau;
            return kq.RutGon();
        }
        public PhanSo Chia(PhanSo p)
        {
            if (p.tu == 0)
                throw new DivideByZeroException();
            PhanSo kq;
            kq = new PhanSo();
            kq.tu = tu * p.mau;
            kq.mau = mau * p.tu;
            return kq.RutGon();
        }

        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tu = tu * p.tu;
            kq.mau = mau * p.mau;
            return kq.RutGon();
        }

        public PhanSo RutGon()
        {
            int mc = TimMauChung(tu, mau);
            tu /= mc;
            mau /= mc;
            return this;
        }

        private int TimMauChung(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
