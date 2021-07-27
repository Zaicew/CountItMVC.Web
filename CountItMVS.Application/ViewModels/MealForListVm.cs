using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class MealForListVm
    {
        public int Id { get; set; }
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarb { get; set; }
        public double TotalWeight { get; set; }
        public bool IsVisible { get; set; }
        public int DayId { get; set; }
    }
}
