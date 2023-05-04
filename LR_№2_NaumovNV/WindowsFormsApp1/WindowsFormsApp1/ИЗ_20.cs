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
    public partial class ИЗ_20 : Form
    //Индивидуальное задание 20
    //Разместите на форме четыре кнопки (Button). Напишите для каждой обработчик события, который будет менять размеры и
    //местоположение на окне других кнопок.
    {
        public ИЗ_20()
        {
            InitializeComponent();
        }

        //При нажатии на кнопку меняется её положение и размер
        private void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            button2.Location = new Point(rand.Next(0, (ИЗ_20.ActiveForm.Width - 50)), rand.Next(0, (ИЗ_20.ActiveForm.Height - 50)));
            button2.Size = new Size(rand.Next(60, 150), rand.Next(20, 60));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            button3.Location = new Point(rand.Next(0, (ИЗ_20.ActiveForm.Width - 50)), rand.Next(0, (ИЗ_20.ActiveForm.Height - 50)));
            button3.Size = new Size(rand.Next(60, 150), rand.Next(20, 60));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            button4.Location = new Point(rand.Next(0, (ИЗ_20.ActiveForm.Width - 50)), rand.Next(0, (ИЗ_20.ActiveForm.Height - 50)));
            button4.Size = new Size(rand.Next(60, 150), rand.Next(20, 60));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            button5.Location = new Point(rand.Next(0, (ИЗ_20.ActiveForm.Width - 50)), rand.Next(0, (ИЗ_20.ActiveForm.Height - 50)));
            button5.Size = new Size(rand.Next(60, 150), rand.Next(20, 60));
        }
    }
}
