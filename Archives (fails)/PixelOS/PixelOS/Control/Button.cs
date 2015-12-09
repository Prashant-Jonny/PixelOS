using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelOS.ControlData;

namespace PixelOS.Control
{
    public class Button
    {
        public ControlData.TogButton data = new ControlData.TogButton();
        public ControlData.Loc l = new ControlData.Loc();
        public Size s = new Size();
        public void Paint()
        {
        }
    }
}
