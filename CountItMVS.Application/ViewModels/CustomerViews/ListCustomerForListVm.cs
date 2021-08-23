using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListCustomerForListVm : IMapFrom<Customer>
    {
        public List<CustomerForListVm> Customers { get; set; }
        public int Count { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string SearchString { get; set; }
    }
}
