using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;


namespace CountItMVC.Domain.Model
{
    public class ApplicationUser : IdentityUser
    { 
        public bool IsActive { get; set; }
        public virtual ICollection<Day> Days { get; set; }
    }
}
