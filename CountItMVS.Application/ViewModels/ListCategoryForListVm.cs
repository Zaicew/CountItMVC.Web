using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListCategoryForListVm : IMapFrom<Customer>
    {
        public List<CategoryForListVm> Categories { get; set; }
        public int Counter { get; set; }

    }
}
