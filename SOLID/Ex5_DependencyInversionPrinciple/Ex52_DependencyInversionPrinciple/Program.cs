namespace Ex53_DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ошибка CS1061  "KeyValuePair<string, Person>" не содержит определения "FirstName"
            //Ошибка CS1061  "KeyValuePair<string, Person>" не содержит определения "LastName"
            //Ошибка CS1061  "KeyValuePair<string, Person>" не содержит определения "Age"

            //var storage = new Storage();

            //new SearchByLastName(storage).Search();
            //new SearchByFirstName(storage).Search();
            //new SearchByAge(storage).Search();

        }
    }
}
