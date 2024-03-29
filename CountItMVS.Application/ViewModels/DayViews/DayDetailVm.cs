﻿using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class DayDetailVm : IMapFrom<Day>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalWeightInGram { get; set; }
        public string UserId { get; set; }

        public List<MealForListVm> mealList = new List<MealForListVm>();


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Day, DayDetailVm>()
                .ForMember(c => c.mealList, opt => opt.Ignore());

            //profile.CreateMap<Day, DayDetailVm>()
            //    .ForMember(c => c.mealList, opt => opt.MapFrom(s => s.mealList));
        }

    }
}
