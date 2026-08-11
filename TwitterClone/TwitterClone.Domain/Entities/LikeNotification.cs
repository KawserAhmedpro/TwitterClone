using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        

        public LikeNotification(int likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }
        //ekhane nicher line e field ba variable declare
        //na kore kno direct get set korlo???
        //private string _LikeByUserId;
        public int LikeByUserId { get; set; }
    }
}
