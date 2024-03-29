﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace CountItMVC.Domain.Model
{
    public class ItemInMeal
    {
        public int Id { get; set; }
        public double HowManyGramsCurrentProduct { get; set; }
        //public double KcalCurrentItem { get; set; }
        //public double ProteinCurrentItem { get; set; }
        //public double FatCurrentItem { get; set; }
        //public double CarbCurrentItem { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }

    }
}