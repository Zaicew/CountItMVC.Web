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
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("ViewAllCategories");
        }
        [HttpGet]
        public IActionResult ViewAllCategories()
        {
            var categories = _categoryService.ViewAllCategoriesForList(2,1,"");
            return View(categories);
        }
        [HttpPost]
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
        public IActionResult AddCategory()
        {
            return View(new NewCategoryVm());
        }
        [HttpPost]
        public IActionResult AddCategory(NewCategoryVm model)
        {
            var id = _categoryService.AddCategory(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = _categoryService.GetCategoryForEdit(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditCategory(NewCategoryVm model)
        {
            _categoryService.UpdateCategory(model);
            return RedirectToAction("Index");
        }
    }
}
