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
    public partial class ИЗ_11 : Form
    {
        public ИЗ_11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Результаты работы программы " + "ст. Наумова Н.В." +
            Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox1.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double fx = 0;
            if (radioButton1.Checked)
            {
                fx = Math.Sinh(x);
            }
            else if (radioButton2.Checked)
            {
                fx = Math.Exp(x);
            }
            else if (radioButton3.Checked)
            {
                fx = x * x;
            }
            else
                fx = 0;

            // Ввод исходных данных в окно результатов
            textBox4.Text = "Результаты работы программы " +
            "ст. Наумова Н.В. " +
            Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text +
            Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text +
            Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text +
            Environment.NewLine;
            // Вычисление выражения

            double m;
            m = (Math.Max(fx, Math.Max(y,z)) / Math.Min(fx,y)) + 5;
            
            // Вывод результата
            textBox4.Text += "M = " + m.ToString() +
            Environment.NewLine;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Выбрана функция: Exp(x)");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Выбрана функция: sh(x)");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Выбрана функция: Pow(x, 2)");
        }
    }
}
