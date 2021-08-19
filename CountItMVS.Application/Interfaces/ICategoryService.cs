using CountItMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface ICategoryService
    {
        ListCategoryForListVm ViewAllCategoriesForList();
        CategoryForListVm ViewCategory(int categoryId);
    }
}
