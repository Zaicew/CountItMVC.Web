using CountItMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IItemService
    {
        ListItemForListVm GetAllItemsForList();
        int AddItem(NewItemVm item);
        int ChangeCategoryForItem(ChangeCategoryForItemVm category);
        ItemDetailVm GetItemById(int itemId);
    }
}
