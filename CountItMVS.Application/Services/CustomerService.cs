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
        private readonly IContactDetailRepository _contactDetailRepo;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepo, IContactDetailRepository contactDetailRepo, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _contactDetailRepo = contactDetailRepo;
            _mapper = mapper;
        }

        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public int AddEmailToCustomer(int customerId, ContactDetailListVm contactInformation)
        {
            throw new NotImplementedException();
        }

        public int AddPhoneNumberToCustomer(int customerId, ContactDetailListVm contactInformation)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm GetAllCusomersForList_mapper()
        {
            var customers = _customerRepo.GetAllCustomers().ProjectTo<CustomerForListVm>(_mapper.ConfigurationProvider).ToList();
            var customerList = new ListCustomerForListVm()
            {
                Customers = customers,
                Count = customers.Count
            };
            return customerList;
        }
        public ListCustomerForListVm GetAllCusomersForList()
        {
            var customers = _customerRepo.GetAllCustomers();
            var customerListVm = new ListCustomerForListVm();
            customerListVm.Customers = new List<CustomerForListVm>();
            foreach(var item in customers)
            {
                var customerVm = new CustomerForListVm()
                {
                    Id = item.Id,
                    Name = item.Name,
                    NationalId = item.NationalId,
                    IsActive = item.isActive
                };
                customerListVm.Customers.Add(customerVm);
            }
            customerListVm.Count = customerListVm.Customers.Count();

            return customerListVm;
        }
        public ListCustomerForListVm GetAllActiveCusomersForList()
        {
            var customers = _customerRepo.GetAllActiveCustomers();
            var customerListVm = new ListCustomerForListVm();
            customerListVm.Customers = new List<CustomerForListVm>();
            foreach(var item in customers)
            {
                var customerVm = new CustomerForListVm()
                {
                    Id = item.Id,
                    Name = item.Name,
                    NationalId = item.NationalId,
                    IsActive = item.isActive
                };
                customerListVm.Customers.Add(customerVm);
            }
            customerListVm.Count = customerListVm.Customers.Count();

            return customerListVm;
        }
        public ListCustomerForListVm GetAllInActiveCusomersForList()
        {
            var customers = _customerRepo.GetAllDeactivatedCustomers();
            var customerListVm = new ListCustomerForListVm();
            customerListVm.Customers = new List<CustomerForListVm>();
            foreach(var item in customers)
            {
                var customerVm = new CustomerForListVm()
                {
                    Id = item.Id,
                    Name = item.Name,
                    NationalId = item.NationalId,
                    IsActive = item.isActive
                };
                customerListVm.Customers.Add(customerVm);
            }
            customerListVm.Count = customerListVm.Customers.Count();

            return customerListVm;
        }

        public CustomerDetailsVm GetCustomerDetails_test(int customerId)
        {
            var customer = _customerRepo.GetCustomer(customerId);
            var customerVmNoMapper = new CustomerDetailsVm()
            {
                Id = customer.Id,
                Name = customer.Name,
                NationalId = customer.NationalId,
                isActive = customer.isActive
            };

            customerVmNoMapper.Addresses = new List<AddressForListVm>();
            customerVmNoMapper.PhoneNumbers = new List<PhoneNumbersForListVm>();
            customerVmNoMapper.Emails = new List<EmailsForListVm>();

            //foreach (var address in customer.Addresses)
            //{
            //    var add = new AddressForListVm()
            //    {
            //        Id = address.Id,
            //        Country = address.Country,
            //        ZipCode = address.ZipCode,
            //        City = address.City,
            //        Street = address.Street,
            //        BuildingNumber = address.BuildingNumber,
            //        FlatNumber = address.FlatNumber
            //    };
            //    customerVmNoMapper.Addresses.Add(add);
            //}
            //foreach (var item in customer.ContactDetails)
            //{
            //    if (item.ContactDetailType.Name == "Email")
            //    {
            //        var email = new EmailsForListVm()
            //        {
            //            Id = item.Id,
            //            Email = item.ContactDetailInformation
            //        };
            //        customerVmNoMapper.Emails.Add(email);
            //    }
            //    if (item.ContactDetailType.Name == "PhoneNumber")
            //    {
            //        var phoneNum = new PhoneNumbersForListVm()
            //        {
            //            Id = item.Id,
            //            PhoneNumber = item.ContactDetailInformation
            //        };
            //        customerVmNoMapper.PhoneNumbers.Add(phoneNum);
            //    }
            //}
            return customerVmNoMapper;
        }
        public CustomerDetailsVm GetCustomerDetails_mapper(int customerId)
        {
            var customer = _customerRepo.GetCustomer(customerId);
            //var config = new MapperConfiguration(cfg => { cfg.CreateMap<Customer, CustomerDetailsVmMapper>();
            //    cfg.CreateMap < Address, AddressForListVm>();
            //});
            //foreach (var address in customer.Addresses)
            //{

            //}
            var customerVm = _mapper.Map<CustomerDetailsVm>(customer);
            

            customerVm.Addresses = new List<AddressForListVm>();
            customerVm.PhoneNumbers = new List<PhoneNumbersForListVm>();
            customerVm.Emails = new List<EmailsForListVm>();

            foreach (var address in customer.Addresses)
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
            foreach (var item in customer.ContactDetails)
            {
                if (item.ContactDetailType.Name == "Email")
                {
                    var email = new EmailsForListVm()
                    {
                        Id = item.Id,
                        Email = item.ContactDetailInformation
                    };
                    customerVm.Emails.Add(email);
                }
                if (item.ContactDetailType.Name == "PhoneNumber")
                {
                    var phoneNum = new PhoneNumbersForListVm()
                    {
                        Id = item.Id,
                        PhoneNumber = item.ContactDetailInformation
                    };
                    customerVm.PhoneNumbers.Add(phoneNum);
                }
            }
            return customerVm;
        }


    }
}
