using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ChangeCategoryForItemVm : IMapFrom<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, CategoryForListVm>();
        }
    }
}
