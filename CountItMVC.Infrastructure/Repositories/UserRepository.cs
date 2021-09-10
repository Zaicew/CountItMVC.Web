using CountItMVC.Domain.Interface;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace CountItMVC.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }

        public string ActiveUser(string userId)
        {
            if (_context.Users.Find(userId) is null)
            {
                return "";
            }
            _context.Users.Find(userId).IsActive = true;
            _context.SaveChanges();
            return userId;
        }
        public string DeactiveUser(string userId)
        {
            if (_context.Users.Find(userId) is null)
            {
                return "";
            }

            _context.Users.Find(userId).IsActive = false;
            _context.SaveChanges();
            return userId;
        }
        public IQueryable<ApplicationUser> GetAllActiveUsers()
        {
            return _context.Users.Where(p => p.IsActive == true);
        }
        public IQueryable<ApplicationUser> GetAllUsers()
        {
            return _context.Users;
        }
        public IQueryable<ApplicationUser> GetAllDeactivatedUsers()
        {
            return _context.Users.Where(p => p.IsActive == false);
        }
        public ApplicationUser GetUser(string userId)
        {
            return _context.Users.Find(userId);
        }
        //public void UpdateUser(ApplicationUser user)
        //{
        //    _context.Attach(user);
        //    _context.Entry(user).Property("Name").IsModified = true;
        //    _context.Entry(user).Property("NationalId").IsModified = true;
        //    _context.Entry(user).Property("IsActive").IsModified = true;
        //    _context.SaveChanges();
        //}
        //public int AddAddressToCustomer(int customerId, ContactDetail emailAddress)
        //{
        //    var customer = _context.Customers.Find(customerId);
        //    if (emailAddress.ContactDetailType.Name == "Email")
        //    {
        //        customer.ContactDetails.Add(emailAddress);
        //        return emailAddress.Id;
        //    }

        //    return -1;
        //}
        //public int AddPhoneNumberToCustomer(int customerId, ContactDetail phoneNumber)
        //{
        //    var customer = _context.Customers.Find(customerId);
        //    if (phoneNumber.ContactDetailType.Name == "PhoneNumber")
        //    {
        //        customer.ContactDetails.Add(phoneNumber);
        //        return phoneNumber.Id;
        //    }

        //    return -1;
        //}
        //public string AddCustomer(Customer customer)
        //{
        //    //if(_context.Customers.FirstOrDefault(c => c.NationalId == customer.NationalId) is null)
        //    //{
        //        _context.Customers.Add(customer);
        //        _context.SaveChanges();
        //        return customer.Id.ToString();
        //    //}
        //    //return -1;
        //}


    }
}



//using CountItMVC.Domain.Interface;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CountItMVC.Infrastructure.Repositories
//{
//    public class UserRepository : IUserRepository
//    {
//        private readonly Context _context;
//        public UserRepository(Context context)
//        {
//            _context = context;
//        }
//        public string GetCurrentUserId()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
