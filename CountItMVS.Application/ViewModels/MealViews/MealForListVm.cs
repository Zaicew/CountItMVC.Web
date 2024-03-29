﻿using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Application.ViewModels.ItemInMealViews;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class MealForListVm : IMapFrom<Meal>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarb { get; set; }
        public double TotalWeight { get; set; }
        public bool IsVisible { get; set; }
        public int DayId { get; set; }
        public List<ItemInMealDetailVm> Items { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Meal, MealForListVm>().ForMember(i => i.Items, opt => opt.Ignore());
        }
    }
}
