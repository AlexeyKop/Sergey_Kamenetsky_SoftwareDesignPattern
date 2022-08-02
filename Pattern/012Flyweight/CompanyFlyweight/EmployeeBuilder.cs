namespace CompanyFlyweightIntro
{
    class EmployeeBuilder
    {
        readonly Employee em;

        public EmployeeBuilder() => em = new Employee();
        public EmployeeBuilder SetFirstName(string firstName) { em.FirstName = firstName; return this; }
        public EmployeeBuilder SetLastName(string lastName) { em.LastName = lastName; return this; }
        public EmployeeBuilder SetCompanyName(string companyName) { em.CompanyName = companyName; return this; }
        public EmployeeBuilder SetPosition(string position) { em.Position = position; return this; }

        public Employee Build() => em;
    }
}