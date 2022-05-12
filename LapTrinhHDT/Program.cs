using System;

namespace LapTrinhHDT
{
    class Program
    {
        static void Main(string[] args)
        {
            MatPhang MP = new MatPhang();
            MP.NhapDSHinh("");
            Console.WriteLine($"tong chu vi la: {MP.TinhTongChuVi()}");
        }
    }
}
