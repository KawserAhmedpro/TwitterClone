using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CommentsController : ControllerBase
    {
        public CommentsController()
        {
        }
        // GET: api/Comments
        [HttpGet]
        public IActionResult GetComments()
        {
            var comments = new[]
            {
                new { CommentId = Guid.NewGuid(), Content = "This is a great post!" },
                new { CommentId = Guid.NewGuid(), Content = "I totally agree with you." },
                new { CommentId = Guid.NewGuid(), Content = "Thanks for sharing this information." }
            };
            return Ok(comments);
        }
        // POST: api/Comments
        [HttpPost]
        public IActionResult PostComment([FromBody] string comment)
        {
            // Here you would typically save the comment to your database
            return Ok(new { Message = "Comment posted successfully!", Content = comment });
        }
        // DELETE: api/Comments
        [HttpDelete]
        public IActionResult DeleteComment([FromBody] Guid commentId)
        {
            // Here you would typically delete the comment from your database
            return Ok(new { Message = $"Comment with ID: {commentId} deleted successfully!" });
        }
        // PUT: api/Comments
        [HttpPut]
        public IActionResult UpdateComment([FromBody] Guid commentId, [FromBody] string updatedContent)
        {
            // Here you would typically update the comment in your database
            return Ok(new { Message = $"Comment with ID: {commentId} updated successfully!", UpdatedContent = updatedContent });
        }
        // GET: api/Comments/{commentId}
        [HttpGet("{commentId}")]
           public IActionResult GetCommentById([FromRoute] Guid commentId)
        {
            // Here you would typically retrieve the comment from your database
            return Ok(new { CommentId = commentId, Content = "This is a sample comment content." });
        }
    }
}
