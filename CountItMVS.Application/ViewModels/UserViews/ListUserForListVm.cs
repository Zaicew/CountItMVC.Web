using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels.UserViews
{   
    public class ListUserForListVm : IMapFrom<ApplicationUser>
    {
        public List<UserForListVm> Users { get; set; }
        public int Count { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string SearchString { get; set; }

    }
}
