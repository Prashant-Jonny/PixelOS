using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixOSTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.MessageBox m = new UI.MessageBox("moo eoeo eoeihsdoi oiasgdoaisgd s isest fam", "OK", "Cancel", "Abort");
            m.Show();
            bool done = false;
            while (!done)
            {
                ConsoleKeyInfo k = Console.ReadKey();
                if (k.Key == ConsoleKey.LeftArrow)
                {
                    m.selbutton--;
                }
                if (k.Key == ConsoleKey.RightArrow)
                {
                    m.selbutton++;
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    done = true;
                }
                Console.Clear();
                m.Show();
            }

        }
    }
}
