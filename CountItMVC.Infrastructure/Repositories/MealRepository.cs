using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
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
            return _context.Days.Find(dayId).mealList;
        }
    }
}
