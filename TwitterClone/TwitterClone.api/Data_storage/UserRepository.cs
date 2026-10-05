using TwitterClone.Domain.Entities;

namespace TwitterClone.api.Data_storage
{
    public class UserRepository
    {
        private List<User> _user { get; set; } = new List<User>();
        public User AddUser(User user)
        {   
            _user.Add(user);
           
            return user;
        }
        public User UpdateUser(User user)
        {
            _user.RemoveAll(u => u.Id == user.Id);
            _user.Add(user);
            return user;
        }

        public bool DeleteUser(User user)
        {
            return _user.Remove(user);
        }

        public User GetUserById(Guid id)
        {
            return _user.SingleOrDefault(u => u.Id == id); 
            
        }

        public List<User> GetUsers()
        {
            return _user;
        }
        public User GetUserByEmail(string email)
        {
            return _user.SingleOrDefault(u => u.Email == email);
        }
    }
}
