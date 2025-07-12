using Microsoft.AspNetCore.Mvc;

namespace WEBAPIDay01.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
