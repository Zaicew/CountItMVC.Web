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

        public int ActiveCustomer(int customerId)
        {
            if (_context.Customers.Find(customerId) is null)
            {
                return -1;
            }
            _context.Customers.Find(customerId).IsActive = true;
            _context.SaveChanges();
            return customerId;
        }
        public int DeactiveCustomer(int customerId)
        {
            if (_context.Customers.Find(customerId) is null)
            {
                return -1;
            }

            _context.Customers.Find(customerId).IsActive = false;
            _context.SaveChanges();
            return customerId;
        }
        public IQueryable<Customer> GetAllActiveCustomers()
        {
            return _context.Customers.Where(p => p.IsActive == true);
        }
        public IQueryable<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }
        public IQueryable<Customer> GetAllDeactivatedCustomers()
        {
            return _context.Customers.Where(p => p.IsActive == false);
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
        public void UpdateCustomer(Customer customer)
        {
            _context.Attach(customer);
            _context.Entry(customer).Property("Name").IsModified = true;
            _context.Entry(customer).Property("NationalId").IsModified = true;
            _context.Entry(customer).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }
    }
}
