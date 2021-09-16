using CountItMVC.Application.ViewModels.ItemViews;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IItemInMealService
    {
        int AddItemToMeal(AddItemToMealVm model);
    }
}
