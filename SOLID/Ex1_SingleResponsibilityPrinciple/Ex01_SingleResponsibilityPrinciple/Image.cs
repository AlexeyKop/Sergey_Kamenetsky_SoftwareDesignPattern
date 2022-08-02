using System;

namespace Ex23_OpenClosedPrinciple
{
    public class Image
    {
        private int width;
        private int height;
        public int Width => width;
        public int Height => height;
        private Image(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public static Image CreateImage(int width, int height) 
        { 
            return new Image(width, height); 
        }
        public void SendToEmail(string email, string text, string subject) 
        {
            return;
        }
        public void UploadToSftpServer(string sftp, int port, Guid token, User user) 
        {
            return;
        }
        public ImageSize GetSize()
        {
            return new ImageSize(x: width, y: height);
        }
        public void LoadFileFromUrl(string url)
        {
            return;
        }
        public void SaveToFile(string path)
        {
            return;
        }
    }
}
