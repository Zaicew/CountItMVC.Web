using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepo;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepo, IMapper mapper)
        {
            _itemRepo = itemRepo;
            _mapper = mapper;
        }
        public int AddItem(NewItemVm item)
        {
            throw new NotImplementedException();
        }
        public int ChangeCategoryForItem(ChangeCategoryForItemVm category)
        {
            throw new NotImplementedException();
        }
        public ListItemForListVm GetAllItemsForList(int pageSize, int pageNo, string searchString)
        {
            var items = _itemRepo.GetAllItems().Where(p => p.Name.StartsWith(searchString));
            var itemsToShow = items.Skip(pageSize * (pageNo-1)).Take(pageSize).ToList();
            ListItemForListVm result = new ListItemForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Items = new List<ItemsForListVm>(),
                Count = items.Count()
            };
            foreach(var item in itemsToShow)
            {
                var itemVm = CreateItemView(item);
                result.Items.Add(itemVm);
            }
            return result;
        }        
        public ItemDetailVm GetItemById(int itemId)
        {
            var item = _itemRepo.GetItemById(itemId);
            ItemDetailVm result = new ItemDetailVm();
            result.Id = itemId;
            result.Name = item.Name;
            result.CategoryId = item.CategoryId;
            result.KcalPerHundredGrams = item.KcalPerHundredGrams;
            result.CarbPerHundredGrams = item.CarbPerHundredGrams;
            result.ProteinPerHundredGrams = item.ProteinPerHundredGrams;
            result.FatPerHundredGrams = item.FatPerHundredGrams;

            return result;
        }
        public ListItemForListVm GettAllItemsFromCategory(int categoryId)
        {
            var items = _itemRepo.GetItemsByCategoryId(categoryId);
            ListItemForListVm result = new ListItemForListVm();
            result.Items = new List<ItemsForListVm>();
            foreach(var item in items)
            {
                var itemVm = CreateItemView(item);
                result.Items.Add(itemVm);
            }
            result.Count = result.Items.Count;
            return result;
        }
        private ItemsForListVm CreateItemView(Item item)
        {
            var itemVm = new ItemsForListVm()
            {
                Id = item.Id,
                Name = item.Name,
                CategoryId = item.CategoryId,
                KcalPerHundredGrams = item.KcalPerHundredGrams,
                CarbPerHundredGrams = item.CarbPerHundredGrams,
                ProteinPerHundredGrams = item.ProteinPerHundredGrams,
                FatPerHundredGrams = item.FatPerHundredGrams
            };
            return itemVm;
        }
    }
}
