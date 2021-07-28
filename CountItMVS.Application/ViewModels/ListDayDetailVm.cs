using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListDayDetailVm : IMapFrom<Customer>
    {
        public List<DayDetailVm> Days { get; set; }
        public int Count { get; set; }
    }
}
