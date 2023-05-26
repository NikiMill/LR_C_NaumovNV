using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__7_NaumovMV
{
    public partial class ТеорЧасть : Form
    {
        int[] Mas = new int[15];
        public ТеорЧасть()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Очищаем элемент управления
            listBox2.Items.Clear();
            // Обрабатываем все элементы
            for (int i = 0; i < 15; i++)
            {
                if (Mas[i] < 0)
                    Mas[i] = 0;
                listBox2.Items.Add("Mas[" + Convert.ToString(i)
                + "] = " + Mas[i].ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Очищаем элемент управления
            listBox1.Items.Clear();
            // Инициализируем класс случайных чисел
            Random rand = new Random();
            // Генерируем и выводим 15 элементов
            for (int i = 0; i < 15; i++)
                {
                    Mas[i] = rand.Next(-50, 50);              
                    listBox1.Items.Add("Mas[" + i.ToString() +
                    "] = " + Mas[i].ToString());
                }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
