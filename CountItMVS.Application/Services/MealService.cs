using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class MealService : IMealService
    {
        private readonly IMealRepository _mealRepo;
        private readonly IMapper _mapper;

        public MealService(IMealRepository mealRepo, IMapper mapper)
        {
            _mealRepo = mealRepo;
            _mapper = mapper;
        }
    }
}
