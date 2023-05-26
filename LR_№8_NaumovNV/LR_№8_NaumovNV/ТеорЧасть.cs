using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__8_NaumovNV
{
    public partial class ТеорЧасть : Form
    {
        public ТеорЧасть()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15; // Кол‐во строк       
            dataGridView1.ColumnCount = 15; // Кол‐во столбцов
            int[,] a = new int[15, 15]; // Инициализируем массив
            int i, j;
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    a[i, j] = rand.Next(-100, 100);
            // Выводим матрицу в dataGridView1
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    dataGridView1.Rows[i].Cells[j].Value =
                    a[i, j].ToString();
            // Поиск максимального элемента
            // на дополнительной диагонали
            int m = int.MinValue;
            for (i = 0; i < 15; i++)
                if (a[i, 14 - i] > m) m = a[i, 14 - i];
            // выводим результат
            textBox1.Text = Convert.ToString(m);
        }

        private void ТеорЧасть_Load(object sender, EventArgs e)
        {

        }
    }
}
