using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Kernel
{
    public class InputHandler
    {
        public static bool GettingInput = false;
        public static void InputLoop()
        {
            while (GettingInput)
            {
                ConsoleKeyInfo k = Console.ReadKey(); // "/" key = kill
            }
        }
    }
}
