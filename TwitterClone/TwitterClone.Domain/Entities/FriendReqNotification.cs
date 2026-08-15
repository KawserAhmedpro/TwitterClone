using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendReqNotification : Notification
    {
        public FriendReqNotification(Guid requestedByUserId) : base("FriendRequest")
        {
            RequestedByUserId = requestedByUserId;
        }
        public Guid RequestedByUserId { get; set; }

        public override string GetMessage()
        {
            return $"User with ID {RequestedByUserId} sent you a friend request.";
        }
    }
}
