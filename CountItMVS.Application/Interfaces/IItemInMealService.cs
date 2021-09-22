using CountItMVC.Application.ViewModels.ItemViews;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IItemInMealService
    {
        int AddItemToMeal(AddItemToMealVm model);
        //IQueryable<ItemInMeal> GetAllItemsInMeal();
        IQueryable<ItemInMeal> GetAllItemsInMeal(int mealId);
        AddItemToMealVm GetItemInMealForEdit(int itemInMealId);
        void UpdateItemInMeal(AddItemToMealVm model);
    }
}
