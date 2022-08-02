using Ex23_OpenClosedPrinciple.SaveOptions;
using System;

namespace Ex23_OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            Image[] pictures = new[]
            {
                Image.CreateImage(28,09,new SaveToBMP()),
                Image.CreateImage(19,90,new SaveToJPG()),
                Image.CreateImage(15,06,new SaveToPNG()),
            };

            foreach (var pic in pictures)
            {
                pic.SaveTo($"filename_{DateTime.Now.Ticks}");
            }


        }
    }
}
