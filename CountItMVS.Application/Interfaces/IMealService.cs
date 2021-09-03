using CountItMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IMealService
    {
        ListMealForListVm GetAllMealsForList(int pageNo, int pageSize);
        int AddMeal(NewMealVm meal);
        NewMealVm GetMealForEdit(int id);
        void UpdateMeal(NewMealVm model);
        //void AddMealsToDay(int id);
    }
}
