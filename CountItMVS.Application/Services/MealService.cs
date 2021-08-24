using AutoMapper;
using AutoMapper.QueryableExtensions;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class MealService : IMealService
    {
        private readonly IMealRepository _mealRepo;
        private readonly IMapper _mapper;

        public MealService(IMealRepository mealRepo, IMapper mapper)
        {
            _mealRepo = mealRepo;
            _mapper = mapper;
        }

        public ListMealForListVm GetAllMealsForList(int pageNo, int pageSize)
        {
            var meals = _mealRepo.GetAllMeals();
            //var meals2 = _mealRepo.GetAllMeals().ProjectTo<MealForListVm>(_mapper.ConfigurationProvider).ToList();
            var mealsToShow = meals.Skip(pageNo * (pageSize - 1)).Take(pageSize).ToList();
            var result = new ListMealForListVm
            {
                Meals = new List<MealForListVm>(),
                Counter = meals.Count(),
                CurrentPage = pageNo,
                PageSize = pageSize
            };
            foreach (var item in mealsToShow) result.Meals.Add(CreateMealVm(item));

            return result;
        }

        private MealForListVm CreateMealVm(Meal meal)
        {
            var mealVm = new MealForListVm()
            {
                Id = meal.Id,
                DayId = meal.Id,
                IsVisible = meal.IsVisible,
                TotalKcal = meal.TotalKcal,
                TotalCarb = meal.TotalCarb,
                TotalProtein = meal.TotalProtein,
                TotalFat = meal.TotalFat,
                TotalWeight = meal.TotalWeight
            };
            return mealVm;
        }
    }
}
