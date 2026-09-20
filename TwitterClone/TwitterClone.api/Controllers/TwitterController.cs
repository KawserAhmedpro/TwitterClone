using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase 
    {   
        private readonly IConfiguration _configuration;
        public TwitterController(IConfiguration configuration)

        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
           {
               new Tweet("Hello, world!") { UserId = Guid.NewGuid(),Content = "Hello, world!"    },
               new Tweet("This is my second tweet.") { UserId = Guid.NewGuid(),Content = "This is my second tweet." },

           };
           return Ok(tweets);
        }
    }
}
