using CountItMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IItemService
    {
        ListItemForListVm GetAllItemsForList(int pageSize, int pageNo, string searchString);
        int AddItem(NewItemVm item);
        int ChangeCategoryForItem(ChangeCategoryForItemVm category);
        ItemDetailVm GetItemById(int itemId);
        ListItemForListVm GettAllItemsFromCategory(int categoryId);
    }
}
