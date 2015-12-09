using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixOS.Controls
{
    public partial class PixOSInput : TextBox
    {
        public PixOSInput()
        {
            InitializeComponent();
        }
        public enum Loc
        {
            topLeft,
            topRight,
            topMiddle,

            centerLeft,
            centerRight,
            centerMiddle,

            bottomLeft,
            bottomRight,
            bottomMiddle,
        }
        public Loc center;
        [Description("Where is the text located"), Category("Appearance")]
        public Loc textlayout
        {
            get { return center; }
            set{center = value;}
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            Graphics gfx = pe.Graphics;
           // Rectangle r = ClientRectangle;
           // r.Width = 2;
           // r.Height = 2;
           // gfx.FillRectangle(new SolidBrush(Color), r);

           // r.Width -= 1;
           // r.Height -= 1;
           //// gfx.FillRectangle(new SolidBrush(this.BackColor), r);

            Font font = new Font("Consolas",(float)this.Height,FontStyle.Bold,GraphicsUnit.Pixel);
            
            gfx.DrawString(this.Text, font, new SolidBrush(this.ForeColor), GetPoint());
        }
        public PointF GetPoint()
        {
            PointF ret = new PointF();
            if (center.ToString().Contains("top"))
            {
                ret.Y = 0;
            }
            if (center.ToString().Contains("center"))
            {
                ret.Y = this.Height/2;
            }
            if (center.ToString().Contains("bottom"))
            {
                ret.Y = this.Height;
            }
            if (center.ToString().Contains("right"))
            {
                ret.X = this.Width;
            }
            if (center.ToString().Contains("left"))
            {
                ret.X = 0;
            }
            if (center.ToString().Contains("middle"))
            {
                ret.X = this.Width/2;
            }
            return ret;
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //base.OnPaintBackground(pevent); do nothing!
        }
    }
}
