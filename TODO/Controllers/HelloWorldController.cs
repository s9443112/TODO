using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TODO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // GET: api/HelloWorld
        [HttpGet(Name = "PrintHelloWorld")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }
        [HttpPost(Name = "FuckHelloWorld")]
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello", "Dog" };
        }

       
        
    }
}
