using CountItMVC.Application.Interfaces;
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
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index_test()
        {
            var model = _customerService.GetAllCusomersForList();
            return View(model);
        }

        [HttpGet("{customerId}")]
        [Route("customer/ViewCustomer/{customerId}")]
        public IActionResult ViewCustomer(int customerId)        
        {
            var customerModel = _customerService.GetCustomerDetails_test(customerId);
            return View(customerModel);
        }

        public IActionResult ViewAllCustomers()
        {
            var customers = _customerService.GetAllCusomersForList();
            return View(customers);
        }
        public IActionResult ViewAllActiveCustomers()
        {
            var customers = _customerService.GetAllActiveCusomersForList();
            return View(customers);
        }
        public IActionResult ViewAllInActiveCustomers()
        {
            var customers = _customerService.GetAllInActiveCusomersForList();
            return View(customers);
        }
    }
}


//[HttpPost]
//public IActionResult AddCustomer(CustomerModel model)
//{
//    var id = customerService.AddCustomer(model);
//    return View();
//}
//[HttpGet]
//public IActionResult AddCustomer()
//{

//    return View();
//}

////[HttpGet]
////public IActionResult AddNewAddressForClient(int customerId)
////{
////    return View();
////}
//[HttpPost]
//public IActionResult AddNewAddressForClient(AddressModel model)
//{

//    return View();
//}

//[HttpPost]
//public IActionResult AddNewPhoneNumberForClient(ContactDetail model)
//{

//    return View();
//}

//[HttpPost]
//public IActionResult AddNewEmailForClient(ContactDetail model)
//{

//    return View();
//}


//[HttpGet]
//public IActionResult GetAllCustomersForList()
//{

//    return View();
//}

//[HttpPost]
//public IActionResult GetAllCustomersForList()
//{
//    var customers = customerService.GetAllCustomers();
//    return View(customers);
//}
