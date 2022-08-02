namespace CompanyFlyweightSimple
{
    interface IRepository
    {
        void Create(string value);
        int Read(string value, bool last = false);
        string Read(int index);
    }
}