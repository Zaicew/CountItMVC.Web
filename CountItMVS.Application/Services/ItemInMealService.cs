using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class ItemInMealService : IItemInMealService
    {
        private readonly IMapper _mapper;
        private readonly IItemInMealRepository _itemInMealRepo;

        public ItemInMealService(IItemInMealRepository itemInMealRepository, IMapper mapper)
        {
            _mapper = mapper;
            _itemInMealRepo = itemInMealRepository;
        }
    }
}
