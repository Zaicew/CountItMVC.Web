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
        public IQueryable<Meal> GetAllMealsFromDay(int dayId)
        {
            return _context.Meals.Where(m => m.DayId == dayId);
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

        public Meal[] GenerateDomainMealsForDay(int dayId)
        {
            var meals = new Meal[5];
            for (int i = 0; i < meals.Length; i++) 
            {
                meals[i] = new Meal()
                {
                    DayId = dayId,
                    IsVisible = true,
                    ItemsInMeal = new List<ItemInMeal>()
                };
            }
            return meals;
        }

        //public void AddItemToMeal(ItemInMeal itemInMeal)
        //{
        //    var meal = _context.Meals.Find(itemInMeal.MealId);
        //    var item = _context.Items.Find(itemInMeal.ItemId);
        //    var day = _context.Days.Find(meal.DayId);
        //    RecalculateMacros(meal, item, day, itemInMeal);
        //}

        public List<Meal> GetAllMealsFromUser(string userId)
        {
            var days = _context.Days.Where(d => d.UserId == userId);
            _context.SaveChanges();
            var mealList = new List<Meal>();
            foreach (var item in days)
            {
                var meals = _context.Meals.Where(m => m.DayId == item.Id);
                _context.SaveChanges();
                foreach (var meal in meals) mealList.Add(meal);
            }
            return mealList;
        }

        //private void RecalculateMacros(Meal meal, Item item, Day day, ItemInMeal itemInMeal)
        //{
        //    var recalculatedMeal = RecalculateMeal(meal, item, itemInMeal);
        //}

        //private Meal RecalculateMeal(Meal meal, Item item, ItemInMeal itemInMeal)
        //{
        //    var result = meal.;
        //    result.TotalCarb = 0;
        //    foreach (var elemenet in meal.ItemsInMeal)
        //    {

        //    }

        //}
    }
}
