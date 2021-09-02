using AutoMapper;
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
            var result = _dayService.GetAllDaysForList();
            return View(result);
        }
        [HttpGet]
        public IActionResult AddDay()
        {
            return View(new NewDayVm());
        }
        [HttpPost]
        public IActionResult AddDay(NewDayVm model)
        {
            var id = _dayService.AddDay(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditDay(int id)
        {
            var day = _dayService.GetDayForEdit(id);
            return View(day);
        }
        [HttpPost]
        public IActionResult EditDay(NewDayVm model)
        {
            _dayService.UpdateDay(model);
            return RedirectToAction("Index");
        }
        [HttpGet("{dayId}")]
        [Route("Day/DeleteDay/{dayId}")]
        public IActionResult DeleteDay(int dayId)
        {
            _dayService.DeleteDay(dayId);
            return RedirectToAction("Index");
        }


    }
}
