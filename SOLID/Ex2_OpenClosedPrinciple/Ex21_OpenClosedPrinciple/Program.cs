using System;

namespace Ex23_OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = Image.CreateImage(28, 09);
            image.SaveToBMP("image.bmp");
            image.SaveToJPG("image.jpg");
            image.SaveToPNG("image.png");
        }
    }
}
