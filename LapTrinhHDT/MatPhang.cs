using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class MatPhang
    {
        public List<Hinh> DSHinh { get; set; }

        public MatPhang()
        {
            DSHinh = new List<Hinh>();
        }
        public void NhapDSHinh(string mes)
        {
            Console.WriteLine("Nhap so hinh: ");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Nhap hinh thu {i + 1}");
                Console.WriteLine("nhap loai hinh 1/hinh tron 2/hinh chu nhat");
                int loaiHinh = int.Parse(Console.ReadLine());
                Hinh a;
                if(loaiHinh==1)
                {
                    a = new HinhTron();
                }
                else
                {
                    a = new HinhChuNhat();
                }
                a.Nhap("");
                DSHinh.Add(a);
            }
        }
        public double TinhTongChuVi()
        {
            double cv = 0;
            foreach(Hinh h in DSHinh)
            {
                cv += h.TinhChuVi();
            }
            return cv;
        }
    }
}
