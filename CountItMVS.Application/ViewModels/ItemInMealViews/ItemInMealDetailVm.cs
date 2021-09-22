using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels.ItemInMealViews
{
    public class ItemInMealDetailVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProteins { get; set; }
        public double TotalCarb { get; set; }
        public double TotalWeight { get; set; }
    }
}
