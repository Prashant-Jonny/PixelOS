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
      //     Kernel.wm.gh = new Kernel.GraphicsHandler();
          //  new System.Threading.Thread(() => Kernel.wm.gh.RedrawLoop()).Start();
            Console.SetWindowSize(150, Console.LargestWindowHeight);
            Animations.Loading.Play(true);
            Kernel.wm.controls.Add(new Controls.Box(new Data.Point(7, 4), 13, 10, "@", false));
            while (true)
            {
                Kernel.wm.DrawDesktop();
                System.Threading.Thread.Sleep(200);//TODO REDO THE CONTROLS AND THIS TIME INCORPERATE ASCII SYMBOLS TO MAKE IT LOOK FANCY.
            }
          //  Kernel.Boot.Login();
        }
    }
}
