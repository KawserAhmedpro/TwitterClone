using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationsController : ControllerBase
    {
        public NotificationsController()
        {
        }
        // GET: api/Notifications
        [HttpGet]
        public IActionResult GetNotifications()
        {
            var notifications = new[]
            {
                new { NotificationId = Guid.NewGuid(), Message = "You have a new follower!" },
                new { NotificationId = Guid.NewGuid(), Message = "Your tweet has been liked!" },
                new { NotificationId = Guid.NewGuid(), Message = "You have a new mention!" }
            };
            return Ok(notifications);

          
        }
        // GET: api/Notifications/{notificationId}
        [HttpGet("{notificationId}")]
        [Authorize]
        public IActionResult GetNotificationById([FromRoute] Guid notificationId)
        {
            // Here you would typically retrieve the notification from your database
            return Ok(new { NotificationId = notificationId, Message = "This is a sample notification message." });
        }
        // GET: api/Notifications/user/{userId}
        [HttpGet("user/{userId}")]
        [Authorize]
        public IActionResult GetNotificationsByUserId([FromRoute] Guid userId)
        {
            // Here you would typically retrieve notifications for the specified user from your database
            var notifications = new[]
            {
                new { NotificationId = Guid.NewGuid(), UserId = userId, Message = "You have a new follower!" },
                new { NotificationId = Guid.NewGuid(), UserId = userId, Message = "Your tweet has been liked!" },
                new { NotificationId = Guid.NewGuid(), UserId = userId, Message = "You have a new mention!" }
            };
            return Ok(notifications);
        }
        //  POST: api/Notifications
        [HttpDelete]
        [Authorize]
        public IActionResult DeleteNotification([FromBody] Guid notificationId)
        {
            // Here you would typically delete the notification from your database
            return Ok(new { Message = $"Notification with ID: {notificationId} deleted successfully!" });
        }
        // PUT: api/Notifications
        [HttpPut]
        [Authorize]
        public IActionResult UpdateNotification([FromBody] Guid notificationId, [FromBody] string updatedMessage)
        {
            // Here you would typically update the notification in your database
            return Ok(new { Message = $"Notification with ID: {notificationId} updated successfully!", UpdatedMessage = updatedMessage });
        }

    }
}
