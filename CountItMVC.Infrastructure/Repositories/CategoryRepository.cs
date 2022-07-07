using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;

namespace CountItMVC.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public int AddCategory(Category category)
        {
            if(_context.Categories.FirstOrDefault(c => c.Name == category.Name) is null)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return category.Id;
            }
            return -1;
        }
        public void DeleteCategory(int categoryId)
        {
            var categoryToRemove = _context.Categories.FirstOrDefault(p => p.Id == categoryId);
            if (categoryToRemove == null) return;
            _context.Categories.Remove(categoryToRemove);
            _context.SaveChanges();
        }
        public IReadOnlyCollection<Category> GetAllCategories()
        {
            return _context.Categories.ToArray();
        }
        public IReadOnlyCollection<Tag> GetAllTags()
        {
            return _context.Tags.ToArray();
        }
        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(p => p.Id == categoryId);
        }
        public void UpdateCategory(Category category)
        {
            _context.Attach(category);
            _context.Entry(category).Property("Name").IsModified = true;
            _context.SaveChanges();
        }
    }
}
