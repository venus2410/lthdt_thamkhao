using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace LTHDT_web.Pages
{
    public class MH_TinhChuViTamGiacModel : PageModel
    {
        public string chuoi = string.Empty;
        public double ChuVi { get; set; }
        IXuLyTamGiac xuLyTamGiac;
        public void OnGet()
        {
            var kq = xuLyTamGiac.TinhChuVi();
            if (kq.IsSuccess)
            {
                chuoi = $"Ket qua la: {kq.Data}";
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public MH_TinhChuViTamGiacModel()
        {
            xuLyTamGiac = new XuLyTamGiac();
        }
    }
}
