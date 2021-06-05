using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers
{
    [ApiController]
    public class TestController: Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {

           return Ok(new {name="Nick"});
            
        }
    }
}