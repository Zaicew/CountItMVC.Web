using CountItMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface ICategoryService
    {
        ListCategoryForListVm ViewAllCategoriesForList(int pageSize, int pageNo, string searchString);
        CategoryForListVm ViewCategory(int categoryId);
    }
}
