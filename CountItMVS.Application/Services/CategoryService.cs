using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ListCategoryForListVm ViewAllCategoriesForList(int pageSize, int pageNo, string searchString)
        {
            var categories = _categoryRepo.GetAllCategories().Where(p => p.Name.StartsWith(searchString));
            var categoriesToShow = categories.Skip(pageSize * (pageNo - 1)).Take(pageSize);
            var result = new ListCategoryForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Categories = new List<CategoryForListVm>(),
                Counter = categories.Count()
            };
            foreach(var item in categoriesToShow)
            {
                result.Categories.Add(GetCategoryViewModel(item));
            }
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
