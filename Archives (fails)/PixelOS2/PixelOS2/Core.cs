using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS2
{
    public class Core
    {
        static void Main()
        {
         //   Console.WriteLine("foo");
            int no = 0;
            while (no != Console.WindowWidth)
            {
                new PixelOS2.Graphics.Line(new Graphics.Point(0, 0), new Graphics.Point(no, Console.WindowHeight)).Draw();
                System.Threading.Thread.Sleep(300);
                Console.Clear();
                no++;
            }
        }
    }
}
