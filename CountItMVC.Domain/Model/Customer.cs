using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  NationalId { get; set; }
        public bool isActive { get; set; }


        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Day> Days { get; set; }


        //(1) how to make 1vs1 relation in DB:
        public CustomerContactInformation CustomerContactInformation { get; set; }

    }
}
