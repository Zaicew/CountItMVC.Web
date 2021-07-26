using System;
using System.Collections;
using System.Collections.Generic;

namespace CountItMVC.Domain.Model
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double TotalKcal
        {
            get
            {
                double result = 0;
                foreach (var item in mealList)
                {
                    if (item.IsVisible)
                    {
                        result += item.TotalKcal;
                    }
                }
                return result;
            }
        }
        public double TotalFat
        {
            get
            {
                double result = 0;
                foreach (var item in mealList)
                {
                    if (item.IsVisible)
                    {
                        result += item.TotalFat;
                    }
                }
                return result;
            }
        }
        public double TotalProtein
        {
            get
            {
                double result = 0;
                foreach (var item in mealList)
                {
                    if (item.IsVisible)
                    {
                        result += item.TotalProtein;
                    }
                }
                return result;
            }
        }
        public double TotalCarbs
        {
            get
            {
                double result = 0;
                foreach (var item in mealList)
                {
                    if (item.IsVisible)
                    {
                        result += item.TotalCarb;
                    }
                }
                return result;
            }
        }
        public double TotalWeightInGram
        {
            get
            {
                double result = 0;
                foreach (var item in mealList)
                {
                    if (item.IsVisible)
                    {
                        result += item.TotalWeight;
                    }
                }
                return result;
            }
        }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public Meal[] mealList = new Meal[5];

        public virtual ICollection<DayTag> DaysTags { get; set; }
    }
}