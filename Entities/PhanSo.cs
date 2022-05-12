using System;

namespace Entities
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        private int MauSo;
        public int MAUSO
        {
            get
            {
                return MauSo;
            }
            set
            {
                if (value != 0)
                {
                    MauSo = value;
                }
            }

        }
        public PhanSo()
        {
            // khoi tao gia tri ban dau cho doi tuong
            this.TuSo = 0;
            this.MauSo = 1;
        }
        public PhanSo(int a)
        {
            // khoi tao gia tri ban dau cho doi tuong
            this.TuSo = a;
            this.MauSo = 1;
        }
        public PhanSo(int a, int b)
        {
            // khoi tao gia tri ban dau cho doi tuong
            this.TuSo = a;
            if (b != 0)
            {
                this.MauSo = b;
            }
            else this.MauSo = 1;
        }

        public PhanSo Cong(PhanSo b)
        {            
            PhanSo kq = new PhanSo();
            kq.TuSo = this.TuSo * b.MAUSO + b.TuSo * this.MAUSO;
            kq.MAUSO = this.MAUSO * b.MAUSO;
            return kq;
        }
        public string Xuat()
        {
            return $"{TuSo}/{MAUSO}";
        }
    }
}
