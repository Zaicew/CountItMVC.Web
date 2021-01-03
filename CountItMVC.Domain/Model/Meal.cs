using System.Collections;
using System.Collections.Generic;

namespace CountItMVC.Domain.Model
{
    public class Meal
    {
        public int Id { get; set; }
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarb { get; set; }
        public double TotalWeight { get; set; }
        public bool IsVisible { get; set; }
        public int ItemInMealId { get; set; }
        public virtual ItemInMeal ItemInMeal { get; set; }

        //public virtual ICollection<ItemInMeal> ItemsInMeal { get; set; }
    }
}