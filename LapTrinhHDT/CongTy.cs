using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class CongTy
    {
        public string TenCongTy;
        public List<NhanVien> DanhSachNV { get; set; }
        public CongTy()
        {
            DanhSachNV = new List<NhanVien>();
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap Ten cty");
            TenCongTy = Console.ReadLine();
            Console.WriteLine("Nhap so nhan vien");
            int soNV = int.Parse(Console.ReadLine());
            for(int i=0;i<soNV;i++)
            {
                Console.WriteLine("Nhap loai nhan vien 1. VP, 2. SX");
                int loaiNV = int.Parse(Console.ReadLine());
                NhanVien nhanVien;
                if (loaiNV==1)
                {
                    nhanVien = new NhanVienVanPhong();
                }
                else
                {
                    nhanVien = new NhanVienSanXuat();
                }
                //Da hinh
                nhanVien.NhapNhanVien($"Nhan vien thu {i}");
                DanhSachNV.Add(nhanVien);
            }
        }
        public double TinhLuong()
        {
            double luong = 0;
            foreach(NhanVien i in DanhSachNV)
            {
                luong += i.TinhLuong();
            }
            return luong;
        }
    }
}
