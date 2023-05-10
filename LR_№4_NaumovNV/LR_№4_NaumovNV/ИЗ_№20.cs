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
    public partial class ИЗ__20 : Form
    {
        public ИЗ__20()
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
            while (x <= (xk + dx / 2))
            {
                double y = a + Math.Pow(x, 2/3) * Math.Cos(x + Math.Exp(x));
                textBox5.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void ИЗ__20_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5,62";
            textBox2.Text = "15,62";
            textBox3.Text = "0,5";
            textBox4.Text = "0,41";
        }
    }
}
