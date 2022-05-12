using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class Diem
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Diem()
        {

        }
        public Diem(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void NhapDiem(string thongDiep)
        {
            Console.WriteLine(thongDiep);
            Console.WriteLine("Moi nhap x ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap y ");
            Y = int.Parse(Console.ReadLine());
        }
        public double KhoangCach(Diem a)
        {
           return Math.Sqrt((a.X - this.X) * (a.X - this.X) + (a.Y - this.Y)*(a.Y - this.Y));
        }
    }
}
