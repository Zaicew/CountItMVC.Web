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
        private readonly IItemRepository _itemRepo;
        public ItemInMealRepository(Context context, IDayRepository dayRepo, IItemRepository itemRepo)
        {
            _context = context;
            _dayRepo = dayRepo;
            _itemRepo = itemRepo;
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
        public IQueryable<ItemInMeal> GetAllItemsInMeal(int mealId)
        {
            var meal = _context.ItemInMeals.Where(i => i.MealId == mealId);
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
        public List<Item> GetAllItemsFromMeal(int mealId)
        {
            var itemInMeals = _context.ItemInMeals.Where(i => i.MealId == mealId);
            _context.SaveChanges();
            var items = new List<Item>();
            foreach (var element in itemInMeals)
            {
                var item = _itemRepo.GetItemById(element.ItemId);
                items.Add(item);
            }
            return items;
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
                meal.TotalCarb += item.CarbPerHundredGrams / 100 * e.HowManyGramsCurrentProduct;
                meal.TotalFat += item.FatPerHundredGrams / 100 * e.HowManyGramsCurrentProduct;
                meal.TotalKcal += item.KcalPerHundredGrams / 100 * e.HowManyGramsCurrentProduct;
                meal.TotalWeight += e.HowManyGramsCurrentProduct;
                meal.TotalProtein += item.ProteinPerHundredGrams / 100 * e.HowManyGramsCurrentProduct;

                meal.TotalCarb = Math.Round(meal.TotalCarb, 2);
                meal.TotalFat = Math.Round(meal.TotalFat, 2);
                meal.TotalKcal = Math.Round(meal.TotalKcal, 2);
                meal.TotalWeight = Math.Round(meal.TotalWeight, 2);
                meal.TotalProtein = Math.Round(meal.TotalProtein, 2);
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
        public void UpdateItemInMeal(ItemInMeal itemInMeal)
        {
            _context.Attach(itemInMeal);
            _context.Entry(itemInMeal).Property("HowManyGramsCurrentProduct").IsModified = true; 
            _context.SaveChanges();
            RecalculateMacroForMeal(itemInMeal.MealId);
            _context.SaveChanges();


        }
    }
}
