﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__4_NaumovNV
{
    public partial class ИЗ__10 : Form
    {
        public ИЗ__10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст.Наумов Н.В." +
            Environment.NewLine;
            // Цикл для табулирования функции
            double x = x0;
            while (x >= (xk + dx / 2))
            {
                double y = x * Math.Sin(Math.Sqrt(x + b - 0.0084));
                textBox5.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void ИЗ__10_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-2,05";
            textBox2.Text = "-3,05";
            textBox3.Text = "-0,2";
            textBox4.Text = "3,4";
        }
    }
}
