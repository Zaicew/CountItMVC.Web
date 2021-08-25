using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepo, IMapper mapper, ICategoryRepository categoryRepo)
        {
            _itemRepo = itemRepo;
            _mapper = mapper;
            _categoryRepo = categoryRepo;
        }
        public int AddItem(NewItemVm itemVm)
        {
            var categories = _categoryRepo.GetAllCategories();
            var item = _mapper.Map<Item>(itemVm);
            var id = _itemRepo.AddItem(item);
            return id;
            //itemVm.Categories = new List<SelectListItem>();
            //var selectList = new List<SelectListItem>();
            //foreach(var cat in categories)
            //{
            //    selectList.Add(new SelectListItem { Value = cat.Id.ToString(), Text = cat.Name });
            //}
            //itemVm.Categories = selectList;           

        }
        public int ChangeCategoryForItem(ChangeCategoryForItemVm category)
        {
            throw new NotImplementedException();
        }
        public ListItemForListVm GetAllItemsForList(int pageSize, int pageNo, string searchString)
        {
            var items = _itemRepo.GetAllItems().Where(p => p.Name.StartsWith(searchString));
            var categories = _categoryRepo.GetAllCategories();
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
                var categoryName = categories.FirstOrDefault(c => c.Id == item.CategoryId).Name;
                var itemVm = CreateItemView(item, categoryName);
                result.Items.Add(itemVm);
            }
            return result;
        }        
        public ItemDetailVm GetItemById(int itemId)
        {
            var item = _itemRepo.GetItemById(itemId);
            ItemDetailVm result = new ItemDetailVm
            {
                Id = itemId,
                Name = item.Name,
                CategoryId = item.CategoryId,
                KcalPerHundredGrams = item.KcalPerHundredGrams,
                CarbPerHundredGrams = item.CarbPerHundredGrams,
                ProteinPerHundredGrams = item.ProteinPerHundredGrams,
                FatPerHundredGrams = item.FatPerHundredGrams
            };

            return result;
        }
        public ListItemForListVm GettAllItemsFromCategory(int categoryId)
        {
            var items = _itemRepo.GetItemsByCategoryId(categoryId);
            var categories = _categoryRepo.GetAllCategories();
            ListItemForListVm result = new ListItemForListVm
            {
                Items = new List<ItemsForListVm>()
            };
            foreach (var item in items)
            {
                var categoryName = categories.FirstOrDefault(c => c.Id == item.Id).Name;
                var itemVm = CreateItemView(item, categoryName);
                result.Items.Add(itemVm);
            }
            result.Count = result.Items.Count;
            return result;
        }
        private ItemsForListVm CreateItemView(Item item, string categoryName)
        {
            var itemVm = new ItemsForListVm()
            {
                Id = item.Id,
                Name = item.Name,
                CategoryId = item.CategoryId,
                KcalPerHundredGrams = item.KcalPerHundredGrams,
                CarbPerHundredGrams = item.CarbPerHundredGrams,
                ProteinPerHundredGrams = item.ProteinPerHundredGrams,
                FatPerHundredGrams = item.FatPerHundredGrams,
                CategoryName = categoryName
            };
            return itemVm;
        }
    }
}
