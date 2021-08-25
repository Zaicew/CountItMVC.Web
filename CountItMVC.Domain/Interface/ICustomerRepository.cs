using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllCustomers();
        IQueryable<Customer> GetAllActiveCustomers();
        IQueryable<Customer> GetAllDeactivatedCustomers();
        bool DeactiveCustomer(int customerId);
        bool ActiveCustomer(int customerId);
        Customer GetCustomer(int customerId);
        int AddCustomer(Customer customer);
        void updateCustomer(Customer customer);
        //CustomerDetailsVm GetCustomerDetails(int customerId);
    }
}
