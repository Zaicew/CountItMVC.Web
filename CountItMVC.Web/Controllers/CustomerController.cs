using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IDayService _dayService;
        public CustomerController(ICustomerService customerService, IDayService dayService)
        {
            _customerService = customerService;
            _dayService = dayService;

        }
        //public IActionResult Index_test()
        //{
        //    var model = _customerService.GetAllCusomersForList();
        //    return View(model);
        //}

        [Route("customer/ViewCustomer/{customerId}")]
        public IActionResult ViewCustomer(int customerId)
        {
            var customerModel = _customerService.GetCustomerDetails_test(customerId);
            return View(customerModel);
        }
        [HttpGet]
        [Route("Customer/ViewAllCustomers")]
        public IActionResult ViewAllCustomers()
        {
            var customers = _customerService.GetAllCusomersForList(2, 1, "");
            return View(customers);
        }
        [HttpPost]
        [Route("Customer/ViewAllCustomers")]
        public IActionResult ViewAllCustomers(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var customers = _customerService.GetAllCusomersForList(pageSize, pageNo.Value, searchString);
            return View(customers);
        }
        [HttpGet]
        [Route("Customer/ViewAllActiveCustomers")]
        public IActionResult ViewAllActiveCustomers()
        {
            var customers = _customerService.GetAllActiveCusomersForList(2, 1, "");
            return View(customers);
        }
        [HttpPost]
        [Route("Customer/ViewAllActiveCustomers")]
        public IActionResult ViewAllActiveCustomers(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if(searchString is null)
            {
                searchString = string.Empty;
            }
            var customers = _customerService.GetAllActiveCusomersForList(pageSize, pageNo.Value, searchString);
            return View(customers);
        }
        [HttpGet]
        [Route("Customer/ViewAllInActiveCustomers")]
        public IActionResult ViewAllInActiveCustomers()
        {
            var customers = _customerService.GetAllInActiveCusomersForList(2, 1, "");
            return View(customers);
        }
        [HttpPost]
        [Route("Customer/ViewAllInActiveCustomers")]
        public IActionResult ViewAllInActiveCustomers(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if(searchString is null)
            {
                searchString = string.Empty;
            }
            var customers = _customerService.GetAllInActiveCusomersForList(pageSize, pageNo.Value, searchString);
            return View(customers);
        }
        [HttpGet]
        [Route("Customer/AddCustomer")]
        public IActionResult AddCustomer()
        {
            return View(new NewCustomerVm());
        }
        [HttpPost]
        [Route("Customer/AddCustomer")]
        public IActionResult AddCustomer(NewCustomerVm model)
        {
            var id = _customerService.AddCustomer(model);
            _dayService.AddDaysForCustomer(id);
            return RedirectToAction("ViewAllCustomers");
        }
        [HttpGet]
        [Route("Customer/EditCustomer")]
        public IActionResult EditCustomer(int id)
        {
            var customer = _customerService.GetCusomersForEdit(id);
            return View(customer);
        }
        [HttpPost]
        [Route("Customer/EditCustomer")]
        public IActionResult EditCustomer(NewCustomerVm model)
        {
            _customerService.UpdateCustomer(model);
            return RedirectToAction("ViewAllCustomers");
        }

        [Route("Customer/DeleteCustomer")]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeactiveCustomer(id);
            return RedirectToAction("ViewAllCustomers");
        }
    }
}
