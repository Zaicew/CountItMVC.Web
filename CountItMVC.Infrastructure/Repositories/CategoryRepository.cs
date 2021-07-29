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
            if(!_context.Categories.Contains(category))
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return category.Id;
            }
            return -1;
        }

        public void DeleteCategory(int categoryId)
        {
            _context.Categories.Remove(_context.Categories.FirstOrDefault(p => p.Id == categoryId));
            _context.SaveChanges();
        }

        public IQueryable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public IQueryable<Tag> GetAllTags()
        {
            return _context.Tags;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(p => p.Id == categoryId);
        }
    }
}
