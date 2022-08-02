using System;
using System.Collections.Generic;

namespace RecordPrototype
{

    public class ModelCar
    {
        public string Name { get; set; }
    }

    public record Car
    {
        public Car(string brand, string model, params int[] size)
        {
            this.Model = new ModelCar { Name = model };
            this.Brand = brand;
            this.Size = new List<int>(size);
        }

        public List<int> Size { get; set; }

        public ModelCar Model { get; set; }
        public string Brand { get; set; }

        public override string ToString() 
            => $"Brand: {Brand} Model: {Model.Name} [{string.Join(' ', Size)}]";
    }
}