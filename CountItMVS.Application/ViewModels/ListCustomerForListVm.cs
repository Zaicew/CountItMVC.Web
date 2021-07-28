﻿using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListCustomerForListVm : IMapFrom<Customer>
    {
        public List<CustomerForListVM> Customers { get; set; }
        public int Count { get; set; }
    }
}
