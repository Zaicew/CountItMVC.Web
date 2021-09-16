using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IMealService
    {
        ListMealForListVm GetAllMealsForList(int pageNo, int pageSize);
        int AddMeal(NewMealVm meal);
        NewMealVm GetMealForEdit(int id);
        void UpdateMeal(NewMealVm model);
        ListMealForListVm GetAllMealsFromUserForList(int pageNo, int pageSize, string userId);
        IQueryable<Meal> GetAllMeals();
        //void AddMealsToDay(int id);
    }
}
