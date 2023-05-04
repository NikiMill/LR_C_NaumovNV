using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__2_NaumovNV
{
    public partial class ИЗ_20 : Form
    {
        public ИЗ_20()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
            textBox1.Text += "4,5";
            textBox2.Text += "7,4";
            textBox3.Text += "-2,1";
            textBox5.Text += "0,15";
            textBox4.Text += Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения A
            double a = double.Parse(textBox1.Text);

            // Вывод значения A в окно
            textBox4.Text += Environment.NewLine + "A = " + a.ToString();

            // Считывание значения C
            double c = double.Parse(textBox2.Text);

            // Вывод значения C в окно
            textBox4.Text += Environment.NewLine + "C = " + c.ToString();

            // Считывание значения D
            double d = double.Parse(textBox3.Text);

            // Вывод значения D в окно
            textBox4.Text += Environment.NewLine + "D = " + d.ToString();

            // Считывание значения X
            double x = double.Parse(textBox5.Text);

            // Вывод значения X в окно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            // Вычисляем арифметическое выражение
            double p1 = Math.Sqrt((c - (d * x * x)) / x) ;
            double p2 = Math.Log((x * x) + c) / (0.7 * x + a * d);
            double p3 = Math.Pow(10, -2) / (c - (d * Math.Pow(x, 3)));
            double y = p1 + p2 - p3;

            // Выводим результат в окно
            textBox4.Text += Environment.NewLine + "Результат Y = " +
            y.ToString();
        }
    }
}
