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
    public class DayService : IDayService
    {
        private readonly IDayRepository _dayRepo;
        private readonly IMealRepository _mealRepo;
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public DayService(IDayRepository dayRepo, IMealRepository mealRepo, IUserRepository userRepo, IMapper mapper)
        {
            _dayRepo = dayRepo;
            _mealRepo = mealRepo;
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public int AddDay(NewDayVm model)
        {
            var day = _mapper.Map<Day>(model);
            day.UserId = model.UserId;
            var meals = _mealRepo.GenerateDomainMealsForDay(model.Id);
            day.mealList = meals;
            _dayRepo.AddDay(day);
            return day.Id;
        }
        public void AddDaysForCustomer(string userId)
        {
            DateTime startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, DateTime.Today.Day);
            for(int i = 0; i<61; i++)
            {
                var newDay = new Day()
                {
                    UserId = userId,
                    Date = startDate,
                    mealList = new Meal[5]
                }; 
                newDay.mealList = _mealRepo.GenerateDomainMealsForDay(newDay.Id);
                _dayRepo.AddDay(newDay);
                startDate = startDate.AddDays(1);
            }
        }

        public void DeleteDay(int dayId)
        {
            _dayRepo.DeleteDay(dayId);
        }

        public ListDayDetailVm GetAllDaysForList()        
        {
            var days = _dayRepo.GetAllDays().ProjectTo<DayDetailVm>(_mapper.ConfigurationProvider).ToList();

            var dayList = new ListDayDetailVm()
            {
                Days = days,
                Count = days.Count()
            };

            return dayList;
        }

        public ListDayDetailVm GetAllDaysForUserForList(string userId)
        {
            var days = _dayRepo.GetAllDays().Where(d => d.UserId == userId).ProjectTo<DayDetailVm>(_mapper.ConfigurationProvider).ToList();
            var dayList = new ListDayDetailVm()
            {
                Days = days,
                Count = days.Count
            };

            return dayList;
        }

        public DayDetailVm GetDayById(int id)
        {
            var day = _dayRepo.GetDayById(id);
            var dayVm = _mapper.Map<DayDetailVm>(day);

            return dayVm;
        }
        public NewDayVm GetDayForEdit(int id)
        {
            var day = _dayRepo.GetDayById(id);
            var dayVm = _mapper.Map<NewDayVm>(day);

            return dayVm;
        }
        public void UpdateDay(NewDayVm model)
        {
            var day = _mapper.Map<Day>(model);
            _dayRepo.UpdateDay(day);
        }
    }
}


//private DayDetailVm CreateDayDetailVm(Day day)
//{
//    MealForListVm[] meals = new MealForListVm[5];
//    int i = 0;
//    foreach (var item in day.mealList)
//    {
//        var mealVm = new MealForListVm()
//        {
//            Id = item.Id,
//            TotalKcal = item.TotalKcal,
//            TotalCarb = item.TotalCarb,
//            TotalProtein = item.TotalProtein,
//            TotalFat = item.TotalFat,
//            TotalWeight = item.TotalWeight,
//            IsVisible = item.IsVisible,
//            DayId = item.DayId
//        };
//        meals[i] = mealVm;
//        i++;
//    }
//    DayDetailVm dayVm = new DayDetailVm()
//    {
//        Id = day.Id,
//        Date = day.Date,
//        TotalKcal = day.TotalKcal,
//        TotalCarbs = day.TotalCarbs,
//        TotalProtein = day.TotalProtein,
//        TotalFat = day.TotalFat,
//        TotalWeightInGram = day.TotalWeightInGram,
//        CustomerId = day.CustomerId,
//        mealList = meals
//    };

//    return dayVm;
//}