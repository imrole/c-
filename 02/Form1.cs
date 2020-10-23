using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text.Trim());
            Circle circle = new Circle
            {
                Radious = r
            };
            label4.Text += "圆的面积" + circle.Area();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text.Trim());
            double k = Convert.ToDouble(textBox2.Text.Trim());
            Rectangular rectangular = new Rectangular
            {
                C = c,
                K = k
            };
            label4.Text += "矩形的面积" + rectangular.Area();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(textBox1.Text.Trim());
            double g = Convert.ToDouble(textBox2.Text.Trim());
            Triangle triangle = new Triangle
            {
                D = d,
                G = g
            };
            label4.Text += "矩形的面积" + triangle.Area();
        }
    }
}
