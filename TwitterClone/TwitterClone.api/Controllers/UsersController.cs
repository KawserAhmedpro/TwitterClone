using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
<<<<<<< Updated upstream
=======
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
>>>>>>> Stashed changes

namespace TwitterClone.Api.Controllers
{

    // api/users
    [Route("api/[controller]")]
    [ApiController]
<<<<<<< Updated upstream
    [Authorize]
    public class UsersController : ControllerBase
    {

        public UsersController() { }
=======
    // [Authorize]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;

        public UsersController(
            IUserService userService)
        {
            _userService = userService;
        }
>>>>>>> Stashed changes


        // GET /api/users
        [HttpGet]
<<<<<<< Updated upstream
        public IActionResult GetUsers()
        {
            return Ok(new List<object>
            {
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "user1",
                },
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "user2",
                },
            });
=======
        [AllowAnonymous]
        [ProducesResponseType(typeof(List<UserDto>), StatusCodes.Status200OK)]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
>>>>>>> Stashed changes
        }

        // POST /api/users
        [HttpPost]
        [AllowAnonymous]
<<<<<<< Updated upstream
        public IActionResult CreateUser()
        {
            return Ok(new
            {
                UserId = Guid.NewGuid(),
                UserName = "newuser",
            });
=======
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var createdUser = _userService.CreateUser(createUserDto);

            if (createdUser is null)
            {
                // Input is already validated by [ApiController], so the only failure left is a taken email.
                return Conflict($"A user with email '{createUserDto.Email}' already exists.");
            }

            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
>>>>>>> Stashed changes
        }


        // GET /api/users/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
<<<<<<< Updated upstream
            return Ok(new
            {
                UserId = id,
                UserName = "user" + id.ToString(),
            });
=======
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
>>>>>>> Stashed changes
        }


        // PUT /api/users/{id}
        [HttpPut("{id}")]
<<<<<<< Updated upstream
        public IActionResult UpdateUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "updateduser" + id.ToString(),
            });
=======
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = _userService.UpdateUser(id, updateUserDto);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
>>>>>>> Stashed changes
        }


        // PATCH /api/users/{id}/phoneNumber
        [HttpPatch("{id}/phoneNumber")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody, Required, Phone] string phoneNumber)
        {
            var user = _userService.UpdateUserPhoneNumber(id, phoneNumber);

<<<<<<< Updated upstream
        }

        // DELETE /api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Message = "User deleted successfully.",
            });
=======
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // DELETE /api/users/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var isDeleted = _userService.DeleteUser(id);

            if (isDeleted == false)
            {
                return NotFound();
            }

            return NoContent();
>>>>>>> Stashed changes
        }
    }
}