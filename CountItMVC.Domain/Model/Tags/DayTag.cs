using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Domain.Model
{
    public class DayTag
    {
        public int DayId { get; set; }
        public Day Day { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
