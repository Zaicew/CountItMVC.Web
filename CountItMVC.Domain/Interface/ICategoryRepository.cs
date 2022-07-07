using CountItMVC.Domain.Model;
using System.Collections.Generic;

namespace CountItMVC.Domain.Interface
{
    public interface ICategoryRepository
    {
        void DeleteCategory(int categoryId);
        int AddCategory(Category category); 
        IReadOnlyCollection<Category> GetAllCategories();
        IReadOnlyCollection<Tag> GetAllTags();
        Category GetCategoryById(int categoryId);
        void UpdateCategory(Category category);
    }
}
