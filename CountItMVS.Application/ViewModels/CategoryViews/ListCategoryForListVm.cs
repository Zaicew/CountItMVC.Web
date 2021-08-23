using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListCategoryForListVm : IMapFrom<Category>
    {
        public List<CategoryForListVm> Categories { get; set; }
        public int Counter { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string SearchString { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, ListCategoryForListVm>();
        }

    }
}
