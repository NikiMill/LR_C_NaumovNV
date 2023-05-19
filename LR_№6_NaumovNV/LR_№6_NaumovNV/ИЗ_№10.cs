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
    public partial class ИЗ__10 : Form
    {
        public ИЗ__10()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                label1.Text = "Вывод: ";
                // Получаем номер выделенной строки
                int index = listBox2.SelectedIndex;
                // Считываем строку в переменную str
                string str = (string)listBox2.Items[index];
                // Узнаем количество символов в строке
                int len = str.Length;    
                char[] D = { 'а', 'б', 'в', 'г', 'д', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у',
                    'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                // Организуем цикл перебора всех символов в строке
                foreach (char G in D)
                    for (int i = 0; i < len; i++)
                    {
                        if (G == str[i])
                            label1.Text += (str[i]);
                    }                             
            }
        }

        private void ИЗ__10_Load(object sender, EventArgs e)
        {
            label1.Text = "Вывод: ";
        }
    }
}
