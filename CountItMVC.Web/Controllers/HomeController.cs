using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CountItMVC.Web.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using Item = CountItMVC.Domain.Model.Item;

namespace CountItMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Nowy()
        //{
        //    List<Item> Items = new List<Item>();
        //    {
        //        new Item()
        //        new Item(1, "Name1"),
        //        new Item() { Id = 2, Name = "Name2" },
        //        new Item() { Id = 3, Name = "Name3" },
        //        new Item() { Id = 4, Name = "Name4" },
        //        new Item() { Id = 5, Name = "Name5" }
        //    };

        //    return View(Items);
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
