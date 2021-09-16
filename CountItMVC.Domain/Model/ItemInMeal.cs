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
        //{
        //    get
        //    {
        //        return this.HowManyGramsCurrentProduct;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //            this.HowManyGramsCurrentProduct = value;
        //        else
        //        {
        //            //mistake!
        //        }
        //    }
        //}
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        //public ItemInMeal()
        //{

        //}
        ////public virtual ICollection<Meal> Meals { get; set; }
        //public ItemInMeal(Item item, double weight) : base(item)
        //{
        //    this.HowManyGramsCurrentProduct = weight;
        //}

    }
}