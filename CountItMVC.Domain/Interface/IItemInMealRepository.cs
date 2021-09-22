using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface IItemInMealRepository
    {
        int AddItemToMeal(ItemInMeal itemInMeal);
        IQueryable<ItemInMeal> GetAllItemsInMeal(int mealId);
        IQueryable<ItemInMeal> GetAllItemsInMeals();
        ItemInMeal GetItemInMeal(int itemInMealId);
        void UpdateItemInMeal(ItemInMeal itemInMeal);
    }
}
