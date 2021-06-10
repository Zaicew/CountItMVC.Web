using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CountItMVC.Web.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using Item = CountItMVC.Domain.Model.Item;
using CountItMVC.Application.Interfaces;

namespace CountItMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            return View();
        }

    //public IActionResult Nowy()
    //{
    //    List<Item> Items = new List<Item>();
    //        //{

    //        //    new Item()
    //        //        new Item(1, "Name1"),
    //        //        new Item() { Id = 2, Name = "Name2" },
    //        //        new Item() { Id = 3, Name = "Name3" },
    //        //        new Item() { Id = 4, Name = "Name4" },
    //        //        new Item() { Id = 5, Name = "Name5" }
    //        //    }; Why it is not working? :D

    //        Items.Add(new Item() { Id = 1, Name = "name1" });
    //        Items.Add(new Item() { Id = 2, Name = "name2" });
    //        Items.Add(new Item() { Id = 3, Name = "name3" });
    //        Items.Add(new Item() { Id = 4, Name = "name4" });

    //        return View(Items);
    //}

    public IActionResult Privacy()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
