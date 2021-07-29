using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface IContactDetailRepository
    {
        public List<ContactDetail> GetAllEmailAddressesFromCustomer(int customerId);
        public List<ContactDetail> GetAllPhoneNumbersFromCustomer(int customerId);

    }
}
