using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelOS
{
    public partial class Form1 : Form
    {
        public List<Frame> FrameQueue = new List<Frame>();
        public int FSkipping = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public static List<T> TakeTill<T>(List<T> input,int c)
        {
            //take till count = c
            List<T> ret = new List<T>();
            int no = input.Count - c;
            while (no != input.Count)
            {
                ret.Add(input[no]);
                no++;
            }
            return ret;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (FrameQueue.Count > FSkipping)
            {
                FrameQueue = TakeTill<Frame>(FrameQueue, FSkipping);
            }
        }
    }
}
