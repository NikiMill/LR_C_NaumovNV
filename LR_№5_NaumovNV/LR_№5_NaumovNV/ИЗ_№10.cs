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
    public partial class ИЗ__10 : Form
    {
        public ИЗ__10()
        {
            InitializeComponent();
        }

        private void ИЗ__10_MouseClick(object sender, MouseEventArgs e)
        {
            var i = 0;
            if (e.Button == MouseButtons.Left)
            {   //Добавление кнопки
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(e.X, e.Y);
                i = i+1;
            }
            else if (e.Button == MouseButtons.Right)
                // Удаление всех кнопок
                while (i != 0)
                {
                    foreach (Control c in this.Controls)
                        if (c is Button) // Кнопка?
                            (c as Button).Dispose(); // Да!
                    i -= 1;
                }
    
        }
    }
}
