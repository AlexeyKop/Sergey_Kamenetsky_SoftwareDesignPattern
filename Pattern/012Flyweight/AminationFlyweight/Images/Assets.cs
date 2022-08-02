using System.Drawing;

namespace AminationFlyweight.Images
{
    public class Assets : Sprite
    {
        public Assets(string path) : base(path) {
            System.Console.WriteLine(path);
        }
    }

}
