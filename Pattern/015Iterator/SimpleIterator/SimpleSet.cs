using System.Collections.Generic;
using System.Collections;

namespace SimpleIterator
{
    class SimpleSet<T> : IEnumerator<T> 
    {
        int index;
        readonly T[] storage;
        public SimpleSet(params T[] args)
        {
            storage = args;
            Reset();
        }

        public T Current => storage[index];

        object IEnumerator.Current => Current;
        //public bool MoveNext() => ++index < storage.Length;
        public bool MoveNext() => --index >= 0;
        //public void Reset() => index = -1;
        public void Reset() => index = storage.Length;
        public void Dispose() { }
    }
}
