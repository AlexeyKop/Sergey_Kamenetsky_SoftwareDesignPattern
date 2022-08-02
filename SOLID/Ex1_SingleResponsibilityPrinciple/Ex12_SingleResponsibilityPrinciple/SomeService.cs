namespace Ex23_OpenClosedPrinciple
{
    public class SomeService
    {
        private string url;

        public SomeService(string url)
        {
            this.url = url;
        }
           
        public Image GetImage()
        {
            //
            return Image.CreateImage(100, 500);
        }

    }
}
