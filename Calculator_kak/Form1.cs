﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_kak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, result;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            result = a + b;
            textBox3.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, result;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            result = a - b;
            textBox3.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, result;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            result = a * b;
            textBox3.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, result;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            result = a / b;
            textBox3.Text = Convert.ToString(result);
        }
    }
}
