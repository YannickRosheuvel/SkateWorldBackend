
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedSkateWorld.DAL
{
    public class UserDAL : SkateWorldContext, IUser
    {
        public User AddExperience(int courseId, int userId, int courseToughness)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return User.Where(user => user.Id == id).FirstOrDefault();
        }

        public User Login(string email, string password)
        {
            foreach (var user in User)
            {
                if (user.Email == email && BCrypt.Net.BCrypt.Verify(password, user.Paswword))
                {
                    return user;
                }
            }
            return new User();
        }

        public User Register(User registerData)
        {

            User.Add(registerData);
            SaveChanges();

            return registerData;


        }

        public void SaveUser()
        {

            SaveChanges();

        }

    }
}
