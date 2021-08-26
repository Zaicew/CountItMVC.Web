using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface ICategoryRepository
    {
        void DeleteCategory(int categoryId);
        int AddCategory(Category category); 
        IQueryable<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
        IQueryable<Tag> GetAllTags();
        void UpdateCategory(Category category);
    }
}
