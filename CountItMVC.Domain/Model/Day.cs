using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;

namespace CountItMVC.Domain.Model
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalKcal
        {
            get
            {
                double result = 0;
                //foreach (var item in mealList)
                //{
                //    if (item.IsVisible)
                //    {
                //        result += item.TotalKcal;
                //    }
                //}
                return result;
            }
        }
        public double TotalFat
        {
            get
            {
                double result = 0;
                //foreach (var item in mealList)
                //{
                //    if (item.IsVisible)
                //    {
                //        result += item.TotalFat;
                //    }
                //}
                return result;
            }
        }
        public double TotalProtein
        {
            get
            {
                double result = 0;
                //foreach (var item in mealList)
                //{
                //    if (item.IsVisible)
                //    {
                //        result += item.TotalProtein;
                //    }
                //}
                return result;
            }
        }
        public double TotalCarbs
        {
            get
            {
                double result = 0;
                //foreach (var item in mealList)
                //{
                //    if (item.IsVisible)
                //    {
                //        result += item.TotalCarb;
                //    }
                //}
                return result;
            }
        }
        public double TotalWeightInGram
        {
            get
            {
                double result = 0;
                foreach (var item in mealList)
                {
                    //if (item.IsVisible)
                    //{
                        //result += item.TotalWeight;
                    //}
                }
                return result;
            }
        }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Meal[] mealList = new Meal[5];

        public virtual ICollection<DayTag> DaysTags { get; set; }

        //public AspNetUsers asp { get; set; }

        //public static string getUserId(this ClaimsPrincipal user)
        //{
        //    ClaimsPrincipal currentUser = user;
        //    return currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
        //}
    }
}