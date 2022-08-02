namespace Ex23_OpenClosedPrinciple
{

    public class Image : Attach
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
        public ImageSize GetSize()
        {
            return new ImageSize(x: width, y: height);
        }
        public void SaveToBMP(string path)
        {
            return;
        }
        public void SaveToJPG(string path)
        {
            return;
        }
        public void SaveToPNG(string path)
        {
            return;
        }
    }
}
