using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Infrastructure.Repositories
{
    public class ItemInMealRepository : IItemInMealRepository
    {
        private readonly Context _context;
        private readonly IDayRepository _dayRepo;
        public ItemInMealRepository(Context context, IDayRepository dayRepo)
        {
            _context = context;
            _dayRepo = dayRepo;
        }
        public int AddItemToMeal(ItemInMeal item)
        {
            _context.ItemInMeals.Add(item);
            _context.SaveChanges();
            RecalculateMacroForMeal(item.MealId);
            return item.Id;
        }
        public int RemoveItemFromMeal(ItemInMeal item)
        {
            var itemInMeal = _context.ItemInMeals.Find(item); 
            if (itemInMeal != null)
            {
            _context.ItemInMeals.Remove(item);
            _context.SaveChanges();
            return item.Id;
            }
            return -1;
        }
        public IQueryable<ItemInMeal> GetAllItemsInMeals()
        {
            return _context.ItemInMeals;
        }
        public ItemInMeal GetItemInMeal(int id)
        {
            return _context.ItemInMeals.Find(id);
        }
        //check this below if it works:
        public ICollection<ItemInMeal> GetAllItemsInMeal(int mealId)
        {
            var meal = _context.Meals.Find(mealId).ItemsInMeal;
            return meal;
        }
        //check if this works actually!
        public void ChangeWeightOfItem(ItemInMeal item, double newWeight)
        {
            var itemInMeal = _context.ItemInMeals.Find(item);
            if(itemInMeal != null)
            {
                itemInMeal.HowManyGramsCurrentProduct = newWeight;
            }
            _context.SaveChanges();
        }

        private void RecalculateMacroForMeal(int mealId)
        {
            var meal = _context.Meals.Find(mealId);
            var itemsInMeal = _context.ItemInMeals.Where(m => m.MealId == mealId).ToList();
            meal.ItemsInMeal = itemsInMeal;
            meal = MakeZeroForAllProperties(meal);
            meal = RecalculateAllMacrosInMeal(meal);
            UpdateMealMacros(meal);
            _dayRepo.UpdateDayMacro(meal);
        }

        private Meal RecalculateAllMacrosInMeal(Meal meal)
        {
            foreach (var e in meal.ItemsInMeal)
            {
                var item = _context.Items.Find(e.ItemId);
                meal.TotalCarb += Math.Round(item.CarbPerHundredGrams * (e.HowManyGramsCurrentProduct / 100), 2);
                meal.TotalFat += Math.Round(item.FatPerHundredGrams * (e.HowManyGramsCurrentProduct / 100), 2);
                meal.TotalKcal += Math.Round(item.KcalPerHundredGrams * (e.HowManyGramsCurrentProduct / 100), 2);
                meal.TotalProtein += Math.Round(item.ProteinPerHundredGrams * (e.HowManyGramsCurrentProduct / 100), 2);
                meal.TotalWeight += Math.Round((e.HowManyGramsCurrentProduct), 2);
            }
            return meal;
        }

        private void UpdateMealMacros(Meal meal)
        {
            _context.Attach(meal);
            _context.Entry(meal).Property("TotalCarb").IsModified = true;
            _context.Entry(meal).Property("TotalFat").IsModified = true;
            _context.Entry(meal).Property("TotalKcal").IsModified = true;
            _context.Entry(meal).Property("TotalProtein").IsModified = true;
            _context.Entry(meal).Property("TotalWeight").IsModified = true;
            _context.SaveChanges();
        }

        private Meal MakeZeroForAllProperties(Meal meal)
        {
            meal.TotalCarb = 0;
            meal.TotalFat = 0;
            meal.TotalKcal = 0;
            meal.TotalProtein = 0;
            meal.TotalWeight = 0;
            return meal;
        }
    }
}
