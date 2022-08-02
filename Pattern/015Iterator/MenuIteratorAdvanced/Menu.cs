using System.Collections;
using System.Collections.Generic;

namespace MenuIteratorAdvanced
{
    class Menu : IEnumerable<Dish>
    {
        public Dish Pizza { get; init; }
        public Dish Coffee { get; init; }
        public Dish Soup { get; init; }

        public IEnumerator<Dish> GetEnumerator()
        {
            yield return Coffee;
            yield return Pizza;
            yield return Soup;
        }

        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)this;
    }
}
