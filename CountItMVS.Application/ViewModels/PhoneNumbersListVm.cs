using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class PhoneNumbersListVm : IMapFrom<Customer>
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
    }
}
