namespace ValueProxy
{
    public class Km
    {
        public double Value { get; set; }

        public static Km operator +(Km a, Mille b) => new Km { Value = a.Value + b.Value * 1.60934 };
        public static Km operator *(Km a, double b) => new Km { Value = a.Value * b };

        public override string ToString() => $"{Value.ToString("#.###")} km";
    }
}