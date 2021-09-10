using CountItMVC.Application.ViewModels;
using CountItMVC.Application.ViewModels.UserViews;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface IUserService
    {
        ListUserForListVm GetAllUsersForList(int pageSize, int pageNo, string searchString);
        ListUserForListVm GetAllActiveUsersForList(int pageSize, int pageNo, string searchString);
        ListUserForListVm GetAllInActiveUsersForList(int pageSize, int pageNo, string searchString);
        //UserDetailsVm GetUserDetails_test(int UserId);
        //NewUserVm GetUsersForEdit(int userId);
        //void UpdateUser(NewUserVm model);
        void DeactiveUser(string UserId);
    }
}
