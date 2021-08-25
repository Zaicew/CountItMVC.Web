using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class NewCategoryVm : IMapFrom<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCategoryVm, Category>();
        }
    }

    public class NewCategoryValidation : AbstractValidator<NewCategoryVm>
    {
        public NewCategoryValidation()
        {
            RuleFor(x => x.Name).Length(3, 255);
        }
    }
}
