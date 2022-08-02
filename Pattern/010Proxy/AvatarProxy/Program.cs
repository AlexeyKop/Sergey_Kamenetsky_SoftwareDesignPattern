using AvatarProxy.Characters;
using AvatarProxy.Proxy;
using static System.Console;
using System;


namespace AvatarProxy
{
    class Program
    {
        static void Main()
        {

            // Видео https://youtu.be/K8JiU2eKb50

            // AvatarV1
            Human realHuman = new Human(); WriteLine(realHuman.Age);
            
            AvatarV1 avatar1 = new AvatarV1(realHuman);

            avatar1.Run();
            WriteLine(avatar1.AvatarAge);

            avatar1.Run();
            WriteLine(avatar1.AvatarAge);

            // AvatarV2
            AvatarV2 avatar2 = new AvatarV2();
            avatar2.Run();

        }
    }
}
                

