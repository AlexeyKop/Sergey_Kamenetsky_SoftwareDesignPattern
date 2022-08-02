using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AminationFlyweight
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var f = new Form();

            string url = @"https://youtu.be/mZ7OnzlSth0";

            var ll = new LinkLabel() { Text = "Видео на youtu be" };
            ll.LinkClicked += (s, e) => { Process.Start(url); };
            f.Controls.Add(ll);

            Application.Run(f);
        }
    }
}
