using System.Collections;
using System.Collections.Generic;

namespace CountItMVC.Domain.Model
{
    public class Meal
    {
        public int Id { get; set; }
        public double TotalKcal
        {
            get
            {
                double result = 0;
                foreach(var item in ItemsInMeal)
                {
                    result += item.KcalPerHundredGrams * item.HowManyGramsCurrentProduct;
                }
                return result;
            }
        }
            
        public double TotalFat 
        { 
            get
            {
                double result = 0;
                foreach (var item in ItemsInMeal)
                {
                    result += item.FatPerHundredGrams * item.HowManyGramsCurrentProduct;
                }
                return result;
            }
        }
        public double TotalProtein
        {
            get
            {
                double result = 0;
                foreach (var item in ItemsInMeal)
                {
                    result += item.ProteinPerHundredGrams * item.HowManyGramsCurrentProduct;
                }
                return result;
            }
        }
        public double TotalCarb
        {
            get
            {
                double result = 0;
                foreach (var item in ItemsInMeal)
                {
                    result += item.CarbPerHundredGrams * item.HowManyGramsCurrentProduct;
                }
                return result;
            }
        }
        public double TotalWeight
        {
            get
            {
                double result = 0;
                foreach (var item in ItemsInMeal)
                {
                    result += item.HowManyGramsCurrentProduct;
                }
                return result;
            }
        }
        public bool IsVisible { get; set; }
        public int DayId { get; set; }
        public virtual Day Day { get; set; }

        public virtual ICollection<ItemInMeal> ItemsInMeal { get; set; }

        //public int ItemInMealId { get; set; }
        //public virtual ItemInMeal ItemInMeal { get; set; }
    }
}