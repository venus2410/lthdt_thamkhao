using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class DaGiac
    {
        public Diem[] DINH { get; set; }

        public void NhapDaGiac(string ghichu)
        {
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap so dinh ");
            int soDinh = int.Parse(Console.ReadLine());
            DINH = new Diem[soDinh];
            for (int i = 0; i < soDinh; i++)
            {
                DINH[i] = new Diem();
                DINH[i].NhapDiem($"Nhap diem {i}");
            }
        }
        public double ChuViDaGiac()
        {
            double kq = 0;
            for (int i = 0; i < DINH.Length - 1; i++)
                kq += DINH[i].KhoangCach(DINH[i + 1]);
            kq += DINH[0].KhoangCach(DINH[DINH.Length - 1]);
            return kq;
        }
    }
}
