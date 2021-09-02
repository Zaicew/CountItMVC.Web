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
        private readonly IMapper _mapper;

        public DayService(IDayRepository dayRepo, IMapper mapper)
        {
            _dayRepo = dayRepo;
            _mapper = mapper;
        }
        public int AddDay(NewDayVm model)
        {
            var day = _mapper.Map<Day>(model);
            _dayRepo.AddDay(day);
            return day.Id;
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
            //var days = _dayRepo.GetAllDays();
            //var result = new ListDayDetailVm();
            
            //foreach (var item in days)
            //{
            //    var dayVm = new DayDetailVm()
            //    {
            //        Id = item.Id,
            //        Date = item.Date,
            //        TotalWeightInGram = item.TotalWeightInGram,
            //        TotalKcal = item.TotalKcal,
            //        TotalCarbs = item.TotalCarbs,
            //        TotalProtein = item.TotalProtein,
            //        TotalFat = item.TotalFat,
            //        CustomerId = item.CustomerId,
            //        //mealList = new MealForListVm[5] 
            //};
            //    //dayVm.mealList = CreateMealListVmForCurrentDay(item);
            //    result.Days.Add(dayVm);
            //}
            //result.Count = result.Days.Count;

            //return result;
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