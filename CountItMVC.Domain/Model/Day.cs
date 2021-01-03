using System;
using System.Collections;
using System.Collections.Generic;

namespace CountItMVC.Domain.Model
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalWeightInGram { get; set; }

        public Meal[] mealList = new Meal[5];

        public virtual ICollection<DayTag> DaysTags { get; set; }
    }
}