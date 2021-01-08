using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkateWorldTests.UserMock
{
    public class UserMock : IUser
    {

        private double experienceNeeded;

        List<User> users;
        User user;

        public UserMock()
        {
            users = new List<User>();

            user = new User
            {
                Paswword = "test",
                Email = "test",
                Id = 1
            };

            users.Add(user);

            experienceNeeded = 100;
        }

        private double calculateExperienceAmount(int courseToughness)
        {
            double timesXP = courseToughness * 0.5;
            double xpToBeAdded = timesXP * 10;
            return xpToBeAdded;
        }

        public User AddExperience(int courseId, int userId, int courseToughness)
        {
            User user = GetUser(userId);

            double experienceAdded = calculateExperienceAmount(courseToughness);

            if (user.Xp + experienceAdded < experienceNeeded)
            {
                user.Xp = user.Xp + experienceAdded;

                return user;
            }
            else
            {
                double experienceLeft = 0;
                experienceLeft = user.Xp + experienceAdded - experienceNeeded;
                user.Xp = experienceLeft;
                user.Level = user.Level + 1;

                return user;
            }

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

        public User Login(string email, string password)
        {
            foreach(User user in users)
            {
                if(user.Email == email && user.Paswword == password)
                {
                    return user;
                }
            }

            return new User();
        }

        public void SaveUser()
        {
            
        }


        public User Register(User registerData)
        {
            throw new NotImplementedException();
        }
    }
}
