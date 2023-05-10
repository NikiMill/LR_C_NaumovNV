using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR__4_NaumovNV
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ТеорЧасть());
            Application.Run(new ИЗ__10());
            Application.Run(new ИЗ__11());
            Application.Run(new ИЗ__20());
        }
    }
}
