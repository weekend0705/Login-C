using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testvideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                axWindowsMediaPlayer1.uiMode = "none";
                axWindowsMediaPlayer1.settings.setMode("loop", true);
                axWindowsMediaPlayer1.URL = @"C:\Users\hhtua\Videos\video.mp4";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
