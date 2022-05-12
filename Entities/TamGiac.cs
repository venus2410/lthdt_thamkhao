using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TamGiac
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
        public TamGiac(Diem a, Diem b, Diem c)
        {
            if (this.KiemTraTamGiacHopLe(a, b, c))
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            else
            {
                throw new Exception("Tam giac khong hop le");
            }
        }
        public bool KiemTraTamGiacHopLe(Diem a, Diem b, Diem c)
        {
            double c1 = a.KhoangCach(b);
            double c2 = b.KhoangCach(c);
            double c3 = c.KhoangCach(a);
            return c1 + c2 > c3 && c1 + c3 > c2 && c2 + c3 > c1;
        }
        public double ChuVi()
        {
            return A.KhoangCach(B) + A.KhoangCach(C) + B.KhoangCach(C);
        }
    }
}
