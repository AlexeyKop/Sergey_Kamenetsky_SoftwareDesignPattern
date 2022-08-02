namespace AddressBuilderClassic
{
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"{Country} {City} {Street} {House} {Number}";
        }
    }
}
