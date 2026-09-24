using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FollowsController : ControllerBase
    {
        public FollowsController()
        {
        }
        // POST: api/Follows
        [HttpPost]
        public IActionResult FollowUser([FromBody] Guid userIdToFollow)
        {
            // Here you would typically add the follow relationship to your database
            return Ok(new { Message = $"You are now following user with ID: {userIdToFollow}" });
        }
        // POST: api/Follows/unfollow
        [HttpPost("unfollow")]
        public IActionResult UnfollowUser([FromBody] Guid userIdToUnfollow)
        {
            // Here you would typically remove the follow relationship from your database
            return Ok(new { Message = $"You have unfollowed user with ID: {userIdToUnfollow}" });
        }
        // GET: api/Follows/followers/{userId}
        [HttpGet("followers/{userId}")]
        public IActionResult GetFollowers([FromRoute] Guid userId)
        {
            // Here you would typically retrieve the list of followers from your database
            var followers = new[]
            {
                new { FollowerId = Guid.NewGuid(), FollowerName = "Follower1" },
                new { FollowerId = Guid.NewGuid(), FollowerName = "Follower2" }
            };
            return Ok(followers);
        }
        // GET: api/Follows/following/{userId}
        [HttpGet("following/{userId}")]
        public IActionResult GetFollowing([FromRoute] Guid userId)
        {
            // Here you would typically retrieve the list of users that the specified user is following from your database
            var following = new[]
            {
                new { FollowingId = Guid.NewGuid(), FollowingName = "Following1" },
                new { FollowingId = Guid.NewGuid(), FollowingName = "Following2" }
            };
            return Ok(following);

        }
        // GET: api/Follows/status/{userId}?targetUserId={targetUserId}
        [HttpGet("status/{userId}")]
        public IActionResult GetFollowStatus([FromRoute] Guid userId, [FromQuery] Guid targetUserId)
        {
            // Here you would typically check the follow status from your database
            bool isFollowing = true; // This is just a placeholder value
            return Ok(new { UserId = userId, TargetUserId = targetUserId, IsFollowing = isFollowing });
        }
    }
}
