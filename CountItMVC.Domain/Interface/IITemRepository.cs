﻿using CountItMVC.Domain.Model;
using System.Linq;

namespace CountItMVC.Domain.Interface
{
    public interface IItemRepository
    {
        int DeleteItem(int itemId);
        int AddItem(Item item);
        IQueryable<Item> GetAllItems();
        IQueryable<Item> GetItemsByCategoryId(int typeId);
        Item GetItemById(int itemId);
        IQueryable<Tag> GetAllTags();
        void UpdateItem(Item item);
        void ChangeCategoryToDomainCategory(int categoryId);
        void UpdateCategoryWithoutSavingChanges(Item item);
    }
}