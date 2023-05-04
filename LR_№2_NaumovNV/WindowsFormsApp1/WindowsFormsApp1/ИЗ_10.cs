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
    public partial class ИЗ_10 : Form
    //Разместите на форме две кнопки(Button) и одно поле ввода
    //(TextBox). Сделайте на кнопках следующие надписи: «заполнить»,
    //«очистить». Создайте обработчики события нажатия на данные кнопки,
    //которые будут очищать или заполнять поле ввода знаками «******».
    //Создайте обработчик события создания формы(Load), который будет
    //устанавливать цвет формы и менять текст в поле ввода на строку «+++++».
    {
        public ИЗ_10()
        {
            InitializeComponent();
        }

        private void ИндивидуальноеЗадание_10_Load(object sender, EventArgs e)
        {
            textBox1.Text += "+++++";
            BackColor = Color.AntiqueWhite;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "******";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
