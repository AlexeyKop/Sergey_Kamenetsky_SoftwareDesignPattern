using IntroPrototype.Models;

namespace IntroPrototype.Prototype
{
    public abstract class Prototype
    {
        public string Field1 { get; set; }
        public ValueModel Field2 { get; set; }
        public ReferenceModel Field3 { get; set; }

        public Prototype(string value1, ValueModel value2, ReferenceModel value3)
        {
            this.Field1 = value1;
            this.Field2 = value2;
            this.Field3 = value3;
        }

        public abstract Prototype Clone();

    }
}
