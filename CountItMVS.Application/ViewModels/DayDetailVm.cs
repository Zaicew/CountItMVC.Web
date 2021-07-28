using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class DayDetailVm
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalWeightInGram { get; set; }
        public int CustomerId { get; set; }

        public MealForListVm[] mealList = new MealForListVm[5];
    }
}
