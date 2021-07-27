using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            var model = itemService.GetAllItemsForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddItem(ItemModel model)
        {
            var id = customerService.AddCustomer(model);
            return View();
        }

        [HttpGet]
        public IActionResult ChangeCategoryForItem(int itemId, int newCategoryId)
        {

            return View();
        }

        [HttpPost]
        public IActionResult ChangeCategoryForItem(ItemModel model)
        {
            var category = itemService.Items.FirstOrDefault(p => p.id == itemId);
            category.categoryId = newCategoryId;
            return View(model);
        }

        public IActionResult ViewItem(int itemId)
        {
            var itemModel = itemService.GetItem(itemId);
            return View(itemModel);
        }

    }
}
