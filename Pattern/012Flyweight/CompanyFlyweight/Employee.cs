namespace CompanyFlyweightIntro
{
    class Employee
    {
        public Employee() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }

        public override string ToString()=> $"{FirstName} {LastName} {CompanyName} {Position}";
    }
}