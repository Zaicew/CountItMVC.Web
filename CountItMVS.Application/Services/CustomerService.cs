using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _mapper;

        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm GetAllCusomersForList()
        {
            var customers = _customerRepo.GetAllCustomers().ProjectTo<CustomerForListVM>(_mapper.ConfigurationProvider).ToList();
            var customerList = new ListCustomerForListVm()
            {
                Customers = customers,
                Count = customers.Count
            };
            return customerList;
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            var customer = _customerRepo.GetCustomer(customerId);
            var customerVm = _mapper.Map<CustomerDetailsVm>(customer);

            customerVm.Addresses = new List<AddressForListVm>();
            customerVm.PhoneNumbers = new List<ContactDetailListVm>();
            customerVm.Emails = new List<ContactDetailListVm>();

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
                customerVm.Addresses.Add(add);
            }

            //foreach(var item in customer.Emails)
            //{
            //    var contactDetails = new ContactDetailListVm()
            //    {

            //    };
            //}

            return customerVm;
        }
    }
}
