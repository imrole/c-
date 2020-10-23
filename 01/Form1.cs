using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2020_10_23课堂作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = Convert.ToInt32(textBox2.Text.Trim());
            double sub1 = Convert.ToDouble(textBox3.Text.Trim());
            double sub2 = Convert.ToDouble(textBox4.Text.Trim());

            Pupil pupil = new Pupil(name, age, sub1, sub2);
            label6.Text += pupil.GetInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = Convert.ToInt32(textBox2.Text.Trim());
            double sub1 = Convert.ToDouble(textBox3.Text.Trim());
            double sub2 = Convert.ToDouble(textBox4.Text.Trim());
            double sub3 = Convert.ToDouble(textBox5.Text.Trim());

            Middle middle= new Middle(name, age, sub1, sub2,sub3);
            label6.Text += middle.GetInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            int age = Convert.ToInt32(textBox2.Text.Trim());
            double sub1 = Convert.ToDouble(textBox3.Text.Trim());
            double sub2 = Convert.ToDouble(textBox4.Text.Trim());

            University pupil = new University(name, age, sub1, sub2);
            label6.Text += pupil.GetInfo();
        }
    }
}
