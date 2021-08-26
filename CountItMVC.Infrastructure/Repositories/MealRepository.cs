using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Infrastructure.Repositories
{
    public class MealRepository : IMealRepository
    {
        private readonly Context _context;
        public MealRepository(Context context)
        {
            _context = context;
        }
        public ICollection<Meal> GetAllMealsFromDay(int dayId)
        {
            return _context.Meals.Where(m => m.DayId == dayId).ToList();
        }
        public IQueryable<Meal> GetAllMeals()
        {
            return _context.Meals;
        }
        public int AddMeal(Meal meal)
        {
            _context.Meals.Add(meal);
            _context.SaveChanges();
            return meal.Id;
        }

        public Meal GetMeal(int id)
        {
            var meal = _context.Meals.FirstOrDefault(m => m.Id == id);
            return meal;
        }

        public void UpdateMeal(Meal meal)
        {
            _context.Attach(meal);
            _context.Entry(meal).Property("IsVisible").IsModified = true;
            _context.Entry(meal).Property("DayId").IsModified = true;
            _context.SaveChanges();
        }
    }
}
