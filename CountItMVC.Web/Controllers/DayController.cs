using CountItMVC.Application.Interfaces;
using CountItMVC.Application.ViewModels;
using CountItMVC.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountItMVC.Web.Controllers
{
    public class DayController : Controller
    {
        private readonly IDayService _dayService;
        public DayController(IDayService dayService)
        {
            _dayService = dayService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAllDays()
        {
            
            var result = _dayService.GetAllDaysForList();
            return View(result);
        }

     

    }
}
