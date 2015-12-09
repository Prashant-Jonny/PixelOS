using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, Console.LargestWindowHeight);
            Animations.Loading.Play(true);
            Kernel.wm.controls.Add(new Controls.Box(new Data.Point(7, 4), 13, 10, "@", false));
            Kernel.wm.DrawDesktop();
          //  Kernel.Boot.Login();
        }
    }
}
