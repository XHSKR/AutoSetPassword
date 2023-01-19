using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSetPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string username = "xhs"; //Your Windows account username
        string password = "pw"; //The password you desire

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proccessStartInfo = new ProcessStartInfo("net", $"user {username} {password}");
            proccessStartInfo.CreateNoWindow = true;
            Process proc = new Process { StartInfo = proccessStartInfo };
            proc.Start();

            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proccessStartInfo = new ProcessStartInfo("net", $"user {username} \"\"");
            proccessStartInfo.CreateNoWindow = true;
            Process proc = new Process { StartInfo = proccessStartInfo };
            proc.Start();
        }
    }
}