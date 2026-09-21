using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }
        // GET: api/Users
        [HttpGet]
        [Authorize]
        public IActionResult GetUsers() => Ok(new[]
    {
            new { UserId = Guid.NewGuid(), UserName = "Ratul" },
            new { UserId = Guid.NewGuid(), UserName = "Shuvo" },
            new { UserId = Guid.NewGuid(), UserName = "CPS Academy" }
        });
        // POST: api/Users
        [HttpPost]
        [AllowAnonymous] 
        public IActionResult CreateUser()
        {
            return Ok(new { UserId = Guid.NewGuid(), UserName = "NewUser" });
        }

        // GET: api/Users/{id} 
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            return Ok(new { UserId = id, UserName = "User" + id.ToString() });

        }
        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id)
        {
            return Ok(new { UserId = id, UserName = "UpdatedUser" + id.ToString() });
        }
        // PATCH: api/Users/{id}/phoneNumber
        [HttpPatch("{id}/phoneNumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string newPhoneNumber)
        {
            return Ok(new { UserId = id, UserName = "UpdatedUser" + id.ToString(), NewPhoneNumber = newPhoneNumber });
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return Ok(new { UserId = id, UserName = "DeletedUser" + id.ToString() });
        }
    }
} 
