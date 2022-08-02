using ImageFileView.Helper;
using System;
using System.Windows.Media.Imaging;

namespace ImageFileView.Proxy
{
    public class Paint : Drawing
    {
        public Paint(string fileName)
        {
            this.imgPath = fileName;
        }

        public override void Init()
        {
            if (
                base.imgPath.EndsWith(".jpg")
                || base.imgPath.EndsWith(".png")
                || base.imgPath.EndsWith(".bmp")
                )
            {
                Img = new BitmapImage(new Uri($@"{imgPath}", UriKind.RelativeOrAbsolute));
            }
            else
            {
                Img = DefaultImage.Source;
            }
        }
    }
}
