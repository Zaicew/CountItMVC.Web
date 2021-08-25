using CountItMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface ICustomerService
    {
        int AddCustomer(NewCustomerVm customer);
        ListCustomerForListVm GetAllCusomersForList(int pageSize, int pageNo, string searchString);
        ListCustomerForListVm GetAllActiveCusomersForList(int pageSize, int pageNo, string searchString);
        ListCustomerForListVm GetAllInActiveCusomersForList(int pageSize, int pageNo, string searchString);
        CustomerDetailsVm GetCustomerDetails_test(int customerId);
        int AddPhoneNumberToCustomer(int customerId, ContactDetailListVm contactInformation);
        int AddEmailToCustomer(int customerId, ContactDetailListVm contactInformation);
        NewCustomerVm GetCusomersForEdit(int id);
        void UpdateCustomer(NewCustomerVm model);
    }
}
