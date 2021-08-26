using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class NewItemVm : IMapFrom<Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double KcalPerHundredGrams { get; set; }
        public double FatPerHundredGrams { get; set; }
        public double ProteinPerHundredGrams { get; set; }
        public double CarbPerHundredGrams { get; set; }
        public int CategoryId { get; set; }
        //public IEnumerable<SelectListItem> Categories { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewItemVm, Item>().ReverseMap();
        }
    }

    public class NewItemValidation : AbstractValidator<NewItemVm>
    {
        public NewItemValidation()
        {
            RuleFor(x => x.Name).Length(3, 255);
            RuleFor(x => x.CategoryId).NotNull();
            RuleFor(x => x.FatPerHundredGrams).GreaterThan(0);
            RuleFor(x => x.FatPerHundredGrams).LessThan(100);
            RuleFor(x => x.CarbPerHundredGrams).GreaterThan(0);
            RuleFor(x => x.CarbPerHundredGrams).LessThan(100);
            RuleFor(x => x.KcalPerHundredGrams).GreaterThan(-0.1);
            RuleFor(x => x.KcalPerHundredGrams).LessThan(950);
            RuleFor(x => x.ProteinPerHundredGrams).GreaterThan(0);
            RuleFor(x => x.ProteinPerHundredGrams).LessThan(100);
        }
    }
}
