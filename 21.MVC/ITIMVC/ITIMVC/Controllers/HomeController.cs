using ITIMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITIMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Home/returnonid/1
        public IActionResult returnOnId(int id)
        {
            if (id % 2 == 0) {

                return View("View1");
            
            }
            else
            {
                return Content("ID is Odd");
            }
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
    }
}
