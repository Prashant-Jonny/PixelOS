using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Data
{
    public class Point
    {
        public int top = 0;
        public int left = 0;
        public Point(int l, int t)
        {
            top = t; left = l;
        }
        public Point(bool console=true)
        {
            top = Console.CursorTop; left = Console.CursorLeft;
        }
        public void SetConsoleCursorPos()
        {
            Console.SetCursorPosition(left, top);
        }
    }
}
