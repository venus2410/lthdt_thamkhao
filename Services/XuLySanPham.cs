using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Services
{
    public class XuLySanPham:IXuLySanPham
    {
        private ILuuTruSanPham luuSP;
        public XuLySanPham()
        {
            luuSP = new LuuTruSanPham();
        }
        public ServiceResult<bool> ThemSanPham(SanPham sp)
        {
            try
            {
                luuSP.LuuSanPham(sp);
                return new ServiceResult<bool>(true, true, null);
            }
            catch(Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
