using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public  class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;
           
        }

        public Guid MentionedByUserId { get; set; }

        public override string GetMessage()
        {
            return $"User with ID {MentionedByUserId} mentioned you in a tweet.";
        }


    }
}
