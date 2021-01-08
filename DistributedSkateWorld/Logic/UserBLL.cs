
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
        CourseDAL courseDAL;
        private double experienceNeeded;

        public UserBLL(IUser iUser)
        {
            courseDAL = new CourseDAL();
            _iUser = iUser;
            experienceNeeded = 100;
        }

        public User GetUserByID(int id)
        {
            return _iUser.GetUser(id);
        }
        
        public User Login(string email, string password)
        {
            var loggedUser = _iUser.Login(email, password);

            if (loggedUser.Id != 0)
            {
                return loggedUser;
            }
            else
            {
                return loggedUser;
            }
        }

        public User RegisterUser(User userToRegister)
        {
            var loggedUser = _iUser.Register(userToRegister);

            if (loggedUser.Id != 0)
            {
                return loggedUser;
            }
            else
            {
                return loggedUser;
            }
        }

        public int GetCourseToughness(int id)
        {
            return courseDAL.GetCourseToughness(id);
        }

        private double calculateExperienceAmount(int courseToughness)
        {
            double timesXP = courseToughness * 0.5;
            double xpToBeAdded = timesXP * 10;
            return xpToBeAdded;
        }

        public User AddExperience(int courseId, int userId, int courseToughness)
        {
           User user = _iUser.GetUser(userId);

            double experienceAdded = calculateExperienceAmount(courseToughness);

            if (user.Xp + experienceAdded < experienceNeeded)
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
