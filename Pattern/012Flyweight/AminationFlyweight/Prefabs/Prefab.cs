using AminationFlyweight.Images;
using AminationFlyweight.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AminationFlyweight.Prefabs
{
    public class Prefab
    {
        public PictureBox SimpleImage { get; set; }
        public int Left { set { SimpleImage.Left = value; } }
        public int Top { set { SimpleImage.Top = value; } }

        readonly Timer timer;
        int index;
        public Prefab(Sprite sprite, int x, int y)
        {
            timer = new Timer
            {
                Interval = 100
            };
            index = 0;

            int count = sprite.Pictures.Length;

            timer.Tick += delegate
            {
                SimpleImage.Image = sprite.Pictures[index++];
                index %= count;
            };
            SimpleImage = new PictureBox
            {
                Width = 100,
                Height = 130,
                Left = x,
                Top = y,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            timer.Start();

        }


    }
}
