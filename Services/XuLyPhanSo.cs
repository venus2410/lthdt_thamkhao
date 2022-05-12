using System;
using Entities;

namespace Services
{
    public class XuLyPhanSo:IXuLyPhanSo
    {
        public ServiceResult<PhanSo> Cong2PhanSo(int tu1,int mau1,int tu2, int mau2)
        {
            if (mau1 == 0 || mau2 == 0)
            {
                return new ServiceResult<PhanSo>(false, null, "Mau so bang 0");
            }
            PhanSo ps1 = new PhanSo(tu1, mau1);
            PhanSo ps2 = new PhanSo(tu2, mau2);
            return new ServiceResult<PhanSo>(true, ps1.Cong(ps2),"");
        }
    }
}
