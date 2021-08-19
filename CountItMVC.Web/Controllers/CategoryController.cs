using CountItMVC.Application.Interfaces;
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
            return View();
        }

        public IActionResult ViewAllCategories()
        {
            var categories = _categoryService.ViewAllCategoriesForList();
            return View(categories);
        }
        [HttpGet("categoryId")]
        [Route("Category/ViewCategoryDetails/{*categoryId}")]
        public IActionResult ViewCategoryDetails(int categoryId)
        {
            var result = _categoryService.ViewCategory(categoryId);
            return View(result);
        }
    }
}
