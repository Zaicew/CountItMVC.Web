using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Infrastructure.Repositories
{
    public class ContactDetailRepository : IContactDetailRepository
    {
        private readonly Context _context;
        public ContactDetailRepository(Context context)
        {
            _context = context;

        }

        public List<ContactDetail> GetAllEmailAddressesFromCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            var result = new List<ContactDetail>();
            foreach (var item in customer.ContactDetails)
            {
                if (item.ContactDetailType.Name == "Email")
                {
                    var emailAdd = new ContactDetail()
                    {
                        Id = item.Id,
                        ContactDetailType = item.ContactDetailType,
                        ContactDetailInformation = item.ContactDetailInformation
                    };
                    result.Add(emailAdd);
                }
            }
            return result;
        }
        public List<ContactDetail> GetAllPhoneNumbersFromCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            var result = new List<ContactDetail>();
            foreach (var item in customer.ContactDetails)
            {
                if (item.ContactDetailType.Name == "PhoneNumber")
                {
                    var phoneNum = new ContactDetail()
                    {
                        Id = item.Id,
                        ContactDetailType = item.ContactDetailType,
                        ContactDetailInformation = item.ContactDetailInformation
                    };
                    result.Add(phoneNum);
                }
            }
            return result;
        }
    }
}
