namespace ValueProxy
{
    public class Mille
    {
        public double Value { get; set; }
        
        public static Mille operator +(Mille a, Km b) => new Mille { Value = a.Value + b.Value / 1.60934 };
        public static Mille operator *(Mille a, double b) => new Mille { Value = a.Value * b };

        public override string ToString() => $"{Value.ToString("#.###")} ml";
    }
}