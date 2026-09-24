using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassagesController : ControllerBase
    {
        [HttpPost]
       public IActionResult SendMassage([FromBody] string massage)
        {
            // Here you would typically send the massage to the recipient
            return Ok(new { Message = "Massage sent successfully!", Content = massage });
        }
        [HttpGet]
        [Authorize]
        public IActionResult GetMassages()
        {
            // Here you would typically retrieve massages from your database
            var massages = new[]
            {
                new { MassageId = Guid.NewGuid(), Content = "Hello, how are you?" },
                new { MassageId = Guid.NewGuid(), Content = "Don't forget our meeting tomorrow." },
                new { MassageId = Guid.NewGuid(), Content = "Happy Birthday!" }
            };
            return Ok(massages);
        }
        [HttpDelete]
        [Authorize  ]
        public IActionResult DeleteMassage([FromBody] Guid massageId)
        {
            // Here you would typically delete the massage from your database
            return Ok(new { Message = $"Massage with ID: {massageId} deleted successfully!" });
        }
        [HttpPut]
        [Authorize]

        public IActionResult UpdateMassage([FromBody] Guid massageId, [FromBody] string updatedContent)
        {
            // Here you would typically update the massage in your database
            return Ok(new { Message = $"Massage with ID: {massageId} updated successfully!", UpdatedContent = updatedContent });
        }
        [HttpGet("{massageId}")]
        [Authorize]
        public
            IActionResult GetMassageById([FromRoute] Guid massageId)
        {
            // Here you would typically retrieve the massage from your database
            return Ok(new { MassageId = massageId, Content = "This is a sample massage content." });
        }
        [HttpGet("user/{userId}")]
        [Authorize]
        public IActionResult GetMassagesByUserId([FromRoute] Guid userId)
        {
            // Here you would typically retrieve massages for the specified user from your database
            var massages = new[]
            {
                new { MassageId = Guid.NewGuid(), UserId = userId, Content = "Hello, how are you?" },
                new { MassageId = Guid.NewGuid(), UserId = userId, Content = "Don't forget our meeting tomorrow." },
                new { MassageId = Guid.NewGuid(), UserId = userId, Content = "Happy Birthday!" }
            };
            return Ok(massages);
        }
    }
}
