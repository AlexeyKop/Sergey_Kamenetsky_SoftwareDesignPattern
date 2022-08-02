namespace TruePrototype
{
    public class Address
    {
        public City City { get; set; }
    }

    public class City
    {
        public Street street { get; set; }
    }

    public class Street
    {
        public House House { get; set; }
    }

    public class House
    {
        public int HouseNumber { get; set; }
    }
}