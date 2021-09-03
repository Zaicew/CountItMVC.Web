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
        private readonly IDayRepository _dayRepo;
        private readonly IMapper _mapper;

        public MealService(IMealRepository mealRepo, IDayRepository dayRepo, IMapper mapper)
        {
            _mealRepo = mealRepo;
            _dayRepo = dayRepo;
            _mapper = mapper;
        }

        public int AddMeal(NewMealVm mealVm)
        {
            var meal = _mapper.Map<Meal>(mealVm);
            var id = _mealRepo.AddMeal(meal);
            return id;
        }

        //public void AddMealsToDay(int dayId)
        //{
        //    var day = _dayRepo.GetDayById(dayId);
        //    var meals = new Meal[5];
        //    for (int i = 0; i<meals.Length; i++)
        //    {
        //        meals[i].DayId = dayId;
        //        meals[i].IsVisible = true;
        //        meals[i].ItemsInMeal = new List<ItemInMeal>();
        //    }
        //    day.mealList = meals;
        //}

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

        public NewMealVm GetMealForEdit(int id)
        {
            var meal = _mealRepo.GetMeal(id);
            var mealVm = _mapper.Map<NewMealVm>(meal);
            return mealVm;
        }
        public void UpdateMeal(NewMealVm model)
        {
            var meal = _mapper.Map<Meal>(model);
            _mealRepo.UpdateMeal(meal);
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
