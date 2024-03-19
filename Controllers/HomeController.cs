using Lab1Welcome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1Welcome.Controllers
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
            DateTime currentDateTime = DateTime.Now;

            string timeZone = TimeZone.CurrentTimeZone.StandardName;

            ViewBag.CurrentDateTime = currentDateTime;
            ViewBag.TimeZone = timeZone;

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