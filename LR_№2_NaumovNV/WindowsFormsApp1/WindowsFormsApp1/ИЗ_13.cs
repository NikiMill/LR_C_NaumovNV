using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ИЗ_13 : Form
    //Индивидуальное задание 13
    //Разместите на форме ряд кнопок (Button). Создайте обработчики
    //события нажатия на данные кнопки, которые будут делать неактивными
    //текущую кнопку.Создайте обработчик события изменения размера формы
    //(Resize), который будет устанавливать все кнопки в активный режим.
    {
        public ИЗ_13()
        {
            InitializeComponent();
        }

        //При изменении размера формы всё возврашяется на исходную
        private void ИЗ_13_Resize(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
        }

        //При нажатии кнопка становиться не активной и меняет цвет
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.BackColor = Color.DarkGray;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.BackColor = Color.DarkGray;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackColor = Color.DarkGray;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.BackColor = Color.DarkGray;
        }
    }
}
