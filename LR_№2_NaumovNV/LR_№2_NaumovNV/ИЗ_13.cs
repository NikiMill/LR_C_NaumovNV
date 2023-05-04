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
    public partial class ИЗ_13 : Form
    {
        public ИЗ_13()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
            textBox1.Text += "17,421";
            textBox2.Text += "0,010365";
            textBox3.Text += "82800";
            //textBox5.Text += "0,22056";
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
            // Считывание значения X
            double x = double.Parse(textBox1.Text);

            // Вывод значения X в окно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            // Считывание значения Y
            double y = double.Parse(textBox2.Text);

            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            // Считывание значения Z
            double z = double.Parse(textBox3.Text);

            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            // Считывание значения H
            //double h = double.Parse(textBox5.Text);

            // Вывод значения H в окно
            //textBox4.Text += Environment.NewLine + "H = " + h.ToString();

            // Вычисляем арифметическое выражение
            double ch = Math.Pow(y + Math.Pow((x - 1), 1/3), 1/4);
            double zn1 = Math.Abs(x - y);
            double zn2 = Math.Pow(Math.Sin(z), 2) + Math.Tan(z);
            double f = ch / (zn1 * zn2);

            // Выводим результат в окно
            textBox4.Text += Environment.NewLine + "Результат Y = " +
            f.ToString();
        }
    }
}
