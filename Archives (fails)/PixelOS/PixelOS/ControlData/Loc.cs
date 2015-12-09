using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.ControlData
{
    public class Loc
    {
        public int top = 0;
        public int left = 0;
        public Loc() { }public Loc(int l, int t) { top = t; left = l; }
        public double DistanceTo(Loc l)
        {
            return Math.Sqrt(
                Math.Pow(Math.Abs(this.left - l.left), 2) +
                Math.Pow(Math.Abs(this.top- l.top), 2)
                );
        }
    }
}
