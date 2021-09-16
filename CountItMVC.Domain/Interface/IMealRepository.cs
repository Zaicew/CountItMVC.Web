using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface IMealRepository
    {
        IQueryable<Meal> GetAllMeals();
        IQueryable<Meal> GetAllMealsFromDay(int dayId);
        int AddMeal(Meal meal);
        Meal GetMeal(int id);
        void UpdateMeal(Meal meal);
        Meal[] GenerateDomainMealsForDay(int id);
        List<Meal> GetAllMealsFromUser(string userId);
    }
}
