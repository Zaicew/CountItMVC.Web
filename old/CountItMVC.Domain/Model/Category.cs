using System.Collections;
using System.Collections.Generic;

namespace CountItMVC.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<CategoryTag> CategoriesTags { get; set; }
    }
}