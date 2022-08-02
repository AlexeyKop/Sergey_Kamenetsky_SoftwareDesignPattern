using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MenuIteratorAdvanced
{
    class Dish : IEnumerable<int>
    {
        public Dish(string name, int weight, int proteins = 0, int fats = 0, int carbohydrates = 0)
        {
            Name = name;
            Weight = weight;
            nutrients = new Dictionary<string, int>
            {
                //{ "proteins", proteins },
                //{ "fats", fats },
                //{ "carbohydrates", carbohydrates }

                ["Proteins"] = proteins,
                ["Fats"] = fats,
                ["Carbohydrates"] = carbohydrates
            };
        }

        readonly Dictionary<string, int> nutrients;
        public string Name { get; init; }
        public int Weight { get; init; }

        public int Proteins => nutrients[nameof(Proteins)];
        public int Fats => nutrients[nameof(Fats)];
        public int Carbohydrates => nutrients[nameof(Carbohydrates)];

        //public int Average => (Proteins + Fats) / 2;
        //public int Average => (Proteins + Fats + Carbohydrates) / 3;

        public double AverageNutrients => nutrients.Values.Average();

        public override string ToString() =>
            $"{nameof(Name)}: {Name}  {nameof(Weight)}: {Weight}";

        public IEnumerator<int> GetEnumerator() => nutrients.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
