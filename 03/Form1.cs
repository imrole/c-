using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        IPlay ip;
        MP3 m;
        Avi a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m = new MP3();
            ip = (IPlay)m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = ip.Pre();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = ip.Pause();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = ip.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = ip.Pause();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = ip.Next();
        }
    }
}
