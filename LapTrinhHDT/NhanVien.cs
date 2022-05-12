using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class NhanVien
    {
        protected string MaNhanVien { get; set; }
        protected string TenNhanVien { get; set; }
        
        public virtual void NhapNhanVien(string mess)
        {
            Console.WriteLine(mess);
            Console.WriteLine("Nhap MaNV");
            MaNhanVien = Console.ReadLine();
            Console.WriteLine("Nhap TenNV");
            TenNhanVien = Console.ReadLine();
        }
        public virtual double TinhLuong()
        {
            return 0;
        }
    }
}
