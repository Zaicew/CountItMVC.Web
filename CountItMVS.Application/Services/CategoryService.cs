using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public ListCategoryForListVm ViewAllCategoriesForList()
        {
            var categories = _categoryRepo.GetAllCategories();
            var result = new ListCategoryForListVm();
            result.Categories = new List<CategoryForListVm>();
            foreach(var item in categories)
            {
                result.Categories.Add(GetCategoryViewModel(item));
            }
            result.Counter = result.Categories.Count;
            return result;
        }

        public CategoryForListVm ViewCategory(int categoryId)
        {
            var category = _categoryRepo.GetCategoryById(categoryId);
            var result = new CategoryForListVm();
            result = GetCategoryViewModel(category);
            return result;
        }

        private CategoryForListVm GetCategoryViewModel(Category category)
        {
            var categoryVm = new CategoryForListVm()
            {
                Id = category.Id,
                Name = category.Name
            };
            return categoryVm;
        }
    }
}
