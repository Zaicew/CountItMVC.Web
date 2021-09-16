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

        public IQueryable<Meal> GetAllMeals()
        {
            var meals = _mealRepo.GetAllMeals();
            return meals;
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

        public ListMealForListVm GetAllMealsForList(int pageSize, int pageNo)
        {
            var meals = _mealRepo.GetAllMeals();
            //var meals2 = _mealRepo.GetAllMeals().ProjectTo<MealForListVm>(_mapper.ConfigurationProvider).ToList();
            var mealsToShow = meals.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var result = new ListMealForListVm
            {
                Meals = new List<MealForListVm>(),
                Count = meals.Count(),
                CurrentPage = pageNo,
                PageSize = pageSize
            };
            foreach (var item in mealsToShow)
            {
                var mealVm = CreateMealVm(item);
                result.Meals.Add(mealVm);
            }

            return result;
        }

        public ListMealForListVm GetAllMealsFromUserForList(int pageNo, int pageSize, string userId)
        {
            var mealsTest = _mealRepo.GetAllMealsFromUser(userId);

            //var days = _dayRepo.GetAllDays().Where(d => d.UserId == userId);
            
            //var mealsFromUser = new List<Meal>();
            //foreach (var day in days)
            //{
            //    var meals = _mealRepo.GetAllMealsFromDay(day.Id).ToList();
            //    mealsFromUser.AddRange(meals);
            //}

            var mealsToShow = mealsTest.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();

            var result = new ListMealForListVm
            {
                Meals = new List<MealForListVm>(),
                Count = mealsTest.Count(),
                CurrentPage = pageNo,
                PageSize = pageSize
            };
            foreach (var item in mealsToShow)
            {
                var mealVm = CreateMealVm(item);
                result.Meals.Add(mealVm);
            }

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
                DayId = meal.DayId,
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
