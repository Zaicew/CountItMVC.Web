using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class DayService : IDayService
    {
        private readonly IDayRepository _dayRepo;
        public DayDetailVm AddDay(Day day)
        {
            _dayRepo.AddDay(day);
            var dayVm = new DayDetailVm()
            {
                Id = day.Id,
                Date = day.Date,
                TotalWeightInGram = day.TotalWeightInGram,
                TotalKcal = day.TotalKcal,
                TotalCarbs = day.TotalCarbs,
                TotalProtein = day.TotalProtein,
                TotalFat = day.TotalFat,
                CustomerId = day.CustomerId,
            };
            return dayVm;
        }

        public ListDayDetailVm GetAllDays()
        {
            var days = _dayRepo.GetAllDays();
            var result = new ListDayDetailVm();
            foreach (var item in days)
            {
                var dayVm = new DayDetailVm()
                {
                    Id = item.Id,
                    Date = item.Date,
                    TotalWeightInGram = item.TotalWeightInGram,
                    TotalKcal = item.TotalKcal,
                    TotalCarbs = item.TotalCarbs,
                    TotalProtein = item.TotalProtein,
                    TotalFat = item.TotalFat,
                    CustomerId = item.CustomerId,
                    mealList = new MealForListVm[5] 
            };
                dayVm.mealList = CreateMealListVmForCurrentDay(item);
                result.Days.Add(dayVm);
            }
            result.Count = result.Days.Count;

            return result;
        }


        public DayDetailVm GetDayById(int id)
        {
            var day = _dayRepo.GetDayById(id);
            var dayVm = new DayDetailVm()
            {
                Id = day.Id,
                Date = day.Date,
                TotalWeightInGram = day.TotalWeightInGram,
                TotalKcal = day.TotalKcal,
                TotalCarbs = day.TotalCarbs,
                TotalProtein = day.TotalProtein,
                TotalFat = day.TotalFat,
                CustomerId = day.CustomerId,
                mealList = new MealForListVm[5]
            };

            dayVm.mealList = CreateMealListVmForCurrentDay(day);

            return dayVm;
        }

        private MealForListVm[] CreateMealListVmForCurrentDay(Day day)
        {
            var result = new MealForListVm[5];
            for (int i = 0; i < day.mealList.Length; i++)
            {
                var item = day.mealList[i];
                var meal = new MealForListVm()
                {
                    Id = item.Id,
                    TotalKcal = item.TotalKcal,
                    TotalCarb = item.TotalCarb,
                    TotalProtein = item.TotalProtein,
                    TotalFat = item.TotalFat,
                    TotalWeight = item.TotalWeight,
                    IsVisible = item.IsVisible,
                    DayId = item.DayId
                };
                result[i] = meal;
            }

            return result;
        }
    }
}
