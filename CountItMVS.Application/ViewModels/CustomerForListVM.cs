﻿using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class CustomerForListVM : IMapFrom<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Customer, CustomerForListVM>();
        }
    }
}
