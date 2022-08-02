namespace Ex53_DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            var storage = new ListStorage();

            new SearchByLastName(storage).Search();
            new SearchByFirstName(storage).Search();
            new SearchByAge(storage).Search();
        }
    }
}
