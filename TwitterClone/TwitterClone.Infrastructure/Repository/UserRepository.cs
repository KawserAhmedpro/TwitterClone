using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;


namespace TwitterClone.Infrastructure.Repository
{
    public class UserRepository : IUserRepository

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

        public User? GetUserById(Guid id)
        {
            return _user.SingleOrDefault(u => u.Id == id);

        }

        public List<User> GetUsers()
        {
            return _user;
        }
        public User? GetUserByEmail(string email)
        {
            return _user.SingleOrDefault(u => u.Email == email);
        }
    }
}
