using AminationFlyweight.Images;
using AminationFlyweight.Infrastructure;
using AminationFlyweight.Prefabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AminationFlyweight
{
    public partial class Form : System.Windows.Forms.Form
    {
        AssetFactory factory;
        public Form()
        {
            InitializeComponent();
            int k = 0;
            this.Load += delegate { factory = new AssetFactory(); };
            this.MouseUp += (s,e) =>
            {
               
                this.Controls.Add(
                    new Prefab(
                        sprite: factory.GetAsset((Texture2D)(k++)),
                        x: e.X - 50 ,
                        y: e.Y - 65 
                        )
                    .SimpleImage
                    );
                k %= 3;
            };
        }

       
    }
}
