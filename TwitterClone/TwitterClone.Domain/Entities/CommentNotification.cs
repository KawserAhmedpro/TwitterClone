//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TwitterClone.Domain.Entities
//{
//    public  class CommentNotification : Notification
//    {
//        public CommentNotification(Guid  commentByUserId) : base("Comment")
//        {
//            CommentByUserId = commentByUserId;
//            //ekhane commentByUserId jeta ditesi oita e paitesi
//            //taile nicher get r set er kaj ki?????
//        }
//        //ekhane nicher line e field ba variable declare
//        //na kore kno direct get set korlo???
//        //private string _CommentByUserId;
//        public Guid  CommentByUserId { get; set; }
//        public override string GetMessage()
//        {
//            return $"User with ID {CommentByUserId} commented on your post.";
//        }
//    }

//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        public CommentNotification(Guid commentByUserId) : base("Comment")
        {
            CommentByUserId = commentByUserId;
        }

        public Guid CommentByUserId { get; set; }

        public void AddMessage(string message)
        {
           string Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, CommentByUserId: {CommentByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {CommentByUserId} commented on your post.";
        }
    }
}
