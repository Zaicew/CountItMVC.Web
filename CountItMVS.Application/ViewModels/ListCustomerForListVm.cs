using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListCustomerForListVm
    {
        public List<CustomerDetailsVm> Customers { get; set; }
        public int Count { get; set; }
    }
}
