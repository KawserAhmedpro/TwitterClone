using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public  class CommentNotification : Notification
    {
        public CommentNotification(int commentByUserId) : base("Comment")
        {
            CommentByUserId = commentByUserId;
            //ekhane commentByUserId jeta ditesi oita e paitesi
            //taile nicher get r set er kaj ki?????
        }
        //ekhane nicher line e field ba variable declare
        //na kore kno direct get set korlo???
        //private string _CommentByUserId;
        public int CommentByUserId { get; set; }
    }
    
}
