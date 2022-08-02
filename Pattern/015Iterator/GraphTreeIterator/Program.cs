using System;
using System.Collections;
using static System.Console;

namespace GraphTreeIterator
{

    class Program
    {
        static void Main()
        {
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

            var it = new IteratorTree<string>(tree);

            // html head title meta body h1 a ul li li
            foreach (var item in it.GetIterator(Traversal.PreOrder)) Write($"{item} ");
            WriteLine("\n\n");

            // title head meta html a h1 body li ul li
            foreach (var item in it.GetIterator(Traversal.InOrder)) Write($"{item} ");
            WriteLine("\n\n");

            // title meta head a h1 li li ul body html
            foreach (var item in it.GetIterator(Traversal.PostOrder)) Write($"{item} ");
            WriteLine("\n\n");

        }
    }
}


