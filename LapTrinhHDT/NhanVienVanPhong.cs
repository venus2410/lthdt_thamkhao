using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class NhanVienVanPhong:NhanVien
    {
        private int NgayCong { get; set; }
        private int TangCa { get; set; }
        
        public override void NhapNhanVien(string mess)
        {
            base.NhapNhanVien(mess);
            Console.WriteLine("Nhap so ngay cong");
            NgayCong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tang ca");
            TangCa = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return NgayCong * 1000+TangCa*500;
        }
    }
}
