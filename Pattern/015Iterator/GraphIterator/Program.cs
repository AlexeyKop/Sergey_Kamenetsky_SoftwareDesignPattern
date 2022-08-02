using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace GraphIterator
{
    class Program
    {
        static void Main()
        {
            //           html
            //           /  \
            //        head   body
            //       /  |     |  \
            //  title  meta   h1  ul
            //                |   | \                        
            //                a   li li  


            var tree = new Node<string>(value: "html",
                left: new(value: "head",
                          left: new(value: "title"),
                          right: new(value: "meta")),
                right: new(value: "body",
                           left: new(value: "h1",
                                    left: new(value: "a")),
                                    right: new(value: "ul",
                                               left: new(value: "li"),
                                               right: new(value: "li")))
                );

            var rlr = new InOrderIterator<string>(tree);
            while (rlr.MoveNext()) WriteLine($"{rlr.Current}");
            WriteLine();
            rlr.Reset();
            while (rlr.MoveNext()) WriteLine($"{rlr.Current}");





        }
    }
}
