using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
            //string[] foo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
            //foreach (var item in Form1.TakeTill<string>(foo.ToList(), 2))
            {
             //   Console.WriteLine(item);
            }
            while (true)
            {
                Console.Clear();
                Utils.ControlUtils.DrawLine(new ControlData.Loc(0, 0), new ControlData.Loc(Int32.Parse(Console.ReadKey().KeyChar.ToString()), Int32.Parse(Console.ReadKey().KeyChar.ToString())), "#");
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}
