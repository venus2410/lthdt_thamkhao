using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class TamGiac
    {
        public Diem A { get; set; }
        public Diem B { get; set; }
        public Diem C { get; set; }

        public TamGiac()
        {
            this.A = new Diem(0, 0);
            this.B = new Diem(0, 1);
            this.C = new Diem(1, 0);
        }
        public TamGiac(Diem a,Diem b, Diem c)
        {
            if (this.KiemTraTamGiacHopLe(a, b, c))
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                this.A = new Diem(0, 0);
                this.B = new Diem(0, 1);
                this.C = new Diem(1, 0);
            }
        }
        public bool KiemTraTamGiacHopLe(Diem a, Diem b, Diem c)
        {
            double c1 = a.KhoangCach(b);
            double c2 = b.KhoangCach(c);
            double c3 = c.KhoangCach(a);
            return c1 + c2 > c3 && c1 + c3 > c2 && c2 + c3 > c1;
        }
        public void NhapTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this.A = new Diem();
            this.B = new Diem();
            this.C = new Diem();

            A.NhapDiem("Moi nhap diem A ");
            B.NhapDiem("Moi nhap diem B ");
            C.NhapDiem("Moi nhap diem C ");
        }
        public double ChuVi()
        {
            return A.KhoangCach(B) + A.KhoangCach(C) + B.KhoangCach(C);
        }
    }
}
