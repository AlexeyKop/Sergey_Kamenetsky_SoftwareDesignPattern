namespace FileSystemComposite
{
    abstract class IFileSystem
    {
        public string Title { get; init; }
        public abstract void PrintInfo(string w = "");
        protected virtual IFileSystem AddItem(IFileSystem element) => this;
    }
}
