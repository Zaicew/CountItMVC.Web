using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;

namespace CountItMVC.Infrastructure.Repositories
{
    public class DayRepository : IDayRepository
    {
        private readonly Context _context;
        public DayRepository(Context context)
        {
            _context = context;
        }
        public int AddDay(Day day)
        {
            _context.Days.Add(day);
            _context.SaveChanges();
            foreach (var item in day.mealList)
            {
                item.DayId = day.Id;
                _context.Meals.Add(item);
            }
            _context.SaveChanges();
            return day.Id;
        }
        public void DeleteDay(int dayId)
        {
            var day = _context.Days.Find(dayId);
            if (!(day is null))
            {
                _context.Days.Remove(day);
                _context.SaveChanges();
            }
        }
        public IQueryable<Day> GetAllDays()
        {
            return _context.Days;
        }
        public IQueryable<Tag> GetAllTags()
        {
            return _context.Tags;
        }
        public Day GetDayById(int dayId)
        {
            return _context.Days.FirstOrDefault(p => p.Id == dayId);
        }
        //public ICollection<Day> GetAllDaysFromCurrentCustomer(string userId)
        //{
        //    return _context.Users.Find(userId).Days;
        //}
        public void UpdateDay(Day day)
        {
            _context.Attach(day);
            _context.Entry(day).Property("Date").IsModified = true;
                }

        public void UpdateDayMacro(Meal meal)
        {
            var day = _context.Days.Find(meal.DayId);
            var meals = _context.Meals.Where(m => m.DayId == day.Id);
            day.mealList = meals.ToArray();
            day = MakeZeroForAllProperties(day);
            day = RecalculateDayMacros(day);
            UpdateMacroInDay(day);

        }

        private Day RecalculateDayMacros(Day day)
        {
            foreach (var e in day.mealList)
            {
                var meal = _context.Meals.Find(e.Id);
                day.TotalCarbs += Math.Round(meal.TotalCarb, 2);
                day.TotalFat += Math.Round(meal.TotalFat, 2);
                day.TotalKcal += Math.Round(meal.TotalKcal, 2);
                day.TotalProtein += Math.Round(meal.TotalProtein, 2);
                day.TotalWeightInGram += Math.Round(meal.TotalWeight, 2);
            }
            return day;
        }

        private Day MakeZeroForAllProperties(Day day)
        {
            day.TotalCarbs = 0;
            day.TotalFat = 0;
            day.TotalKcal = 0;
            day.TotalProtein = 0;
            day.TotalWeightInGram = 0;
            return day;
        }
        private void UpdateMacroInDay(Day day)
        {
            _context.Attach(day);
            _context.Entry(day).Property("TotalCarbs").IsModified = true;
            _context.Entry(day).Property("TotalFat").IsModified = true;
            _context.Entry(day).Property("TotalKcal").IsModified = true;
            _context.Entry(day).Property("TotalProtein").IsModified = true;
            _context.Entry(day).Property("TotalWeightInGram").IsModified = true;
            _context.SaveChanges();
        }
    }
}
