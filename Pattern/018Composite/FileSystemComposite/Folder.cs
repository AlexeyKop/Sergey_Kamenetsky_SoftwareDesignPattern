using static System.Console;
using System.Collections.Generic;

namespace FileSystemComposite
{
    class Folder : IFileSystem
    {
        private readonly List<IFileSystem> fileSystem;
        public Folder() => fileSystem = new();
        public IFileSystem AddElement(params IFileSystem[] element)
        {
            foreach (var item in element) this.AddItem(item);
            return this;
        }
        public override void PrintInfo(string w = "")
        {
            WriteLine($"{w}{Title}");
            foreach (var item in fileSystem) item.PrintInfo($"{w} ");
        }
        protected override IFileSystem AddItem(IFileSystem element)
        {
            fileSystem.Add(element);
            return this;
        }
    }
}
