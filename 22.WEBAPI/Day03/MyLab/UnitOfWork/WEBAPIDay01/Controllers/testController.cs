using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testController : ControllerBase
    {
        [HttpGet]
        public string getstr()
        {
            return "Hello";
        }
    }
}
