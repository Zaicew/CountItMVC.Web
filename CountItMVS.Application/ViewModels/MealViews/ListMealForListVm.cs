using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListMealForListVm : IMapFrom<Meal>
    {
        public List<MealForListVm> Meals { get; set; }
        public int Counter { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        //public string SearchString { get; set; }
    }
}
