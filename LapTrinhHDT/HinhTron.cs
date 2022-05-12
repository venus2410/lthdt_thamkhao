using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class HinhTron : Hinh
    {
        public int X { get; set; }
        public int Y { get; set; }
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set
            {
                if(value>=0)
                {
                    banKinh = value;
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
            Console.Write("ban kinh: ");
            BanKinh = int.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return Math.PI * BanKinh;
        }

    }
}
