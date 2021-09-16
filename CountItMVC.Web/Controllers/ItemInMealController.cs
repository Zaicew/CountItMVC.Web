using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels.ItemViews;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class ItemInMealController : Controller
    {
        private readonly IDayService _dayService;
        private readonly IMealService _mealService;
        private readonly IItemService _itemService;
        private readonly IItemInMealService _itemInMealService;
        private readonly UserManager<ApplicationUser> _userMenager;

        public ItemInMealController(IDayService dayService, IMealService mealService, 
            IItemService itemService, IItemInMealService itemInMealService, UserManager<ApplicationUser> userManager)
        {
            _dayService = dayService;
            _mealService = mealService;
            _itemService = itemService;
            _itemInMealService = itemInMealService;
            _userMenager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("ItemInMeal/AddItemToMeal")]
        public IActionResult AddItemToMeal()
        {
            var items = _itemService.GetAllItems();
            ViewBag.items = new SelectList(items, "Id", "Name");
            var meals = _mealService.GetAllMeals();
            ViewBag.meals = new SelectList(meals, "Id", "Id");
            return View(new AddItemToMealVm());
        }

        [HttpPost]
        [Route("ItemInMeal/AddItemToMeal")]
        public IActionResult AddItemToMeal(AddItemToMealVm model)
        {
            var id = _itemInMealService.AddItemToMeal(model);
            return RedirectToAction(controllerName: "Meal", actionName: "Index");
        }
    }
}
