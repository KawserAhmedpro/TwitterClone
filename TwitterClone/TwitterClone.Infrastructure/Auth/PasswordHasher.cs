using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;

namespace TwitterClone.Infrastructure.Auth
{
    public class PasswordHasher : IPasswordHasher
    { 
        private PasswordHasher<UserDto> _passwordHasher = new PasswordHasher<UserDto>();

        public string Hash(UserDto user, string password)
        {
            return _passwordHasher.HashPassword(user, user.Password);
        }

        public bool VerifyPassword(UserDto user, string password, string passwordHash)
        {
            // verify password.
            var result = _passwordHasher.VerifyHashedPassword(user, passwordHash, password);
            if (result == PasswordVerificationResult.Success)
            {
                return true;
            }
            else
            {
                return false; }
        }

       
        }
    }
