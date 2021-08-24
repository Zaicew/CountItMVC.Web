﻿using CountItMVC.Domain.Interface;
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
            return _context.Days.Find(dayId).mealList;
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
    }
}
