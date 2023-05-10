using System;
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
    public partial class ИЗ__11 : Form
    {
        public ИЗ__11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст.Наумов Н.В." +
            Environment.NewLine;
            // Цикл для табулирования функции
            double x = x0;
            while (x >= (xk + dx / 2))
            {
                double y = x + Math.Sqrt(Math.Abs(Math.Pow(x, 3) + a - a * Math.Exp(x)));
                textBox5.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void ИЗ__11_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-4";
            textBox2.Text = "-6,2";
            textBox3.Text = "-0,2";
            textBox4.Text = "0,1";
        }
    }
}
