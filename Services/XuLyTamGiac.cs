using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Services
{
    public class XuLyTamGiac:IXuLyTamGiac
    {
        public ILuuTruTamGiac LuuTruTamGiac;
        public XuLyTamGiac()
        {
            LuuTruTamGiac = new LuuTruTamGiac();
        }
        public ServiceResult<double> TinhChuVi()
        {
            try
            {
                TamGiac tg = LuuTruTamGiac.DocTamGiac();
                var result = tg.ChuVi();
                return new ServiceResult<double>(true, result, null);
            }
            catch(Exception ex)
            {
                return new ServiceResult<double>(false, 0, ex.Message);
            }
        }
        public ServiceResult<bool> LuuTamGiac(TamGiac tg)
        {
            try
            {
                LuuTruTamGiac.LuuTamGiac(tg);
                return new ServiceResult<bool>(true, true, "");
            }
            catch(Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
