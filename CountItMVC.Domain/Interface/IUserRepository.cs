using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountItMVC.Domain.Interface
{
    public interface IUserRepository
    {
        IQueryable<ApplicationUser> GetAllUsers();
        IQueryable<ApplicationUser> GetAllActiveUsers();
        IQueryable<ApplicationUser> GetAllDeactivatedUsers();
        string DeactiveUser(string userId);
        string ActiveUser(string userId);
        ApplicationUser GetUser(string usersId);
        //void UpdateUser(ApplicationUser user);
        //CustomerDetailsVm GetCustomerDetails(int customerId);
    }
}
