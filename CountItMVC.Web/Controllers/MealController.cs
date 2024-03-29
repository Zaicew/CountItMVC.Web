﻿using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class MealController : Controller
    {
        private readonly IMealService _mealService;
        private readonly IItemInMealService _itemInMealService;
        private readonly IDayService _dayService;
        public MealController(IMealService mealService, IItemInMealService itemInMealService, IDayService dayService)
        {
            _mealService = mealService;
            _dayService = dayService;
            _itemInMealService = itemInMealService;
        }

        //[HttpGet]
        //[Route("Meal/ViewAllMealsFromCurrentUser")]
        //public IActionResult ViewAllMealsFromCurrentUser()
        //{
        //    //var userId = HttpContext.User.Identities.Where(i => i.Name == HttpContext.User.Identity.Name).ToList()[0].Claims.ToList()[0].Value;
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var meals = _mealService.GetAllMealsFromUserForList(2,1, userId);
        //    return View(meals);
        //}

        //[HttpPost]
        //[Route("Meal/ViewAllMealsFromCurrentUser")]
        //public IActionResult ViewAllMealsFromCurrentUser(int pageSize, int? pageNo, string userId)
        //{
        //    if(!pageNo.HasValue)
        //    {
        //        pageNo = 1;
        //    }
        //    var meals = _mealService.GetAllMealsFromUserForList(2,1, userId);
        //    return View(meals);
        //}

        [HttpGet]
        [Route("Meal/Index")]
        public IActionResult Index()
        {
            var meals = _mealService.GetAllMealsForList(2, 1);
            return View(meals);
        }
        [HttpPost]
        [Route("Meal/Index")]
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

        [HttpGet]
        [Route("Meal/AddMeal")]
        public IActionResult AddMeal()
        {
            return View(new NewMealVm());
        }

        [HttpPost]
        [Route("Meal/AddMeal")]
        public IActionResult AddMeal(NewMealVm model)
        {
            _mealService.AddMeal(model);
            return View(model);
        }
        [HttpGet]
        [Route("Meal/EditMeal/{id}")]
        public IActionResult EditMeal(int id)
        {
            var meal = _mealService.GetMealForEdit(id);
            return View(meal);
        }

        [HttpPost]
        [Route("Meal/EditMeal")]
        public IActionResult EditMeal(NewMealVm model)
        {
            _mealService.UpdateMeal(model);
            return RedirectToAction("Index");
        }

        [Route("Meal/MealDetail/{mealId}")]
        public IActionResult MealDetail(int mealId)
        {
            var meal = _mealService.GetMeal(mealId);
            return View(meal);
        }
    }
}
