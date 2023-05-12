using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__5_NaumovNV
{
    public partial class ТеорЧасть : Form
    {
        public ТеорЧасть()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //Создаём кнопочку
            Button b = new Button();
            b.Parent = this;
            //b.Parent = panel1;
            b.Location = new Point(10, 20);
            b.Size = new Size(200, 100);
            // Перебираем все элементы управления
            foreach (Control c in this.Controls)
                {
                if (c is Button) // Кнопка?
                    (c as Button).Text = "*****"; // Да!
                }
        }
    }
}
