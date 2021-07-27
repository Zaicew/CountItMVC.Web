using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepo;
        public int AddItem(NewItemVm item)
        {
            throw new NotImplementedException();
        }

        public int ChangeCategoryForItem(ChangeCategoryForItemVm category)
        {
            throw new NotImplementedException();
        }

        public ListItemForListVm GetAllItemsForList()
        {
            var items = _itemRepo.GetAllItems();
            ListItemForListVm result = new ListItemForListVm();
            result.Items = new List<ItemsForListVm>();
            foreach(var item in items)
            {
                var custVm = new ItemsForListVm()
                {
                    Id = item.Id,
                    Name = item.Name,
                    CategoryId = item.CategoryId,
                    KcalPerHundredGrams = item.KcalPerHundredGrams,
                    CarbPerHundredGrams = item.CarbPerHundredGrams,
                    ProteinPerHundredGrams = item.ProteinPerHundredGrams,
                    FatPerHundredGrams = item.FatPerHundredGrams,
                };
                result.Items.Add(custVm);
            }
            result.Count = result.Items.Count;
            return result;
        }

        public ItemDetailVm GetItemById(int itemId)
        {
            var item = _itemRepo.GetItemById(itemId);
            ItemDetailVm result = new ItemDetailVm();
            result.Id = item.Id;
            result.Name = item.Name;
            result.CategoryId = item.CategoryId;
            result.KcalPerHundredGrams = item.KcalPerHundredGrams;
            result.CarbPerHundredGrams = item.CarbPerHundredGrams;
            result.ProteinPerHundredGrams = item.ProteinPerHundredGrams;
            result.FatPerHundredGrams = item.FatPerHundredGrams;

            return result;
        }
    }
}
