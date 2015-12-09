using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelOS.Controls
{
    public interface Control
    {
        bool isfocus { get; set; }
        bool isminimized { get; set; }
        void Draw();
        void OnFocus();
    }
}
