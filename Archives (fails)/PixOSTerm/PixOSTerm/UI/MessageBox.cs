using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixOSTerm.UI
{
    class MessageBox
    {
        string text;
        public int selbutton = -1;
        public string[] buttontext;
        public MessageBox(string s, params string[] b)
        {
            buttontext = b;
            text = s;
        }
        public void MessageBoxColourReset()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        public string Centertext(string raw)
        {
            string ret = "";
            return ret;
        }
        public void DrawText()
        {
            int leftbefore = Console.CursorLeft;
            int topbefore = Console.CursorTop;
            //foreach (var word in text.Split(' '))
            {
                Console.SetCursorPosition((Console.WindowWidth / 2) - text.Replace(Environment.NewLine, " ").Length + text.Replace(Environment.NewLine, " ").Length/2, (Console.WindowHeight / 2) - text.Replace(Environment.NewLine, " ").Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Count());
                //foreach (var ch in text)
                //{
                //    Console.Write(ch);
                //    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
                //}
                Console.Write(text.Replace(Environment.NewLine," "));
                int no = 0; 
                foreach(var line in text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    Console.SetCursorPosition(((Console.WindowWidth / 2) - line.Length) + 5, ((Console.WindowHeight / 2) - text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Count())+no);
                   // Console.Write(line);
                }
            }
            Console.SetCursorPosition(leftbefore, topbefore);
        }
        public void DrawButton()
        {
            int leftbefore = Console.CursorLeft;
            int topbefore = Console.CursorTop;
            int no = 0;
            Console.SetCursorPosition(1, Console.WindowHeight - 3);
            Console.Write("Options: ");
            foreach (var item in buttontext)
            {
                if (no == selbutton) { Console.ForegroundColor = ConsoleColor.Blue; }
                Console.Write(item +" ");
                Console.ForegroundColor = ConsoleColor.Black;
                no++;
            }
            Console.SetCursorPosition(leftbefore, topbefore);
        }
        public void Show(bool colour = true)
        {
            int no = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Blue;
            while (no != Console.WindowWidth)
            {
                Console.Write("#");
                no++;
            }
            int na = 0;
            while (na != Console.WindowHeight-3)
            {
                //Console.Write(Environment.NewLine);
                Console.Write("#");
                MessageBoxColourReset();
                string line = "";
                no = 0;
                while (no != Console.WindowWidth - 2)
                {
                    line += ".";
                    no++;
                }
                Console.Write(line);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("#");
                na++;
            }
            no = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Blue;
            while (no != Console.WindowWidth)
            {
                Console.Write("#");
                no++;
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            DrawText();
            DrawButton();
            Console.ResetColor();

        }
    }
}
