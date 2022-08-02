using Ex23_OpenClosedPrinciple.SaveOptions;

namespace Ex23_OpenClosedPrinciple
{

    public class Image : Attach
    {
        private int width;
        private int height;
        private ISave saveOption;
        public int Width => width;
        public int Height => height;
        private Image(int width, int height, ISave saveOption)
        {
            this.width = width;
            this.height = height;
            this.saveOption = saveOption;
        }
        public static Image CreateImage(int width, int height, ISave saveOption) 
        { 
            return new Image(width, height, saveOption); 
        }
        public ImageSize GetSize()
        {
            return new ImageSize(x: width, y: height);
        }
        public void SaveTo(string path)
        {
            saveOption.Save(path, this);
        }
    }
}
