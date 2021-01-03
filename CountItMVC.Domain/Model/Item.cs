using System.Collections;
using System.Collections.Generic;

namespace CountItMVC.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double KcalPerHundredGrams { get; set; }
        public double FatPerHundredGrams { get; set; }
        public double ProteinPerHundredGrams { get; set; }
        public double CarbPerHundredGrams { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ItemTag> ItemsTags { get; set; }
    }
}