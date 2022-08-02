using System;
using System.Windows.Media.Imaging;

namespace ImageFileView.Helper
{
    public class DefaultImage
    {
        public static string DefaultPath { get { return $@"{Environment.CurrentDirectory}\default.png"; } }
        public static BitmapImage Source 
        {
            get{ return new BitmapImage(new Uri(DefaultPath, UriKind.RelativeOrAbsolute)); }
        }
    }
}
