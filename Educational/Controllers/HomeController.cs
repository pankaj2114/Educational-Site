using Educational.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Diagnostics;

namespace Educational.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult AboutDirector()
        {
            return View();
        }
        public IActionResult AboutFaculty()
        {
            return View();
        }
        public IActionResult AboutMission()
        {
            return View();
        }
        public IActionResult AboutInstitute()
        {
            return View();
        }
        public IActionResult Alumni()
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
    }
}