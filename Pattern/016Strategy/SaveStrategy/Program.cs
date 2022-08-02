using SaveStrategy.FileProvider;
using SaveStrategy.interfaces;
using System;
using System.Collections.Generic;
using static System.Console;

namespace SaveStrategy
{
    class Program
    {
        static void Main()
        {

            // Видео https://youtu.be/Gn2XLfAdDxI

            //**FName** *Sergey *
            //**LName** *Kam *
            //**Age** *30 *
            Document doc = new(DocumentFormat.Md);
            doc.Append("FName", "Sergey")
            .Append("LName", "Kam")
            .Append("Age", "30");
            WriteLine(doc.Save());


            //<xml ver='0.001'>
            //  <FName>Sergey</FName>
            //  <LName>Kam</LName>
            //  <Age>30</Age>
            //</xml>
            doc = new(DocumentFormat.Xml);
            doc.Append("FName", "Sergey")
            .Append("LName", "Kam")
            .Append("Age", "30");
            Console.WriteLine(doc.Save());


            //{
            //  'FName': 'Sergey',
            //  'LName': 'Kam',
            //  'Age': '30',
            //}
            doc = new(DocumentFormat.Json);
            doc.Append("FName", "Sergey")
            .Append("LName", "Kam")
            .Append("Age", "30");
            Console.WriteLine(doc.Save());

            // =======

            var id = new Dictionary<string, string>()
            {
                ["FName"] = "Sergey",
                ["LName"] = "Kam",
                ["Age"] = "30",
            };

            WriteLine("====");
            WriteLine($"{Document.Convert(id, Json.Provider)} \n");
            WriteLine($"{Document.Convert(id, Xml.Provider)} \n");
            WriteLine($"{Document.Convert(id, Md.Provider)} \n");




        }
    }
}
