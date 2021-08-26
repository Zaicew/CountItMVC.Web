using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface ICategoryService
    {
        ListCategoryForListVm ViewAllCategoriesForList(int pageSize, int pageNo, string searchString);
        CategoryForListVm ViewCategory(int categoryId);
        int AddCategory(NewCategoryVm model);
        NewCategoryVm GetCategoryForEdit(int id);
        void UpdateCategory(NewCategoryVm model);
        IQueryable<Category> GetAllCategories();
    }
}
