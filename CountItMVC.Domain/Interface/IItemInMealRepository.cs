using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface IItemInMealRepository
    {
        int AddItemToMeal(ItemInMeal itemInMeal);
    }
}
