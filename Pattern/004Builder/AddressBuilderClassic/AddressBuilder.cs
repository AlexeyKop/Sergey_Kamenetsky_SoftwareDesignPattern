namespace AddressBuilderClassic
{
    class AddressBuilder : IAddressBuilder
    {

        Address address;
        public AddressBuilder() => address = new Address();

        public Address Build() => address;

        public IAddressBuilder SetCity(string city)
        {
            address.City = city;
            return this;
        }

        public IAddressBuilder SetCountry(string country)
        {
            address.Country = country;
            return this;
        }

        public IAddressBuilder SetHouse(string house)
        {
            address.House = house;
            return this;
        }

        public IAddressBuilder SetNumber(string number)
        {
            address.Number = number;
            return this;
        }

        public IAddressBuilder SetStreet(string street)
        {
            address.Street = street;
            return this;
        }
    }
}
