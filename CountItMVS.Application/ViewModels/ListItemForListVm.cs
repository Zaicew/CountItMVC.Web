﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ListItemForListVm
    {
        public List<ItemsForListVm> Items { get; set; }
        public int Count { get; set; }
    }
}