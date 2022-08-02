using static System.Console;

namespace FileSystemComposite
{
    class Document : IFileSystem {
        public override void PrintInfo(string w = "") => WriteLine($"{w}{Title}");
    }
}
