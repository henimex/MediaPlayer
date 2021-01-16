using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Alem FM")
            {
                axWindowsMediaPlayer1.URL = "\\\\dell-e5\\Downloads\\ava.avi";
                //Alem FM Best FM Metro FM Power Turk
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = "D:\\Downloads\\Ava.2017.TR.HDRip.XviD.divxup.avi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
