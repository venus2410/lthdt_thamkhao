using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Services
{
    public interface IXuLySanPham
    {
        ServiceResult<bool> ThemSanPham(SanPham sp);
    }
}
