using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class NewDayVm : IMapFrom<Day>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }

        public List<MealForListVm> mealList = new List<MealForListVm>();


        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewDayVm, Day>()
                .ForMember(c => c.mealList, opt => opt.Ignore())
                .ForMember(c => c.UserId, opt => opt.Ignore()).ReverseMap();
        }
    }
}
