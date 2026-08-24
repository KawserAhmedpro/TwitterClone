using System;
using TwitterClone.Domain.Entities;








var likeNotification = new LikeNotification(Guid.NewGuid());     
var commentNotification = new CommentNotification(Guid.NewGuid());
var friendReqNotification = new FriendReqNotification(Guid.NewGuid());
var mentionNotification = new MentionNotification(Guid.NewGuid());
var systemNotification = new SystemNotification(Guid.NewGuid());
var retweetNotification = new RetweetNotification(Guid.NewGuid());
var tweetNotification = new TweetNotification(Guid.NewGuid());



Console.WriteLine($"Notification Type: {likeNotification.GetMessage()}");
Console.WriteLine($"Notification Type: {commentNotification.GetMessage()}");
Console.WriteLine($"Notification Type: {friendReqNotification.GetMessage()}");
Console.WriteLine($"Notification Type: {mentionNotification.GetMessage()}");
Console.WriteLine($"Notification Type: {systemNotification.GetMessage()}");
Console.WriteLine($"Notification Type: {retweetNotification.GetMessage()}");
Console.WriteLine($"Notification Type: {tweetNotification.GetMessage()}");
Console.WriteLine($"//upcasting to base class...........................................");
//upcasting to base class

var notifications = new List<Notification>
{
    new LikeNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new FriendReqNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new SystemNotification(Guid.NewGuid()),
    new RetweetNotification(Guid.NewGuid()),
    new TweetNotification(Guid.NewGuid())
};




foreach (var notification in notifications)
{
    Console.WriteLine($" {notification.GetMessage()}");
}

Ilikeable ilikeable = new Tweet(); // Upcasting to Ilikeable interface

ilikeable.Canbelike();
Console.WriteLine($"Max Tweet Length: {Tweet.MaxContentLength}") ;