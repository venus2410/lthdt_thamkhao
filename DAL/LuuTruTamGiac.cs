using System;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruTamGiac:ILuuTruTamGiac
    {
        public TamGiac DocTamGiac()
        {
            StreamReader stream = new StreamReader(@"C:\Users\Administrator\source\repos\LapTrinhHDT\LTHDT_web\Data\tamgiac.json");
            string jSonString = stream.ReadToEnd();
            var tg = JsonConvert.DeserializeObject<TamGiac>(jSonString);
            stream.Close();
            return tg;
        }
        public void LuuTamGiac(TamGiac tamGiac)
        {
            StreamWriter stream = new StreamWriter(@"C:\Users\Administrator\source\repos\LapTrinhHDT\LTHDT_web\Data\tamgiac.json");
            var str = JsonConvert.SerializeObject(tamGiac);
            stream.Write(str);
            stream.Close();
        }
    }
}
