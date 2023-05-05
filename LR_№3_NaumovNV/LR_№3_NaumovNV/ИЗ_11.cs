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
            m = (Math.Max(Math.Sinh(x), Math.Max(y,z)) / Math.Min(Math.Sinh(x),y)) + 5;
            
            // Вывод результата
            textBox4.Text += "M = " + m.ToString() +
            Environment.NewLine;
        }
    }
}
