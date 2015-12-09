using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Utils
{
    public class ControlUtils
    {
        public static void DrawLine(ControlData.Loc l1, ControlData.Loc l2, string fill)
        {
            ControlData.Loc curpos = new ControlData.Loc(Console.CursorLeft, Console.CursorTop);
            ControlData.Loc cur = new ControlData.Loc(l1.left,l1.top);
            Console.SetCursorPosition(cur.left, cur.top);
            Console.Write(fill);
            int no = 0;
            int na = 0;
            bool done = false;
          //  int points = (int)Math.Floor(cur.DistanceTo(l2));
            while (cur.top != l2.top)
            {
                na = 0;
                while (cur.left != l2.left)
                {
                    cur.left = na;
                    cur.top = no;
                    Console.SetCursorPosition(cur.left, cur.top);
                    Console.Write(fill);
                    na++;
                }
                no++;
            }
            Console.SetCursorPosition(curpos.left, curpos.top);
            return;
        }
    }
}
