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
        public int AddCustomer(NewCustomerVm customerVm)
        {
            var customer = _mapper.Map<Customer>(customerVm);
            customer.IsActive = true;
            var id = _customerRepo.AddCustomer(customer);
            return id;
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
        public ListCustomerForListVm GetAllCusomersForList(int pageSize, int pageNo, string searchString)
        {
            var customers = _customerRepo.GetAllCustomers().Where(p => p.Name.StartsWith(searchString));
            var customersToShow = customers.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var customerListVm = new ListCustomerForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Customers = new List<CustomerForListVm>(),
                Count = customers.Count()
            };
            foreach(var item in customersToShow)
            {
                customerListVm.Customers.Add(CreateCustomerView(item));
            }
            return customerListVm;
        }        
        public ListCustomerForListVm GetAllActiveCusomersForList(int pageSize, int pageNo, string searchString)
        {
            var customers = _customerRepo.GetAllActiveCustomers().Where(p => p.Name.StartsWith(searchString));
            var customersToShow = customers.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var customerListVm = new ListCustomerForListVm()
            {
                CurrentPage = pageNo,
                PageSize = pageSize,
                SearchString = searchString,
                Customers = new List<CustomerForListVm>(),
                Count = customers.Count()
            };
            customerListVm.Customers = new List<CustomerForListVm>();
            foreach(var item in customersToShow)
            {
                var custVm = CreateCustomerView(item);
                customerListVm.Customers.Add(custVm);
            }

            return customerListVm;
        }
        public ListCustomerForListVm GetAllInActiveCusomersForList(int pageSize, int pageNo, string searchString)
        {
            var customers = _customerRepo.GetAllDeactivatedCustomers().Where(p => p.Name.StartsWith(searchString));
            var customersToShow = customers.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var customerListVm = new ListCustomerForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Customers = new List<CustomerForListVm>(),
                Count = customers.Count()
            };
            foreach(var item in customersToShow)
            {
                var custVm = CreateCustomerView(item);
                customerListVm.Customers.Add(custVm);
            }
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
                isActive = customer.IsActive
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
        private CustomerForListVm CreateCustomerView(Customer customer)
        {
            var custVm = new CustomerForListVm()
            {
                Id = customer.Id,
                Name = customer.Name,
                NationalId = customer.NationalId,
                IsActive = customer.IsActive
            };
            return custVm;
        }
        public NewCustomerVm GetCusomersForEdit(int id)
        {
            var customer = _customerRepo.GetCustomer(id);
            var customerVm = _mapper.Map<NewCustomerVm>(customer);
            return customerVm;
        }

        public void UpdateCustomer(NewCustomerVm model)
        {
            var customer = _mapper.Map<Customer>(model);
            _customerRepo.UpdateCustomer(customer);
        }
    }
}
