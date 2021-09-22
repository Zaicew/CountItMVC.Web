using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels.ItemViews;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class ItemInMealService : IItemInMealService
    {
        private readonly IMapper _mapper;
        private readonly IItemInMealRepository _itemInMealRepo;
        private readonly IItemRepository _itemRepo;
        private readonly IDayRepository _dayRepo;
        private readonly IMealRepository _mealRepo;

        public ItemInMealService(IItemInMealRepository itemInMealRepo, IItemRepository itemRepo, IDayRepository dayRepo, IMealRepository mealRepo, IMapper mapper)
        {
            _mapper = mapper;
            _itemInMealRepo = itemInMealRepo;
            _itemRepo = itemRepo;
            _dayRepo = dayRepo;
            _mealRepo = mealRepo;
        }

        public int AddItemToMeal(AddItemToMealVm model)
        {
            var itemInMeal = _mapper.Map<ItemInMeal>(model);
            //_mealRepo.AddItemToMeal(itemInMeal);
            //var item = _itemRepo.GetItemById(model.ItemId);
            //var meal = _mealRepo.GetMeal(model.MealId);
            //meal.ItemsInMeal.Add(itemInMeal);
            //_mealRepo.UpdateMeal(meal);
            //var day = _dayRepo.GetDayById(meal.DayId);
            var id = _itemInMealRepo.AddItemToMeal(itemInMeal);

            return id;
        }

        public IQueryable<ItemInMeal> GetAllItemsInMeal(int mealId)
        {
            var itemsInMeal = _itemInMealRepo.GetAllItemsInMeal(mealId);
            return itemsInMeal;
        }

        public AddItemToMealVm GetItemInMealForEdit(int itemInMealId)
        {
            var itemInMeal = _itemInMealRepo.GetItemInMeal(itemInMealId);
            var itemInMealVm = _mapper.Map<AddItemToMealVm>(itemInMeal);
            return itemInMealVm;
        }

        public void UpdateItemInMeal(AddItemToMealVm model)
        {
            var itemInMeal = _mapper.Map<ItemInMeal>(model);
            _itemInMealRepo.UpdateItemInMeal(itemInMeal);
        }
    }
}
