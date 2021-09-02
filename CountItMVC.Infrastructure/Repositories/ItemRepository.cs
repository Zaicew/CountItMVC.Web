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
        public int DeleteItem(int itemId)
        {
            var itemToDelete = _context.Items.FirstOrDefault(i => i.Id == itemId);
            if(itemToDelete is null)
            {
                return -1;
            }
            _context.Items.Remove(itemToDelete);
            _context.SaveChanges();
            return itemToDelete.Id;
        }
        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }
        public void UpdateItem(Item item)
        {
            _context.Attach(item);
            _context.Entry(item).Property("Name").IsModified = true;
            _context.Entry(item).Property("KcalPerHundredGrams").IsModified = true;
            _context.Entry(item).Property("FatPerHundredGrams").IsModified = true;
            _context.Entry(item).Property("ProteinPerHundredGrams").IsModified = true;
            _context.Entry(item).Property("CarbPerHundredGrams").IsModified = true;
            _context.Entry(item).Property("CategoryId").IsModified = true;
            _context.SaveChanges();
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

        public void ChangeCategoryToDomainCategory(int categoryId)
        {
            var itemsToChangeCategory = _context.Items.Where(i => i.CategoryId == categoryId);
            foreach (var item in itemsToChangeCategory)
            {
                item.CategoryId = 1;
                UpdateItem(item);
            }
        }

        public void UpdateCategoryWithoutSavingChanges(Item item)
        {
            _context.Attach(item);
            _context.Entry(item).Property("CategoryId").IsModified = true;
        }

        //public void ChangeCategoriesForDeletingCategory(int categoryId)
        //{
        //    var itemsToChangeCategory = _context.Items.Where(i => i.CategoryId == categoryId);
        //    foreach(var item in itemsToChangeCategory)
        //    {
        //        item.CategoryId = 1;
        //        UpdateItem(item);
        //    }
        //}

        //public void UpdateItemCategory(Item item)
        //{

        //}
    }
}