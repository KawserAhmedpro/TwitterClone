using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public  class TweetNotification : Notification
    {
        public TweetNotification(Guid tweetedByUserId) : base("Tweet")
        {
            TweetedByUserId = tweetedByUserId;
        }

        public Guid TweetedByUserId { get; set; }

        public override string GetMessage()
        {
            return $"User with ID {TweetedByUserId} posted a new tweet.";
        }
    }
}
