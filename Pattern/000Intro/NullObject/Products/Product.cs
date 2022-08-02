using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.Products
{
    public abstract class Product
    {
        public Product(int energy, string name)
        {
            this.energy = energy;
            this.name = name;
        }

        protected int energy;

        protected string name;

        /// <summary>
        /// Стоимость
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Как кушают этот продукт
        /// </summary>
        public abstract void Eat();
        
        /// <summary>
        /// Информация об энергетической ценности
        /// </summary>
        public virtual string KcalOfEnergy => $"Энергетическая ценность {this.name} составляет {this.energy} ккал";

    }
}
