using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListMealForListVm : IMapFrom<Customer>
    {
        public List<MealForListVm> Meals { get; set; }
        public int Counter { get; set; }
    }
}
