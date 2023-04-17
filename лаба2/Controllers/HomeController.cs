using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using лаба2.Models;

namespace лаба2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string id, string name, string lastname, DateTime data, uint number, string text, bool gender)
        {
            string authData = $"ID: {id}   Name: {name}  LastName: {lastname} Birthday: {data} Number phone: {number} Adress: {text}  Gender: {gender}";
            return Content(authData);
        }
        public IActionResult details()
        {
            return View(User);
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