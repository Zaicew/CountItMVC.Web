using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CountItMVC.Domain.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CategoryTag> CategoriesTags { get; set; }
        public virtual ICollection<ItemTag> ItemsTags { get; set; }
        public virtual ICollection<DayTag> DaysTags { get; set; }

    }
}