using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace LTHDT_web.Pages
{
    public class MH_LuuSanPhamModel : PageModel
    {
        public string chuoi = string.Empty;
        IXuLySanPham xuLy;
        [BindProperty]
        public string maSP { get; set; }
        [BindProperty]
        public string ten { get; set; }
        [BindProperty]
        public int gia { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            try
            {

                SanPham sp = new SanPham(maSP, ten, gia);
                var kq = xuLy.ThemSanPham(sp);
                if (kq.IsSuccess)
                {
                    chuoi = "Luu thanh cong";
                }
                else
                {
                    chuoi = kq.Message;
                }
            }
            catch (Exception ex)
            {
                chuoi = ex.Message;
            }
        }
        public MH_LuuSanPhamModel()
        {
            xuLy = new XuLySanPham();
        }
    }
}
