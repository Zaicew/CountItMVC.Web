using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CountItMVC.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0,900)]
        public double KcalPerHundredGrams { get; set; }
        [Range(0, 100)]
        public double FatPerHundredGrams { get; set; }
        [Range(0, 100)]
        public double ProteinPerHundredGrams { get; set; }
        [Range(0, 100)]
        public double CarbPerHundredGrams { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ItemTag> ItemsTags { get; set; }

        //public Item()
        //{

        //}

        //public Item(int id, string name)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //}
        //public Item(Item item)
        //{
        //    Id = item.Id;
        //    Name = item.Name;
        //}
    }

}