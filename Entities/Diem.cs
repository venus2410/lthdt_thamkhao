using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Diem
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Diem()
        {

        }
        public Diem(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
       
        public double KhoangCach(Diem a)
        {
            return Math.Sqrt((a.X - this.X) * (a.X - this.X) + (a.Y - this.Y) * (a.Y - this.Y));
        }
    }
}
