using AminationFlyweight.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AminationFlyweight.Infrastructure
{
    public class AssetFactory
    {
        readonly Dictionary<Texture2D, Sprite> assets;
        public AssetFactory()
        {
            assets = new Dictionary<Texture2D, Sprite>();
        }

        public Sprite GetAsset(Texture2D texture)
        {
            switch (texture)
            {
                case Texture2D.Bonfire:
                    if (!assets.ContainsKey(texture))
                    {
                        var ss = new Assets(@"Resources\bonfire");
                        Console.WriteLine(ss.Pictures==null);
                        assets.Add(texture, ss);
                    }
                    break;
                case Texture2D.Heart:
                    if (!assets.ContainsKey(texture))
                    {
                        assets.Add(texture, new Assets(@"Resources\heart"));
                    }
                    break;
                case Texture2D.Torch:
                    if (!assets.ContainsKey(texture))
                    {
                        assets.Add(texture, new Assets(@"Resources\torch"));
                    }
                    break;
            }

            return assets[texture];
        }
    }
}
