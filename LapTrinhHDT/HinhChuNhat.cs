using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class HinhChuNhat : Hinh
    {
        private int chieuDai;
        private int chieuRong;
        public int ChieuDai
        {
            get { return chieuDai; }
            set
            {
                if (value >= 0)
                {
                    chieuDai = value;
                }
            }
        }
        public int ChieuRong
        {
            get { return chieuRong; }
            set
            {
                if (value >= 0)
                {
                    chieuRong = value;
                }
            }
        }
        public string MauSac
        {
            get { return MauSac; }
            set { mauSac = value; }
        }
        public override void Nhap(string mess)
        {
            Console.WriteLine(mess);
            Console.Write("Chieu dai: ");
            ChieuDai = int.Parse(Console.ReadLine());
            Console.Write("\nChieu rong: ");
            ChieuRong = int.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }
    }
}
