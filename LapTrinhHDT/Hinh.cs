using System;
using System.Collections.Generic;
using System.Text;

namespace LapTrinhHDT
{
    class Hinh
    {
        protected string mauSac;
        public virtual double TinhChuVi()
        {
            return 0;
        }
        public virtual void Nhap(string mess)
        {

        }
    }
    interface IAni
    {
        int a();
        int b();
    }
}
