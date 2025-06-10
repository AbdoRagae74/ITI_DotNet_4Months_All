using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPIDay01.Models;

namespace WEBAPIDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        public ITIDbContext con;
        public TopicsController(ITIDbContext c)
        {
            con = c;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            List<Topic> allTopics = con.Topics.ToList();
            if (allTopics.Count == 0)
                return NotFound();
            return Ok(allTopics);

        }
    }
}
