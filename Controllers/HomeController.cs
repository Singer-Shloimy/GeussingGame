using GeussingGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GeussingGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Index(RandomNumbers randomNum)
        {
           
            //ViewBag.DateAndTime = randomNum.Timer();
            ViewBag.AmountGuessed = randomNum.Random();
            ViewBag.CurrentNumber = randomNum.Rand();
            
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DateAndTime = RandomNumbers.Timer();

            return View();
        }

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
