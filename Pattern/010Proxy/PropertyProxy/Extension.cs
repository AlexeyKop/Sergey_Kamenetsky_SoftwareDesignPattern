namespace ValueProxy
{
    public static class Extension
    {
        public static Km ToKm(this int val) => new Km { Value = val};
        public static Km ToKm(this double val) => new Km { Value = val};
        public static Km ToKm(this Mille val) => new Km { Value = val.Value * 1.60934 };

        public static Mille ToMl(this int val) => new Mille { Value = val};
        public static Mille ToMl(this double val) => new Mille { Value = val};
        public static Mille ToMl(this Km val) => new Mille { Value = val.Value / 1.60934 };
    }
}