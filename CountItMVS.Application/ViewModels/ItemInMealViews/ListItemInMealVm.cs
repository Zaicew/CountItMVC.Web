using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels.ItemInMealViews
{
    public class ListItemInMealVm : IMapFrom<ItemInMeal>
    {
        public List<ItemInMealVm> Items { get; set; }
        public int Count { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ItemInMeal, ListItemInMealVm>();
        }
    }
}
