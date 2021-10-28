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
        private readonly IItemInMealRepository _itemInMealRepo;
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

        public List<Meal> GenerateDomainMealsForDay(int dayId)
        {
            var meals = new List<Meal>();
            for (int i = 0; i < 5; i++) 
            {
                meals.Add(new Meal()
                {
                    DayId = dayId,
                    Name = MealNames[i],
                    IsVisible = true,
                    ItemsInMeal = new List<ItemInMeal>()
                });
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
        //public List<MealForListVm> GenerateMealViews(int dayId)
        //{
        //    var meals = GetAllMeals().Where(m => m.DayId == dayId);
        //    var mealList = new List<MealForListVm>();
        //    foreach (var item in meals)
        //    {
        //        var itemsInMeal = _itemInMealRepo.GetAllItemsFromMeal(item.Id);
        //        var mealVm = _mapper.Map<MealForListVm>(item);
        //        mealList.Add(mealVm);
        //    }
        //    return mealList;
        //}

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
        private Dictionary<int, string> MealNames = new Dictionary<int, string>()
        {
            { 0, "Breakfast"},
            { 1, "Snack I"},
            { 2, "Lunch"},
            { 3, "Snack II"},
            { 4, "Dinner"}
        };
    }
}
