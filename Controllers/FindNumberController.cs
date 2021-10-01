using GeussingGame.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeussingGame.Controllers
{
    public class FindNumberController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.GuessedNumber = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(RandomNumbers randomNum)
        {
            ViewBag.GuessedNumber = randomNum.Random();
            return View("Index");
        }
    }
}
