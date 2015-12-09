using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Controls
{
    public class Box:Control
    {
        public bool isminimized { get; set; }
        public bool isfocus { get; set; }
        public bool needRedraw { get; set; }

        public Data.Point topleft = new Data.Point();
        public int width = 0;
        public int height = 0;
        public string sym = "#";
        public bool fill = false;

        public Box(Data.Point p, int w, int h, string s = "#", bool f = false)
        {
            fill = f;
            sym = s;
            topleft = p;
            width = w;
            height = h;
        }
        public void OnFocus()
        {
        }
        public void Draw()
        {
            Data.Point initialpos = new Data.Point();
            // Data.Point curpos = topleft;
            if (fill)
            {
                int no = height;
                while (no > 0)
                {
                    Data.Point curpos = topleft;
                    int na = width;
                    while (na > 0)
                    {
                        curpos.SetConsoleCursorPos();
                        Console.Write(sym);
                        curpos.left++;
                        na--;
                    }
                    no--;
                    curpos.top++;
                    curpos.left = topleft.left-width;
                }
            }
            else
            {
                //top
                Data.Point curpos = topleft;
                int no = width;
                while (no > 0)
                {
                    curpos.SetConsoleCursorPos();
                    Console.Write(sym);//top
                    new Data.Point(Console.CursorLeft-1, Console.CursorTop+(height-1)).SetConsoleCursorPos();
                    Console.Write(sym);//bottom
                    curpos.left++;
                    no--;
                }

                no = height;
                curpos = topleft;
                curpos.left--;
                while(no !=0)
                {
                    curpos.SetConsoleCursorPos();
                    Console.Write(sym);//left
                    Console.SetCursorPosition(Console.CursorLeft - width, Console.CursorTop);
                    Console.Write(sym);//right
                    curpos.top++;
                    no--;
                }
            }
            //revert the consolepos
            initialpos.SetConsoleCursorPos();
        }
    }
}
