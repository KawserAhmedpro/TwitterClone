using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        

        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }
        //ekhane nicher line e field ba variable declare
        //na kore kno direct get set korlo???
        //private string _LikeByUserId;
        public Guid  LikeByUserId { get; set; }

        public override string GetMessage()
        {
            return $"User with ID {LikeByUserId} liked your post.";
        }
    }
}
