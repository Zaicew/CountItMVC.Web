using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace CountItMVC.Domain.Model
{
    public class ItemInMeal
    {
        public double HowManyGramsCurrentProduct { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

    }
}