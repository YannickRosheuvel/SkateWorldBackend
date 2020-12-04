
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
        UserDAL userDAL;
        private double experienceNeeded;

        public UserBLL(IUser iUser)
        {
            courseDAL = new CourseDAL();
            userDAL = new UserDAL();
            _iUser = iUser;
            experienceNeeded = 100;
        }

        public User GetUserByID(int id)
        {
            return userDAL.GetUser(id);
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

        public User RegisterUser(User userToRegister)
        {
            var loggedUser = userDAL.Register(userToRegister);

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

        public User AddExperience(int courseId, int userId)
        {
           User user = userDAL.GetUser(userId);

            int courseToughness = courseDAL.GetCourseToughness(courseId);

            double experienceAdded = calculateExperienceAmount(courseToughness);

            if (user.Xp + experienceAdded < experienceNeeded)
            {
                user.Xp = user.Xp + experienceAdded;

                userDAL.SaveUser();
                return user;
            }
            else
            {
                double experienceLeft = 0;
                experienceLeft = user.Xp + experienceAdded - experienceNeeded;
                user.Xp = experienceLeft;
                user.Level = user.Level + 1;

                userDAL.SaveUser();
                return user;
            }

        }


    }
}
