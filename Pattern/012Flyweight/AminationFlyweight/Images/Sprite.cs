using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AminationFlyweight.Images
{
    public abstract class Sprite
    {
        protected Bitmap[] bitmaps;
        protected string[] paths_i;

        public Bitmap[] Pictures
        {
            get
            {
                if (bitmaps == null)
                {
                   
                    int len = paths_i.Length;
                  
                    bitmaps = new Bitmap[len];
                    for (int i = 0; i < len; i++)
                    {
                        bitmaps[i] = new Bitmap(paths_i[i]);
                    }
                }
                return bitmaps;
            }
        }
        public Sprite(string path)
        {
            paths_i = Directory.GetFiles(path);
            
            
        }
    }

}
