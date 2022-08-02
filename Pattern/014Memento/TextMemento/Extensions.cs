using System.Collections.Generic;

namespace TextMemento
{
    public static class Extensions
    {
        public static void SaveState(this Memento m, List<Memento> mementos)
        {
            mementos.Add(m);
        }
    }
}
