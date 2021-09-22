using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels.ItemViews
{
    public class AddItemToMealVm : IMapFrom<ItemInMeal>
    {
        public int Id { get; set; }
        public double HowManyGramsCurrentProduct { get; set; }
        public int ItemId { get; set; }
        public int MealId { get; set; }
        public List<SelectListItem> Items { get; set; }
        public List<SelectListItem> Meals { get; set; }
        public string PreviousUrl { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddItemToMealVm, ItemInMeal>().ReverseMap()
                .ForMember(c => c.Items, opt => opt.Ignore())
                .ForMember(c => c.Meals, opt => opt.Ignore())
                .ForMember(c => c.PreviousUrl, opt => opt.Ignore());
        }
    }
}
