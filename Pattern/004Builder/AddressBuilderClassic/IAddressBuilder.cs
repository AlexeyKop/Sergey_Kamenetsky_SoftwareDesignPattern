namespace AddressBuilderClassic
{
    interface IAddressBuilder
    {
        IAddressBuilder SetCountry(string country);
        IAddressBuilder SetCity(string country);
        IAddressBuilder SetStreet(string country);
        IAddressBuilder SetHouse(string country);
        IAddressBuilder SetNumber(string country);

        Address Build();
    }
}
