using System;
using static System.Console;

namespace RichTextFlyweight
{

    class Program
    {
        static void Main()
        {

            string t = "Я – один, и никого на свете, который бы пошёл мне на встречу такой же тоскующей душой; будь это мужчина или женщина, я всё равно бы заключил его в свои братские объятия и осыпал бы чистыми жемчужными поцелуями, пошёл бы с ним от этого чуждого мне мира, предоставляя свои цветы рвать дерзким рукам того, кто хочет наслаждения.\n";
            (int start, int length)[] colored = new (int, int)[]
            {
                (22, 1),
                (40, 1),
                (51, 1),
                (54, 1),
                (100, 1),
                (129, 1),
                (143, 1),
                (145, 1),
                (154, 1),
                (186, 1),

            };
            WriteLine(t);

            ReadLine();

            #region FlyweightRichTextFormat

            FlyweightRichTextFormat ft = new(t);
            foreach (var (start, length) in colored) ft.ColorRande(start, length, ConsoleColor.Red);
            //ft.ColorRande(0, t.Length, ConsoleColor.Red);
            ft.Print();
            WriteLine(ft.Memory);
            #endregion

            #region RichTextFormat

            RichTextFormat tf = new(t);

            //foreach (var (start, length) in colored) tf.ChangeColor(start, length, ConsoleColor.Red);
            tf.ChangeColor(0, t.Length, ConsoleColor.Red);
            ReadLine();
            tf.Print();
            WriteLine(tf.Memory);

            #endregion

            ReadKey();
        }
    }
}