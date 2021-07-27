using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Infrastructure.Repositories
{
    class CustomerRepository : ICustomerRepository
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
            return _context.Customers.Find(customerId);
        }
    }
}
