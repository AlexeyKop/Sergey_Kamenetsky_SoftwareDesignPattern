using System;
namespace SimpleVisitor
{


    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new(); 
            Cat cat = new(); 
            Bird bird = new(); 

            var voice = new VoiceVisitor();
            var move = new MoveVisitor();
            
            dog.Accept(voice); // Гав
            cat.Accept(voice); // Мяу
            bird.Accept(voice); // Чирик-Чирик

            dog.Accept(move); // Побежала
            cat.Accept(move); // Крадётся
            bird.Accept(move); // Полетела

            Console.WriteLine("\nupdateVoiceVisitor\n");
            var updateVoiceVisitor = new UpdateVoiceVisitor();
            var kiwi = new Kiwi();

            kiwi.Accept(updateVoiceVisitor); // Киви что-то там, но что неизвестно...

            dog.Accept(updateVoiceVisitor); // Гав
            cat.Accept(updateVoiceVisitor); // Мяу
            bird.Accept(updateVoiceVisitor); // Чирик-Чирик


        }
    }
}
