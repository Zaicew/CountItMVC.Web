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
        public double TotalKcal { get; set; }
        public double TotalFat { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbs { get; set; }
        public double TotalWeightInGram { get; set; }
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