using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly ICategoryService _categoryService;
        public ItemController(IItemService itemService, ICategoryService categoryService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
        }
        [Route("Item/Index")]
        public IActionResult Index()
        {
            return RedirectToAction("ViewAllItems");
        }
        [HttpGet]
        [Route("Item/ViewAllItems")]
        public IActionResult ViewAllItems()
        {
            var items = _itemService.GetAllItemsForList(2, 1, "");
            return View(items);
        }
        [HttpPost]
        [Route("Item/ViewAllItems")]
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

        [HttpGet]
        [Route("Item/AddItem")]
        public IActionResult AddItem()
        {
            var categories = _categoryService.GetAllCategories();
            ViewBag.categories = new SelectList(categories, "Id", "Name");
            //var model = new NewItemVm()
            //{
            //    Categories = new List<SelectListItem>()};
            //foreach (var cat in categories)
            //{
            //    model.Categories.Add(new SelectListItem(cat.Name, cat.Id.ToString()));
            //}
            return View();
        }
        [HttpPost]
        [Route("Item/AddItem")]
        public IActionResult AddItem(NewItemVm model)
        {
            _itemService.AddItem(model);
            return RedirectToAction("ViewAllItems");
        }
        [HttpGet]
        [Route("Item/EditItem")]
        public IActionResult EditItem(int id)
        {
            var item = _itemService.GetItemForEdit(id);
            return View(item);
        }
        [HttpPost]
        [Route("Item/EditItem")]
        public IActionResult EditItem(NewItemVm model)
        {
            _itemService.UpdateItem(model);
            return RedirectToAction("ViewAllItems");
        }
        [HttpGet("{itemId}")]
        [Route("item/deleteitem/{itemId}")]
        public IActionResult DeleteItem(int itemId)
        {
            _itemService.DeleteItem(itemId);
            return RedirectToAction("ViewAllItems");
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
