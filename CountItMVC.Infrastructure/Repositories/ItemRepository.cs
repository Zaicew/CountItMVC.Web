using System.ComponentModel.DataAnnotations;
using System.Linq;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;

namespace CountItMVC.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        public ItemRepository(Context context)
        {
            _context = context;
        }
        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }

        }
        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }
        public IQueryable<Item> GetItemsByCategoryId(int categoryId)
        {
            var output = _context.Items.Where(c => c.CategoryId == categoryId);
            return output;
        }
        public Item GetItemById(int itemId)
        {
            var output = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return output;
        }
        public IQueryable<Tag> GetAllTags()
        {

            var output = _context.Tags;
            return output;
        }
        public IQueryable<Item> GetAllItems()
        {
            return _context.Items;
        }

    }
}