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
    public partial class ИЗ__20 : Form
    {
        int[] Mas = new int[30];
        public ИЗ__20()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Очищаем элемент управления
            listBox1.Items.Clear();
            // Инициализируем класс случайных чисел
            Random rand = new Random();
            // Генерируем и выводим 15 элементов
            for (int i = 0; i < 30; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() +
                "] = " + Mas[i].ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Очищаем элемент управления
            listBox2.Items.Clear();
            // Обрабатываем все элементы
            for (int i = 0; i < 30; i++)
            {
                if (i == 0)
                {
                    if (Mas[i] > Mas[i + 1])
                        listBox2.Items.Add("Mas[" + Convert.ToString(i)
                         + "] = " + Mas[i].ToString());
                }
                else if (i == 29)
                {
                    if (Mas[i] > Mas[i - 1])
                        listBox2.Items.Add("Mas[" + Convert.ToString(i)
                        + "] = " + Mas[i].ToString());
                }
                if ((i != 0) & (i != 29))
                {
                    if ((Mas[i - 1] < Mas[i]) & (Mas[i] > Mas[i + 1]))
                        listBox2.Items.Add("Mas[" + Convert.ToString(i)
                        + "] = " + Mas[i].ToString());
                }
            }                  
        }
    }
}
