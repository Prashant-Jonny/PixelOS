using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Kernel
{
    public class Boot
    {
        public static void Login()
        {
            Console.WriteLine("Username");
            Console.ReadLine();
            Console.WriteLine("Pass");
            Console.ReadLine();
        }
    }
}
