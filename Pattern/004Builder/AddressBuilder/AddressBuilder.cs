namespace AddressBuilder
{
    class AddressBuilder
    {
        AddressElement address;

        public static AddressBuilder Build(string title, string value)
            => new AddressBuilder { address = new AddressElement(title, value) };

        private AddressBuilder() { }

        public AddressBuilder AddItem(string title, string value)
        {
            address.AddElement(title, value);
            return this;
        }

        public override string ToString() => address.ToString();
    }
}
