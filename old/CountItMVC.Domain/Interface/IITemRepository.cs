using CountItMVC.Domain.Model;
using System.Linq;

namespace CountItMVC.Domain.Interface
{
    public interface IItemRepository
    {
        void DeleteItem(int itemId);
        int AddItem(Item item);
        IQueryable<Item> GetItemsByCategoryId(int typeId);
        Item GetItemById(int itemId);
        IQueryable<Tag> GetAllTags();
        IQueryable<Category> GetAllCategories();
    }
}