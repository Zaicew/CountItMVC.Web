using AutoMapper;
using AutoMapper.QueryableExtensions;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels.UserViews;
using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        //public string AddCustomer(NewCustomerVm customerVm)
        //{
        //    var customer = _mapper.Map<Customer>(customerVm);
        //    customer.IsActive = true;
        //    var id = _customerRepo.AddCustomer(customer);
        //    return id;
        //}
        //public int AddEmailToCustomer(int customerId, ContactDetailListVm contactInformation)
        //{
        //    throw new NotImplementedException();
        //}
        //public int AddPhoneNumberToCustomer(int customerId, ContactDetailListVm contactInformation)
        //{
        //    throw new NotImplementedException();
        //}
        public ListUserForListVm GetAllUsersForList()
        {
            var users = _userRepo.GetAllUsers().ProjectTo<UserForListVm>(_mapper.ConfigurationProvider).ToList();
            var userList = new ListUserForListVm()
            {
                Users = users,
                Count = users.Count
            };
            return userList;
        }
        public ListUserForListVm GetAllUsersForList(int pageSize, int pageNo, string searchString)
        {
            var users = _userRepo.GetAllUsers().Where(p => p.Email.Contains(searchString));
            var usersToShow = users.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var result = new ListUserForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Users = new List<UserForListVm>(),
                Count = users.Count()
            };
            foreach(var item in usersToShow)
            {
                result.Users.Add(CreateUserView(item));
            }
            return result;
        }        
        public ListUserForListVm GetAllActiveUsersForList(int pageSize, int pageNo, string searchString)
        {
            var users = _userRepo.GetAllActiveUsers().Where(p => p.UserName.Contains(searchString));
            var usersToShow = users.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var result = new ListUserForListVm()
            {
                CurrentPage = pageNo,
                PageSize = pageSize,
                SearchString = searchString,
                Users = new List<UserForListVm>(),
                Count = users.Count()
            };
            result.Users = new List<UserForListVm>();
            foreach(var item in usersToShow)
            {
                var custVm = CreateUserView(item);
                result.Users.Add(custVm);
            }

            return result;
        }
        public ListUserForListVm GetAllInActiveUsersForList(int pageSize, int pageNo, string searchString)
        {
            var Users = _userRepo.GetAllDeactivatedUsers().Where(p => p.UserName.Contains(searchString));
            var UsersToShow = Users.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var result = new ListUserForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Users = new List<UserForListVm>(),
                Count = Users.Count()
            };
            foreach(var item in UsersToShow)
            {
                var custVm = CreateUserView(item);
                result.Users.Add(custVm);
            }
            return result;
        }      
        private UserForListVm CreateUserView(ApplicationUser user)
        {
            var userVm = new UserForListVm()
            {
                Id = user.Id,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumber = user.PhoneNumber,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                UserName = user.UserName
            };
            return userVm;
        }       
        public void DeactiveUser(string userId)
        {
            _userRepo.DeactiveUser(userId);
        }


        //public CustomerDetailsVm GetCustomerDetails_test(int customerId)
        //{
        //    var customer = _customerRepo.GetCustomer(customerId);
        //    var customerVmNoMapper = new CustomerDetailsVm()
        //    {
        //        Id = customer.Id,
        //        Name = customer.Name,
        //        NationalId = customer.NationalId,
        //        isActive = customer.IsActive
        //    };

        //    customerVmNoMapper.Addresses = new List<AddressForListVm>();
        //    customerVmNoMapper.PhoneNumbers = new List<PhoneNumbersForListVm>();
        //    customerVmNoMapper.Emails = new List<EmailsForListVm>();

        //    //foreach (var address in customer.Addresses)
        //    //{
        //    //    var add = new AddressForListVm()
        //    //    {
        //    //        Id = address.Id,
        //    //        Country = address.Country,
        //    //        ZipCode = address.ZipCode,
        //    //        City = address.City,
        //    //        Street = address.Street,
        //    //        BuildingNumber = address.BuildingNumber,
        //    //        FlatNumber = address.FlatNumber
        //    //    };
        //    //    customerVmNoMapper.Addresses.Add(add);
        //    //}
        //    //foreach (var item in customer.ContactDetails)
        //    //{
        //    //    if (item.ContactDetailType.Name == "Email")
        //    //    {
        //    //        var email = new EmailsForListVm()
        //    //        {
        //    //            Id = item.Id,
        //    //            Email = item.ContactDetailInformation
        //    //        };
        //    //        customerVmNoMapper.Emails.Add(email);
        //    //    }
        //    //    if (item.ContactDetailType.Name == "PhoneNumber")
        //    //    {
        //    //        var phoneNum = new PhoneNumbersForListVm()
        //    //        {
        //    //            Id = item.Id,
        //    //            PhoneNumber = item.ContactDetailInformation
        //    //        };
        //    //        customerVmNoMapper.PhoneNumbers.Add(phoneNum);
        //    //    }
        //    //}
        //    return customerVmNoMapper;
        //}
        //public UserForListVm GetCustomerDetails_mapper(int customerId)
        //{
        //    var customer = _userRepo.GetCustomer(customerId);
        //    //var config = new MapperConfiguration(cfg => { cfg.CreateMap<Customer, CustomerDetailsVmMapper>();
        //    //    cfg.CreateMap < Address, AddressForListVm>();
        //    //});
        //    //foreach (var address in customer.Addresses)
        //    //{

        //    //}
        //    var customerVm = _mapper.Map<CustomerDetailsVm>(customer);


        //    customerVm.Addresses = new List<AddressForListVm>();
        //    customerVm.PhoneNumbers = new List<PhoneNumbersForListVm>();
        //    customerVm.Emails = new List<EmailsForListVm>();

        //    foreach (var address in customer.Addresses)
        //    {
        //        var add = new AddressForListVm()
        //        {
        //            Id = address.Id,
        //            Country = address.Country,
        //            ZipCode = address.ZipCode,
        //            City = address.City,
        //            Street = address.Street,
        //            BuildingNumber = address.BuildingNumber,
        //            FlatNumber = address.FlatNumber
        //        };
        //        customerVm.Addresses.Add(add);
        //    }
        //    foreach (var item in customer.ContactDetails)
        //    {
        //        if (item.ContactDetailType.Name == "Email")
        //        {
        //            var email = new EmailsForListVm()
        //            {
        //                Id = item.Id,
        //                Email = item.ContactDetailInformation
        //            };
        //            customerVm.Emails.Add(email);
        //        }
        //        if (item.ContactDetailType.Name == "PhoneNumber")
        //        {
        //            var phoneNum = new PhoneNumbersForListVm()
        //            {
        //                Id = item.Id,
        //                PhoneNumber = item.ContactDetailInformation
        //            };
        //            customerVm.PhoneNumbers.Add(phoneNum);
        //        }
        //    }
        //    return customerVm;
        //}
    }
}
