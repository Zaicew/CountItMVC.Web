using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _context;
        public CustomerRepository(Context context)
        {
            _context = context;
        }

        public bool ActiveCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            customer.isActive = true;
            return true;
        }
        public bool DeactiveCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            customer.isActive = false;
            return false;
        }
        public IQueryable<Customer> GetAllActiveCustomers()
        {
            return _context.Customers.Where(p => p.isActive == true);
        }
        public IQueryable<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }
        public IQueryable<Customer> GetAllDeactivatedCustomers()
        {
            return _context.Customers.Where(p => p.isActive == false);
        }
        public Customer GetCustomer(int customerId)
        {
            return _context.Customers.FirstOrDefault(i => i.Id == customerId);
        }
        public int AddAddressToCustomer(int customerId, ContactDetail emailAddress)
        {
            var customer = _context.Customers.Find(customerId);
            if (emailAddress.ContactDetailType.Name == "Email")
            {
                customer.ContactDetails.Add(emailAddress);
                return emailAddress.Id;
            }

            return -1;
        }
        public int AddPhoneNumberToCustomer(int customerId, ContactDetail phoneNumber)
        {
            var customer = _context.Customers.Find(customerId);
            if (phoneNumber.ContactDetailType.Name == "PhoneNumber")
            {
                customer.ContactDetails.Add(phoneNumber);
                return phoneNumber.Id;
            }

            return -1;
        }

        public int AddCustomer(Customer customer)
        {
            //if(_context.Customers.FirstOrDefault(c => c.NationalId == customer.NationalId) is null)
            //{
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return customer.Id;
            //}
            //return -1;
        }
    }
}
