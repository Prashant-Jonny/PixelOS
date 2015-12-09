using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixOS
{
    public partial class Form1 : Form
    {
        public TextBox Console;
        public Panel Login;
        public bool animdone = false;
        public string workdir = "OS";
        public string FileDir = "OS/Files";
        public Form1()
        {
            InitializeComponent();
            Console = InitializeConsole();
           // Screen.Controls.Remove(this.Login);
            Login = InitializeLogin();
            Screen.Controls.Add(Login);
        }
        public void Setup()
        {
            SetupFileSystem();
        }
        public void SetupFileSystem()
        {
            Console.Text += "Setting up file system:"+Environment.NewLine;
            if (!new System.IO.DirectoryInfo(FileDir).Exists)
            {
                System.IO.DirectoryInfo d =new System.IO.DirectoryInfo(FileDir);
                d.Create();
                Console.Text += "Created filedir at: " + d.FullName+Environment.NewLine;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Screen.Controls.Add(Console);
            Login.SendToBack();
            Console.BringToFront();
            Console.Text += "Loading:"+Environment.NewLine;
            Setup();
            Console.Text += "Done Loading!" + Environment.NewLine;
            Console.Select(0, 0);
            new System.Threading.Thread(
           () => Anim()
               ).Start();
        }
        public void Anim()
        {
            while (!animdone)
            {
                System.Threading.Thread.Sleep(1000);
                string[] Frames = new string[] { "\r\n                               \r\n _____ _         _ _____ _____ \r\n|  _  |_|_ _ ___| |     |   __|\r\n|   __| |_'_| -_| |  |  |__   |\r\n|__|  |_|_,_|___|_|_____|_____|\r\n       ", "                               \r\n _____ _         _ _____ ____* \r\n|  _  |_|_ _ ___| |     |   __|\r\n|   __| |_'_| -_| |  |  |__   |\r\n|__|  |_|_,_|___|_|_____|_____*\r\n        ", "                               \r\n _____ _         _ _____ __-*` \r\n|  _  |_|_ _ ___| |     |   __|\r\n|   __| |_'_| -_| |  |  |__   |\r\n|__|  |_|_,_|___|_|_____|___-*`\r\n                               ", "                               \r\n _____ _         _ _____ _-*` \r\n|  _  |_|_ _ ___| |     |   __|\r\n|   __| |_'_| -_| |  |  |__   |\r\n|__|  |_|_,_|___|_|_____|__-*`\r\n                               ", "                               \r\n _____ _         _ _____=-*` \r\n|  _  |_|_ _ ___| |     |   _-*\r\n|   __| |_'_| -_| |  |  |__   -\r\n|__|  |_|_,_|___|_|_____-=*`\r\n                               ", "                               \r\n _____ _         _ __--+` \r\n|  _  |_|_ _ ___| |       _+\r\n|   __| |_'_| -_| |  |  |_ -*\r\n|__|  |_|_,_|___|_|___=-*`\r\n                               ", "                               \r\n _____ _     --+` \r\n|  _  |_|_ _ __ ^    \r\n|   __| |_'_| -_|  .+\r\n|__|  |_|_,_|___-=-*`\r\n                               ", "                               \r\n ___-_+` \r\n|  _  *-- \"    \r\n|   __| -| - .+\r\n|__|  |_|__.\\`\r\n                               ", " \r\n\r\n.  *   \r\n/   =^ .+\r\n|/|  .\\`                               ", " \r\n\r\n.   \r\n-\r\n.                        " };

                foreach (var item in Frames)
                {
                    Console.Text = item;
                    System.Threading.Thread.Sleep(300);
                }
                animdone = true;
                Screen.Controls.Remove(Console);
                try
                {
                }
                catch (Exception e){ MessageBox.Show("ERROR:"+e.Message+Environment.NewLine+e.InnerException+Environment.NewLine+Environment.NewLine+e.StackTrace); }
                
            }
        }
        public TextBox InitializeConsole()
        {
            // 
            // Console
            // 
            TextBox Console = new TextBox();
            Console.ReadOnly = true;
            Console.Font = new Font("Consolas",(float)this.Height/35,FontStyle.Bold,GraphicsUnit.Pixel);
            Console.BackColor = System.Drawing.SystemColors.InfoText;
            Console.Dock = System.Windows.Forms.DockStyle.Fill;
            Console.ForeColor = System.Drawing.SystemColors.Info;
            Console.Location = new System.Drawing.Point(0, 0);
            Console.BorderStyle = BorderStyle.None;
            Console.Multiline = true;
            Console.Name = "Console";
            Console.Size = new System.Drawing.Size(687, 324);
            Console.TabIndex = 0;
            return Console;
        }
        public Panel InitializeLogin()
        {
            Panel Login = new Panel();
            // 
            // Login
            // 
            Login.Controls.Add(button1);
            Login.Controls.Add(label2);
            Login.Controls.Add(textBox2);
            Login.Controls.Add(label1);
            Login.Controls.Add(textBox1);
            Login.Location = new System.Drawing.Point(0, 0);
            Login.Name = "Login";
            Login.Size = new System.Drawing.Size(687, 324);
            Login.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(295, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(292, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(295, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(292, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(295, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '・';
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            return Login;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "PixelZerg" && textBox1.Text == "password")
            {
                //Screen.Controls.Clear();
                Screen.Controls.Remove(Login);
              //  Screen.Controls.Add(Console);
            }
            else
            {
                button1.Text = "Try again";
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }
    }
}
