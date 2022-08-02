using AvatarProxy.Characters;
using static System.Console;

namespace AvatarProxy.Proxy
{
    public class AvatarV1 : ActionObject
    {
        Human human;
        public AvatarV1(Human human)
        {
            this.human = human.Clone();
            // или
            // this.human = human;
            // если есть(нужен) доступ к исходному объекту
        }


        public int AvatarAge { get { return human.Age; } }
        public override void Run()
        {
            Write("Аватар в действии ");
            human.Run();
        }
    }
}
