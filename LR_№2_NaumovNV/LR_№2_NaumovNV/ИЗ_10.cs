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
    public partial class ИЗ_10 : Form
    {
        public ИЗ_10()
        {
            InitializeComponent();
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

            //// Считывание значения А
            //double а = double.Parse(textBox5.Text);

            //// Вывод значения А в окно
            //textBox4.Text += Environment.NewLine + "А = " + а.ToString();

            // Вычисляем арифметическое выражение
            //double b = ();
            double p1 = Math.Pow(2, -x) * Math.Sqrt(x + Math.Pow(Math.Abs(y), 1/4));
            double p2 = Math.Pow(Math.Exp((x - 1) / Math.Sin(z)), 1/3);
            double a = p1 * p2;

            // Выводим результат в окно
            textBox4.Text += Environment.NewLine + "Результат A = " +
            a.ToString();
        }

        private void ИЗ_10_Load(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
            textBox1.Text += "0,03981";
            textBox2.Text += "-1625";
            textBox3.Text += "0,512";
            //textBox5.Text += "0,22056";
            textBox4.Text += Text;
        }
    }
}
