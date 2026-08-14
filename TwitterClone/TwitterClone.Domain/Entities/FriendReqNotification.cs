using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendReqNotification : Notification
    {
        public FriendReqNotification(int requestedByUserId) : base("FriendRequest")
        {
            RequestedByUserId = requestedByUserId;
        }
        public int RequestedByUserId { get; set; }
    }
}
