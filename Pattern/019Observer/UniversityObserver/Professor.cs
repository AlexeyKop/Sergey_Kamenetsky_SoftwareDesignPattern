using System.Collections.Generic;

namespace UniversityObserver
{
    class Professor : ISubjectObservable
    {
        private HashSet<IPropertyObserver> observers = new HashSet<IPropertyObserver>();

        public void TextTo(string speech) => Notify(speech);

        public void Add(IEnumerable<IPropertyObserver> observer)
        {
            foreach (var o in observer) Add(o);
        }
        
        public void Add(IPropertyObserver observer) => observers.Add(observer);

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                (observer as IPropertyObserver).SpeechTo(text: message);
            }
        }

        public void Remove(IPropertyObserver observer) => observers.Remove(observer);
    }
}