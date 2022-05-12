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
    public class MH_LuuTruTamGiacModel : PageModel
    {
        public string chuoi = string.Empty;
        IXuLyTamGiac luuTru;
        [BindProperty]
        public int x1 { get; set; }
        [BindProperty]
        public int y1 { get; set; }
        [BindProperty]
        public int x2 { get; set; }
        [BindProperty]
        public int y2 { get; set; }
        [BindProperty]
        public int x3 { get; set; }
        [BindProperty]
        public int y3 { get; set; }

        public void OnGet()
        {
        }
        public MH_LuuTruTamGiacModel()
        {
            luuTru = new XuLyTamGiac();
        }
        public void OnPost()
        {
            try
            {
                Diem d1 = new Diem(x1, y1);
                Diem d2 = new Diem(x2, y2);
                Diem d3 = new Diem(x3, y3);
                TamGiac tg = new TamGiac(d1, d2, d3);
                var kq=luuTru.LuuTamGiac(tg);
                if (kq.IsSuccess)
                {
                    chuoi = "Luu thanh cong";
                }
                else
                {
                    chuoi = kq.Message;
                }
            }
            catch(Exception ex)
            {
                chuoi = ex.Message;
            }
        }
    }
}
