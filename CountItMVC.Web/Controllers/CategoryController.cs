using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IItemService _itemService;
        public CategoryController(ICategoryService categoryService, IItemService itemService)
        {
            _categoryService = categoryService;
            _itemService = itemService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("ViewAllCategories");
        }
        [HttpGet]
        [Route("Category/ViewAllCategories")]
        public IActionResult ViewAllCategories()
        {
            var categories = _categoryService.ViewAllCategoriesForList(2,1,"");
            return View(categories);
        }
        [HttpPost]
        [Route("Category/ViewAllCategories")]
        public IActionResult ViewAllCategories(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = string.Empty;
            }
            var categories = _categoryService.ViewAllCategoriesForList(pageSize, pageNo.Value, searchString);
            return View(categories);
        }
        [HttpGet("categoryId")]
        [Route("Category/ViewCategoryDetails/{*categoryId}")]
        public IActionResult ViewCategoryDetails(int categoryId)
        {
            var result = _categoryService.ViewCategory(categoryId);
            return View(result);
        }
        [HttpGet]
        [Route("Category/AddCategory")]
        public IActionResult AddCategory()
        {
            return View(new NewCategoryVm());
        }
        [HttpPost]
        [Route("Category/AddCategory")]
        public IActionResult AddCategory(NewCategoryVm model)
        {
            var id = _categoryService.AddCategory(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("Category/EditCategory")]
        public IActionResult EditCategory(int id)
        {
            var category = _categoryService.GetCategoryForEdit(id);
            return View(category);
        }
        [HttpPost]
        [Route("Category/EditCategory")]
        public IActionResult EditCategory(NewCategoryVm model)
        {
            _categoryService.UpdateCategory(model);
            return RedirectToAction("Index");
        }
        [HttpGet("{categoryId}")]
        [Route("category/deletecategory/{categoryId}")]
        public IActionResult DeleteCategory(int categoryId)
        {
            _itemService.ChangeCategoryForAllItemsFromDeletingCategory(categoryId);
            _categoryService.DeleteCategory(categoryId);
            return RedirectToAction("Index");
        }

    }
}
