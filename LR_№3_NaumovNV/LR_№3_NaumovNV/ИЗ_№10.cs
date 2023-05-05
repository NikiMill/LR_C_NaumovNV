using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__3_NaumovNV
{
    public partial class ИЗ__10 : Form
    {
        public ИЗ__10()
        {
            InitializeComponent();
        }

        private void ИЗ__10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(textBox2.Text);
            double q = Convert.ToDouble(textBox1.Text);

            // Ввод исходных данных в окно результатов
            textBox4.Text = "Результаты работы программы " +
            "ст. Наумова Н.В. " +
            Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text +
            Environment.NewLine;
            textBox4.Text += "При Q = " + textBox2.Text +
            Environment.NewLine;
            // Вычисление выражения

            double k;
            if (Math.Abs(x*q) > 10)
                k = Math.Log(Math.Sinh(x) + Math.Abs(q));
            else
                if (Math.Abs(x * q) < 10)
                k = Math.Exp(Math.Sinh(x) + q);
            else
                k = Math.Sinh(x) + q;
            // Вывод результата
            textBox4.Text += "k = " + k.ToString() +
            Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Результаты работы программы " + "ст. Наумова Н.В." +
            Environment.NewLine;
        }
    }
}
