using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListMealForListVm
    {
        public List<MealForListVm> Meals { get; set; }
        public int Counter { get; set; }
    }
}
