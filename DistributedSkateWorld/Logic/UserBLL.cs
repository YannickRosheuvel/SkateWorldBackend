
using DistributedSkateWorld.DAL;
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace DistributedSkateWorld.Logic
{
    public class UserBLL
    {
        private IUser _iUser;
        UserDAL userDAL;
        private double experienceNeeded;

        public UserBLL(IUser iUser)
        {
            userDAL = new UserDAL();
            _iUser = iUser;
            experienceNeeded = 100;
        }

        public User LoginUser(string email, string password)
        {
            var loggedUser = userDAL.Login(email, password);

            if (loggedUser.Id != 0)
            {
                return loggedUser;
            }
            else
            {
                return loggedUser;
            }
        }

        private double calculateExperienceAmount(int courseToughness)
        {
            double timesXP = courseToughness * 0.5;
            double xpToBeAdded = timesXP * 10;
            return xpToBeAdded;
        }

        public User AddExperience(int courseToughness, int userId)
        {
            User user = _iUser.GetUser(userId);

            double experienceAdded = calculateExperienceAmount(courseToughness);

            if(user.Xp + experienceAdded < experienceNeeded)
            {
                user.Xp = user.Xp + experienceAdded;

                _iUser.SaveUser();
                return user;
            }
            else
            {
                double experienceLeft = 0;
                experienceLeft = user.Xp + experienceAdded - experienceNeeded;
                user.Xp = experienceLeft;
                user.Level = user.Level + 1;

                _iUser.SaveUser();
                return user;
            }

        }


    }
}
