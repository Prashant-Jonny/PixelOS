using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.ControlData
{
    public class ChooseList
    {
        private List<TogButton> buttons = new List<TogButton>();
        public int maxchoices = 1;
        public List<TogButton> curselected()
        {
            List<TogButton> ret = new List<TogButton>();
            foreach (var button in buttons)
            {
                if (button.IsDown)
                {
                    ret.Add(button);
                }
            }
            return ret;
        }
        public void Append(TogButton tb)
        {
            buttons.Add(tb);
        }
        public void Append(params TogButton[] tb)
        {
            buttons.AddRange(tb);
        }
    }
    public class TogButton
    {
        public TogButton() { }
        public TogButton(string text)
        {
            Togtext = text;
        }
        public string Togtext = "button";
        public bool IsDown = false;
    }
}
