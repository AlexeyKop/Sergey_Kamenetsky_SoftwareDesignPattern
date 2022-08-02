namespace RecordPrototype
{
    // https://www.lada.ru/en/cars/vesta/sedan/tth.html

    public struct Characteristic
    {
        public string Value { get; set; }

        public static Characteristic Set(string arg)
        {
            return new Characteristic() { Value = arg };
        }
    }

}