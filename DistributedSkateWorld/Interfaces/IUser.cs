
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistributedSkateWorld.Interfaces
{
    public interface IUser
    {
        void SaveUser();
        User GetUser(int id);
        User Login(string email, string password);
        User AddExperience(int courseId, int userId, int courseToughness);
        User Register(User registerData);
    }
}
