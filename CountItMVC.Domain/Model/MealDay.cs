using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Domain.Model
{
    public class MealDay
    {
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        public int DayID { get; set; }
        public Day Day { get; set; }
    }
}
