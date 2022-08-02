using System;
using System.Collections.Generic;

namespace Ex53_DependencyInversionPrinciple
{
    public interface IFindStorage
    {
        List<Person> FindAll(Predicate<Person> predicate);
    }
}
