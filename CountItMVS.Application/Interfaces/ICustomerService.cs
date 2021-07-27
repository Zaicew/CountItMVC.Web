using CountItMVC.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Interfaces
{
    public interface ICustomerService
    {
        int AddCustomer(NewCustomerVm customer);
        ListCustomerForListVm GetAllCusomersForList();
        CustomerDetailsVm GetCustomerDetails(int customerId);

    }
}
