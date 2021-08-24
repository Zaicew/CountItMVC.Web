using CountItMVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class MealController : Controller
    {
        private readonly IMealService _mealService;
        private readonly IItemInMealService _itemInMealService;
        public MealController(IMealService mealService, IItemInMealService itemInMealService)
        {
            _mealService = mealService;
            _itemInMealService = itemInMealService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var meals = _mealService.GetAllMealsForList(2, 1);
            return View(meals);
        }
        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = string.Empty;
            }
            var meals = _mealService.GetAllMealsForList(pageSize, pageNo.Value);
            return View(meals);
        }
    }
}
