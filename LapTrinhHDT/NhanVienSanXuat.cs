using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class NhanVienSanXuat:NhanVien
    {
        private int SoSanPham;
        public int SOSANPHAM
        {
            get { return SoSanPham; }
            set
            {
                if(value>=0)
                {
                    SoSanPham = value;
                }
            }
        }
        public override void NhapNhanVien(string mess)
        {
            base.NhapNhanVien(mess);
            Console.WriteLine("Nhap so san pham");
            SOSANPHAM = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return SoSanPham * 100;
        }
    }
}
