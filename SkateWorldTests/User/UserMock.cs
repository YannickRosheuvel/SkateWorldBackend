using SkateWorld.Core.Interfaces;
using SkateWorld.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkateWorldTests.UserMock
{
    class UserMock : IUser
    {
        public User AddExperience(int courseToughness, int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            User user = new User()
            {
                FirstName = "",
                Xp = 50,
                Id = 1,
                Level = 1
            };

            return user;
        }

        public bool Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void SaveUser()
        {
            
        }

        User IUser.Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
