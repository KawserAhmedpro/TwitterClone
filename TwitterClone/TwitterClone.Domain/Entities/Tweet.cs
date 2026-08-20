using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, Ilikeable 
    {
        
        private Guid _userId;
        private string _content;
       

        public Tweet(): base (Guid.NewGuid())
        {
           
        }

        public static int MaxContentLength = 280; // Twitter's character limit for a tweet

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        // Implement the Ilikeable interface method
        public bool Canbelike()
        {
            // simple default implementation; adjust logic as needed
            return true;
        }
        
    }
}