using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Stages
{
    public class GFXSettings
    {
        public void Start()
        {
            ControlData.ChooseList chlist = new ControlData.ChooseList();
            chlist.Append(new ControlData.TogButton("foo"),new ControlData.TogButton("joo"));
        }
    }
}
