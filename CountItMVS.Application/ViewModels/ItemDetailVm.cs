using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class ItemDetailVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double KcalPerHundredGrams { get; set; }
        public double FatPerHundredGrams { get; set; }
        public double ProteinPerHundredGrams { get; set; }
        public double CarbPerHundredGrams { get; set; }
        public int CategoryId { get; set; }
    }
}
