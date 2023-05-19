using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__6_NaumovNV
{
    public partial class ТеорЧасть : Form
    {
        public ТеорЧасть()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Получаем номер выделенной строки
            int index = listBox1.SelectedIndex;
            // Считываем строку в переменную str
            string str = (string)listBox1.Items[index];
            // Узнаем количество символов в строке
            int len = str.Length;
            // Считаем, что количество пробелов равно 0
            int count = 0;
            // Устанавливаем счетчик символов в 0
            int i = 0;
            // Организуем цикл перебора всех символов в строке
            while (i < len)
            {
                // Если нашли пробел, то увеличиваем
                // счетчик пробелов на 1
                if (str[i] == ' ')
                    count++;
                i++;
            }
            label1.Text = "Количество пробелов = " +
            count.ToString();
            if (count != 0)
                label2.Text = "Количество слов = " + (count + 1).ToString();
            else
                label2.Text = "Количество слов = 0";
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ТеорЧасть_Load(object sender, EventArgs e)
        {

        }
    }
}
