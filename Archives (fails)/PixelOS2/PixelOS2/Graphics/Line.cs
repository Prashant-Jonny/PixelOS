using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS2.Graphics
{
    public class Line
    {
        public Point start = new Point();
        public Point end = new Point();
        public Line() { }public Line(Point p1, Point p2){start=p1;end=p2;}

        public void Draw()
        {
            try
            {
                Point stpos = new Point(Console.CursorLeft, Console.CursorTop);
                int curx = start.x;
                int dx = Math.Abs(start.x - end.x);
                int dy = Math.Abs(start.y - end.y);
                while (curx != end.x)
                {
                    int y = start.y + dy * (curx - start.x) / dx;
                    Console.SetCursorPosition(curx, y);
                    Console.Write("#");

                    curx++;
                }

            }
            catch { }
        }
    }
}
