using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;

        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm GetAllCusomersForList()
        {
            ListCustomerForListVm result = new ListCustomerForListVm();
            var customers = _customerRepo.GetAllCustomers();
            foreach (var item in customers)
            {
                var custVm = new CustomerDetailsVm()
                {
                    Id = item.Id,
                    Name = item.Name,
                    NationalId = item.NationalId,
                    isActive = item.isActive

                };
                result.Customers.Add(custVm);
            }
            result.Count = result.Customers.Count;
            return result;
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            var customer = _customerRepo.GetCustomer(customerId);
            var result = new CustomerDetailsVm()
            {
                Id = customer.Id,
                Name = customer.Name,
                NationalId = customer.NationalId,
                isActive = customer.isActive
            };
            var costConInfo = customer.CustomerContactInformation;
            result.Addresses = new List<AddressForListVm>();
            result.PhoneNumbers = new List<ContactDetailListVm>();
            result.Emails = new List<ContactDetailListVm>();

            foreach(var address in customer.Addresses)
            {
                var add = new AddressForListVm()
                {
                    Id = address.Id,
                    Country = address.Country,
                    ZipCode = address.ZipCode,
                    City = address.City,
                    Street = address.Street,
                    BuildingNumber = address.BuildingNumber,
                    FlatNumber = address.FlatNumber
                };
                result.Addresses.Add(add);
            }

            foreach(var item in customer.ContactDetails)
            {
                var contactDetails = new ContactDetailListVm()
                {

                };
            }

            return result;
        }
    }
}
