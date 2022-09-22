using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class homeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hello world!!");
        }
        [HttpPost]
        public IActionResult post(object payload) 
        {

            return Ok(payload);
                }
    }
}
