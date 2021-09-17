using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class DayController : Controller
    {
        private readonly IDayService _dayService;
        private readonly IMealService _mealService;
        private readonly UserManager<ApplicationUser> _userManager;
        public DayController(IDayService dayService, IMealService mealService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _dayService = dayService;
            _mealService = mealService;
        }
        [Route("Day/Index")]
        public IActionResult Index()
        {
            var result = _dayService.GetAllDaysForList();
            return View(result);
        }
        [HttpGet]
        [Route("Day/AddDay")]
        public IActionResult AddDay()
        {
            return View(new NewDayVm());
        }
        [HttpPost]
        [Route("Day/AddDay")]
        public IActionResult AddDay(NewDayVm model)
        {
            model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var id = _dayService.AddDay(model);
            //string id2 = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //_mealService.AddMealsToDay(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("Day/EditDay")]
        public IActionResult EditDay(int id)
        {
            var day = _dayService.GetDayForEdit(id);
            return View(day);
        }
        [HttpPost]
        [Route("Day/EditDay")]
        public IActionResult EditDay(NewDayVm model)
        {
            _dayService.UpdateDay(model);
            return RedirectToAction("Index");
        }

        [Route("Day/DeleteDay/{dayId}")]
        public IActionResult DeleteDay(int dayId)
        {
            _dayService.DeleteDay(dayId);
            return RedirectToAction("Index");
        }

        [Route("Day/DayDetail/{dayId}")]
        public IActionResult DayDetail(int dayId)
        {
            var day = _dayService.GetDayById(dayId);
            return View(day);
        }


        //public async Task<IActionResult> GetUserId()
        //{
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
        //}

    }
}
