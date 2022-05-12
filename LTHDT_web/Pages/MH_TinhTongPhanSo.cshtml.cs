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
    public class MH_TinhTongPhanSoModel : PageModel
    {
        public string chuoi=string.Empty;
        IXuLyPhanSo xuLy;
        [BindProperty]
        public int ts1 { get; set; }
        [BindProperty]
        public int ms1 { get; set; }
        [BindProperty]
        public int ts2 { get; set; }
        [BindProperty]
        public int ms2 { get; set; }
        public void OnGet()
        {
            
        }
        public MH_TinhTongPhanSoModel()
        {
            xuLy = new XuLyPhanSo();
        }
        public void OnPost()
        {
            var kq = xuLy.Cong2PhanSo(ts1, ms1, ts2, ms2);
            if (kq.IsSuccess)
            {
                chuoi = kq.Data.Xuat();
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
