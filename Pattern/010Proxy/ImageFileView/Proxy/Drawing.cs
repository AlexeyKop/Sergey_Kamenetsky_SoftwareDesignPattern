using System.Windows.Media.Imaging;

namespace ImageFileView.Proxy
{
    public abstract class Drawing
    {
        protected string imgPath;
        abstract public void Init();
        public BitmapImage Img { get; set; }
    }
}
