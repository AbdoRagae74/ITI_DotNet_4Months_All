using Microsoft.AspNetCore.Mvc;

namespace ITIMVC.Controllers
{
    public class Session : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult welcome()
        {
            if(User.Identity.IsAuthenticated)
            return Content($"Welcome{User.Identity.Name}");
            return Content($"Welcome Guest");

        }
        //SetSessionVariables?name=ali&age=30
        public IActionResult SetSessionVariables(string name , int age)
        {
            HttpContext.Session.SetString("Name", name);
            HttpContext.Session.SetInt32("Age", age);
            return Content($"U entered Name = {name} , Age = {age}");
        }


        public IActionResult GetSessionVars()
        {
            string name = HttpContext.Session.GetString("Name");
            int? age = HttpContext.Session.GetInt32("Age");
            return Content($"Saved values are {name} , {age}");
        }

    }
}
