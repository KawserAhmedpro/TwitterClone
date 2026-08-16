using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class RetweetNotification : Notification
    {
        public RetweetNotification(Guid retweetedByUserId) : base("Retweet")
        {
            RetweetedByUserId = retweetedByUserId;
        }

        public Guid RetweetedByUserId { get; set; }

        public override string GetMessage()
        {
            return $"User with ID {RetweetedByUserId} retweeted your tweet.";
        }
    }
}
