using System;

namespace FileSystemComposite
{

    class Program
    {
        static void Main()
        {
            //C
            // Windows
            //  System32
            //   sytem.xml
            //  Driver
            //   etc
            //    ip.json
            //   etc2

            new Folder() { Title = "C" }
            .AddElement(new Folder() { Title = "Windows" }
                .AddElement(new Folder() { Title = "System32" }
                    .AddElement(new Document() { Title = "sytem.xml" }),
                        new Folder() { Title = "Driver" }
                    .AddElement(new Folder() { Title = "etc" }
                     .AddElement(new Document() { Title = "ip.json" }),
                  new Folder() { Title = "etc2" })))
            .PrintInfo();

        }
    }
}
