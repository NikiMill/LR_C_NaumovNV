﻿using System;
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
            if (e.Button == MouseButtons.Left)
            {   //Добавление кнопки
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(e.X, e.Y);
                b.Text = "0_0";
            }
            else if (e.Button == MouseButtons.Right)
                Controls.Clear();
    
        }
    }
}
