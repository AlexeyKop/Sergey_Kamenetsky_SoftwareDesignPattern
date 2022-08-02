namespace UniversityObserver
{
    interface ISubjectObservable
    {
        void Add(IPropertyObserver observer);
        void Remove(IPropertyObserver observer);
        void Notify(string message);
    }
}