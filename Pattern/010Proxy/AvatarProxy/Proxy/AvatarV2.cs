using AvatarProxy.Characters;
using static System.Console;

namespace AvatarProxy.Proxy
{

    public class AvatarV2 : ActionObject
    {
        Human human;
        public AvatarV2()
        {
            this.human = new Human();
        }

        public int AvatarAge { get { return human.Age; } }
        public override void Run()
        {
            Write("Аватар в действии ");

            human.Run();
        }
    }
}
