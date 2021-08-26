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
        public ItemInMealRepository(Context context)
        {
            _context = context;
        }
        public int AddItemToMeal(ItemInMeal item)
        {
                _context.ItemInMeals.Add(item);
                _context.SaveChanges();
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
    }
}
