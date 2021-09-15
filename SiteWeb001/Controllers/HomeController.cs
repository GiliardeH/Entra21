using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteWeb001.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SiteWeb001.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Calcula()
        {
            ViewBag.Nome = "Jorge";
            ViewBag.Idade = 35;
            ViewBag.Cpf = "123123123445";
            return View();
        }
        public IActionResult Exec01()
        {
            return View();
        }
        public IActionResult Exec02()
        {
            return View();
        }
        public IActionResult Exec03()
        {
            return View();
        }
        public IActionResult Exec04()
        {
            return View();
        }
        public IActionResult Exec05()
        {
            return View();
        }



    }
}
