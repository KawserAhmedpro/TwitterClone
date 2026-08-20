namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
    {
        
        private string _firstName;
        private string _lastName;
        private string _email;


        public User(): base(Guid.NewGuid())
        {
            
        }

        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _incomingFollowRequests = new List<Guid>();


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public void Follow(Guid userId) { 
          
         if(!_followers.Contains(userId))
         {
             _followers.Add(userId);
         }
         
        }
        public void Unfollow(Guid userId) {
          if(!_followers.Contains(userId)) {
                _followers.Remove(userId);
          }
        }


        public void addNotification(Guid notificationId)
        {
            if (!_incomingFollowRequests.Contains(notificationId))
            {
                _incomingFollowRequests.Add(notificationId);
            }
            // Implementation for adding a notification
        }


    }
}