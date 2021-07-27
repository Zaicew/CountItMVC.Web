using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class CustomerDetailsVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public bool isActive { get; set; }
        public List<AddressForListVm> Addresses { get; set; }
        public List<ContactDetailListVm> Emails { get; set; }
        public List<ContactDetailListVm> PhoneNumbers { get; set; }
    }
}
