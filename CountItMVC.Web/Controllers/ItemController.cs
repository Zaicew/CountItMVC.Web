using CountItMVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IActionResult ViewAllItems()
        {
            var items = _itemService.GetAllItemsForList(2, 1, "");
            return View(items);
        }
        [HttpPost]
        public IActionResult ViewAllItems(int pageSize, int? pageNo, string searchString )
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if(searchString is null)
            {
                searchString = String.Empty;
            }
            var items = _itemService.GetAllItemsForList(pageSize, pageNo.Value, searchString);
            return View(items);
        }

        [HttpGet("{itemId}")]
        [Route("Item/ViewItem/{itemId}")]
        public IActionResult ViewItem(int itemId)
        {
            var item = _itemService.GetItemById(itemId);
            return View(item);
        }

        [HttpGet("{categoryId}")]
        [Route("Item/ViewAllItemsFromCategory/{categoryId}")]
        public IActionResult ViewAllItemsFromCategory(int categoryId)
        {
            var items = _itemService.GettAllItemsFromCategory(categoryId);
            return View(items);
        }

        //public IActionResult Index()
        //{
        //    var model = itemService.GetAllItemsForList();
        //    return View(model);
        //}

        //[HttpGet]
        //public IActionResult AddItem()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddItem(ItemModel model)
        //{
        //    var id = customerService.AddCustomer(model);
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult ChangeCategoryForItem(int itemId, int newCategoryId)
        //{

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult ChangeCategoryForItem(ItemModel model)
        //{
        //    var category = itemService.Items.FirstOrDefault(p => p.id == itemId);
        //    category.categoryId = newCategoryId;
        //    return View(model);
        //}

        //public IActionResult ViewItem(int itemId)
        //{
        //    var itemModel = itemService.GetItem(itemId);
        //    return View(itemModel);
        //}

    }
}
