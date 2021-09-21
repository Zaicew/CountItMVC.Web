using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
        NewItemVm GetItemForEdit(int id);
        void UpdateItem(NewItemVm model);
        void DeleteItem(int itemId);
        void ChangeCategoryForAllItemsFromDeletingCategory(int categoryId);
        IQueryable<Item> GetAllItems();
        List<ItemsForListVm> GenerateItemViewsFromMeal(int mealId);
    }
}
