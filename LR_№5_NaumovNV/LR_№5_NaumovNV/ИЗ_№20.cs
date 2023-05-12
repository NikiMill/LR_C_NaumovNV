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
    public partial class ИЗ__20 : Form
    {
        int x = 0;
        int y = 0;

        public ИЗ__20()
        {
            InitializeComponent();
        }

        private void ИЗ__20_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {   //Добавление кнопки           
                TextBox c = new TextBox();
                c.Parent = this;
                c.Location = new Point(0 + x, 0 + y);
                c.Text = "^_^";
                x = x + c.Size.Width;
                y = y + c.Size.Height;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(0 + x,0 + y);
                b.Text = "0_0";
                x = x + b.Size.Width;
                y = y + b.Size.Height;
            }
        }

        private void ИЗ__20_Resize(object sender, EventArgs e)
        {
            Controls.Clear();
            x = 0;
            y = 0;
        }
    }
}
