using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS2.Graphics
{
    public class Point
    {
        public int x=0;
        public int y=0;
        public Point()
        {
        }
        public Point(int xx, int yy)
        {
            x = xx;
            y = yy;
        }
        public double DistanceTo(Point p)
        {
            return Math.Sqrt(Math.Pow((Math.Abs(x-p.x)),2)+Math.Pow((Math.Abs(y-p.y)),2));
        }

    }
}
