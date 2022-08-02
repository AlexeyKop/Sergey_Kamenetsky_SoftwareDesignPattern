namespace RecordPrototype.Audi
{
    //https://www.audiusa.com/us/web/en/models/e-tron/e-tron/2021/overview.html
    //https://www.audi.ru/ru/web/ru/models/a5/a5-coupe/configurator.html

    public abstract class Audi : Car
    {
        public Audi(string model, string brand) 
            : base(model, brand) { }
    }
}
