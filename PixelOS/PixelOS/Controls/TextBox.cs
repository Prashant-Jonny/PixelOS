using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Controls
{
    public class TextBox:Control
    {
       // public bool actualisfocus = true;
       // public bool isfocus=true;//{get{return auc;}set { isminimized = value; }}
        //   public bool isminimized=true;//{get{return isminimized;}set{isminimized = value;}} そして、トイレカバー! \(^n^ \)
        public bool isminimized { get; set; }
        public bool isfocus { get; set; }
        public bool needRedraw { get; set; }

        public string Text = "";
        public Box box = null;
        public TextBox(Box b)
        {
            box = b;
            box.fill = true;
        }
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            box.Draw();
            Console.ResetColor();
        }
        public void OnFocus()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            box.Draw();
            Console.ResetColor();
        }
        public void AppendChar(char c)
        {
            if (char.IsLetterOrDigit(c))
            {
                Text += c;
            }
            OnFocus();
        }
    }
}
