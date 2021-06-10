using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace CountItMVC.Domain.Model
{
    public class ItemInMeal : Item
    {
        public new int Id { get; set; }
        public double HowManyGramsCurrentProduct { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }

        public ItemInMeal(Item item, double weight) : base(item)
        {
            this.HowManyGramsCurrentProduct = weight;
        }

    }
}