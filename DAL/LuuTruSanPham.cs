using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruSanPham:ILuuTruSanPham
    {
        public List<SanPham> DocSanPham()
        {
            StreamReader stream = new StreamReader(@"C:\Users\Administrator\source\repos\LapTrinhHDT\LTHDT_web\Data\sanpham.json");
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSSP = JsonConvert.DeserializeObject<List<SanPham>>(jSonString);            
            return dSSP;
        }
        public void LuuDanhSachSanPham(List<SanPham> ds)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\Administrator\source\repos\LapTrinhHDT\LTHDT_web\Data\sanpham.json");
            var str = JsonConvert.SerializeObject(ds);
            writer.Write(str);
            writer.Close();
        }
        public void LuuSanPham(SanPham sanPham)
        {
            var dSSanPham = DocSanPham();
            dSSanPham.Add(sanPham);
            LuuDanhSachSanPham(dSSanPham);
        }
    }
}
