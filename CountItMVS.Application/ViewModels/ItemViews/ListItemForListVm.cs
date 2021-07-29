using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListItemForListVm : IMapFrom<Item>
    {
        public List<ItemsForListVm> Items { get; set; }
        public int Count { get; set; }
    }
}
