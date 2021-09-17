using System.Collections;
using System.Collections.Generic;

namespace CountItMVC.Domain.Model
{
    public class Meal
    {
        public Meal()
        {
            //usun to
            IsVisible = true;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalKcal { get; set; }       
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarb { get; set; }
        public double TotalWeight { get; set; }
        public bool IsVisible { get; set; }
        public int DayId { get; set; }
        public virtual Day Day { get; set; }

        public virtual ICollection<ItemInMeal> ItemsInMeal { get; set; }

    }
}