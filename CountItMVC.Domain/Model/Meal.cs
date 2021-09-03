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
        public double TotalKcal
        {
            get
            {
                double result = 0;
                foreach(var item in ItemsInMeal)
                {
                    result += item.Item.KcalPerHundredGrams * item.HowManyGramsCurrentProduct;
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
                    result += item.Item.FatPerHundredGrams * item.HowManyGramsCurrentProduct;
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
                    result += item.Item.ProteinPerHundredGrams * item.HowManyGramsCurrentProduct;
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
                    result += item.Item.CarbPerHundredGrams * item.HowManyGramsCurrentProduct;
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

    }
}