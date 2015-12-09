using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Animations
{
    public class Loading
    {
        public static bool playing = false;
        public static void Play(bool justonce = false)
        {
            playing = true;
            again:
            if (playing)
            {
                int no = 0;
                while (no != Console.WindowWidth / 3)
                {
                    Console.Clear();
                    int na = no;
                    while (na != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Write("]]]");
                        Console.ResetColor();
                        na--;
                    }
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Write(">");
                    Console.ResetColor();
                    no++;
                    System.Threading.Thread.Sleep(20);
                }
                if (!justonce)
                {
                    goto again;
                }
                else
                {
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
