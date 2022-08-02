using ImageFileView.Proxy;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace ImageFileView.Models
{
    public class ImagePair : INotifyPropertyChanged
    {
        Drawing bmp;
        public ImagePair(string imageName, string imageFullPath)
        {
            ImageName = imageName;
            ImageFullPath = imageFullPath;
            bmp = new ProxyPaint(ImageFullPath);
        }
       
        public string ImageFullPath { get; set; }
        public string ImageName { get; set; }
        public BitmapImage img 
        { 
            get { return bmp.Img; } 
            private set { bmp.Img = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void View()
        {
            bmp.Init();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(img)));
        }
    }
}
