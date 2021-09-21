using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels.ItemInMealViews
{
    public class ItemInMealVm : IMapFrom<ItemInMeal>
    {
        public int Id { get; set; }
        public double HowManyGramsCurrentProduct { get; set; }
        public int ItemId { get; set; }
        public int MealId { get; set; }
    }
}
