using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IDayService _dayService;
        public UserController(IUserService userService, IDayService dayService)
        {
            _userService = userService;
            _dayService = dayService;

        }
        public IActionResult Index()
        {
            return RedirectToAction("ViewAllUsers");
        }
        //public IActionResult Index_test()
        //{
        //    var model = _customerService.GetAllCusomersForList();
        //    return View(model);
        //}

        //[Route("customer/ViewUser/{userId}")]
        //public IActionResult ViewCustomer(int customerId)
        //{
        //    var customerModel = _userService.GetUserDetails_test(customerId);
        //    return View(customerModel);
        //}
        [HttpGet]
        [Route("User/ViewAllUsers")]
        public IActionResult ViewAllUsers()
        {
            var users = _userService.GetAllUsersForList(2, 1, "");
            return View(users);
        }
        [HttpPost]
        [Route("User/ViewAllUsers")]
        public IActionResult ViewAllUsers(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var users = _userService.GetAllUsersForList(pageSize, pageNo.Value, searchString);
            return View(users);
        }
        [HttpGet]
        [Route("User/ViewAllActiveUsers")]
        public IActionResult ViewAllActiveUsers()
        {
            var users = _userService.GetAllActiveUsersForList(2, 1, "");
            return View(users);
        }
        [HttpPost]
        [Route("User/ViewAllActiveUsers")]
        public IActionResult ViewAllActiveUsers(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if(searchString is null)
            {
                searchString = string.Empty;
            }
            var users = _userService.GetAllActiveUsersForList(pageSize, pageNo.Value, searchString);
            return View(users);
        }
        [HttpGet]
        [Route("User/ViewAllInActiveUsers")]
        public IActionResult ViewAllInActiveUsers()
        {
            var users = _userService.GetAllInActiveUsersForList(2, 1, "");
            return View(users);
        }
        [HttpPost]
        [Route("User/ViewAllInActiveUsers")]
        public IActionResult ViewAllInActiveUsers(int pageSize, int? pageNo, string searchString)
        {
            if(!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if(searchString is null)
            {
                searchString = string.Empty;
            }
            var customers = _userService.GetAllInActiveUsersForList(pageSize, pageNo.Value, searchString);
            return View(customers);
        }

        //[HttpGet]
        //[Route("User/EditCustomer")]
        //public IActionResult EditCustomer(string id)
        //{
        //    var customer = _userService.GetUsersForEdit(id);
        //    return View(customer);
        //}
        //[HttpPost]
        //[Route("User/EditCustomer")]
        //public IActionResult EditCustomer(NewUserVm model)
        //{
        //    _userService.UpdateUser(model);
        //    return RedirectToAction("ViewAllUsers");
        //}

        [Route("User/Deactive")]
        public IActionResult Deactive(string id)
        {
            _userService.DeactiveUser(id);
            return RedirectToAction("ViewAllCustomers");
        }



        //[HttpGet]
        //[Route("User/AddUser")]
        //public IActionResult AddCustomer()
        //{
        //    return View(new NewCustomerVm());
        //}
        //[HttpPost]
        //[Route("User/AddUser")]
        //public IActionResult AddCustomer(NewCustomerVm model)
        //{
        //    var id = _customerService.AddCustomer(model);
        //    //_dayService.AddDaysForCustomer(id);
        //    return RedirectToAction("ViewAllCustomers");
        //}
    }
}
