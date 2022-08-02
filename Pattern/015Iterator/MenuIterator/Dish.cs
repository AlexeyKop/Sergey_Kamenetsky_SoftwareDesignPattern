namespace MenuIterator
{
    class Dish
    {
        public Dish(string name, int weight, int proteins = 0, int fats = 0)
        {
            Name = name;
            Weight = weight;
            Proteins = proteins;
            Fats = fats;
        }
        public string Name { get; init; }
        public int Weight { get; init; }

        public int Proteins { get; set; }
        public int Fats { get; set; }
        public int Carbohydrates { get; set; }

        public int Average => (Proteins + Fats) / 2;
        //public int Average => (Proteins + Fats + Carbohydrates) / 3;

        public override string ToString() =>
            $"{nameof(Name)}: {Name}  {nameof(Weight)}: {Weight}";
    }
}
