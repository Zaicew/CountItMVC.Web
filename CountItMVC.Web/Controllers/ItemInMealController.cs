using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels.ItemViews;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

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
        public IActionResult AddItemToMeal(int id)
        {
            //var items = _itemService.GetAllItems();
            //ViewBag.items = new SelectList(items, "Id", "Name");
            //var meals = _mealService.GetAllMeals();
            //ViewBag.meals = new SelectList(meals, "Id", "Id");
            //var addItemToMealVm = new AddItemToMealVm();
            //addItemToMealVm.MealId = id;
            var itemsVm = _itemService.GetAllItemsForList(2, 1, "");
            var itemInMealVm = new AddItemToMealVm() { Items = itemsVm , MealId = id};
            return View(itemInMealVm);
        }

        [HttpPost]
        [Route("ItemInMeal/AddItemToMeal")]
        public IActionResult AddItemToMeal(AddItemToMealVm model)
        {
            var itemsInMeal = _itemInMealService.GetAllItemsInMeal(model.MealId);
            if(!itemsInMeal.Contains(itemsInMeal.FirstOrDefault(i => i.ItemId == model.ItemId)))
            {
                var id = _itemInMealService.AddItemToMeal(model);
                TempData["Success"] = "Item has been added to meal!";
                return RedirectToAction("AddItemToMeal", "ItemInMeal", id = model.MealId);
                //return RedirectToAction("AddItemToMeal", "ItemInMeal", id = model.MealId);
            }
            else
            {
                TempData["Error"] = "You have arleady added this product to choosen meal!";
                return RedirectToAction(controllerName:"ItemInMeal", actionName:"AddItemToMeal");
            }

        }
        [HttpGet]
        [Route("ItemInMeal/EditItemInMeal")]
        public IActionResult EditItemInMeal(int id)
        {
            var itemInMeal = _itemInMealService.GetItemInMealForEdit(id);
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            return View(itemInMeal);
        }

        [HttpPost]
        [Route("ItemInMeal/EditItemInMeal")]
        public IActionResult EditItemInMeal(AddItemToMealVm model, string returnUrl)
        {
            _itemInMealService.UpdateItemInMeal(model);
            return Redirect(returnUrl);
        }

    }
}
