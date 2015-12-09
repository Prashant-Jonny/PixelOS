using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Kernel
{
    public class wm
    {
      //  public static GraphicsHandler gh = null;
        public static int controlwithfocus = 0;
        public static List<Controls.Control> controls = new List<Controls.Control>();
        public static void HandleWMInput(ConsoleKeyInfo k)
        {
            #region key handling
            if (k.Key == ConsoleKey.PageUp)
            {
                controlwithfocus++;
            }
            else if(k.Key==ConsoleKey.PageDown)
            {
                controlwithfocus--;
            }
            else if (k.Key==ConsoleKey.End)
            {
                controls[controlwithfocus].isminimized = !controls[controlwithfocus].isminimized;
            }
            else if (k.Key == ConsoleKey.Home)
            {
                foreach (Controls.Control control in controls)
                {
                    control.isminimized = true;
                }
            }
            else if (k.Key == ConsoleKey.Delete)
            {
                controls.RemoveAt(controlwithfocus);
            }
            /*
             * TODO:
             * window switching (window managing)
             * Drawing/Rendering loop for controls
             * Handle the taskbar control keys (switching programs) {TAB} {NUMBERKEYS?}
             * If textbox has focus, input raw keys into the textbox (input text handling)
             * Maybe remove the BOX's POINT (co-ordinate) feature and let that be handled by the window manager.
             */
            #endregion
            //redraw here
        }
        public static void Redraw()
        {
           // while (true)
            {
               // try
                {
                    foreach (var control in wm.controls)
                    {
                        if (!control.isminimized)
                        {
                            Console.Clear();
                            control.Draw();
                        }
                    }
                }

               // catch { Console.Write("X"); }
                System.Threading.Thread.Sleep(100);
            }
        }
    //}
        public static void DrawDesktop()
        {
            DrawAppBar();
            Redraw();

        }
        public static void DrawAppBar()
        {
            int no = 0;
            foreach (var control in controls)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                if (control.isminimized) Console.BackgroundColor = ConsoleColor.DarkBlue;
                if (control.isfocus) Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("|<["+no + control.GetType() + @"]>|");
                no++;
            }
            Console.Write(Environment.NewLine);
            no = Console.WindowWidth;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            while (no != 0)
            {
                Console.Write("~");
                no--;
            }
            Console.Write(Environment.NewLine);
        }
    }
}
