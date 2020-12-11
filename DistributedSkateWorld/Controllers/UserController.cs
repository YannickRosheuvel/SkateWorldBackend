using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistributedSkateWorld.DAL;
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Logic;
using DistributedSkateWorld.Models;
using DistributedSkateWorld.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistributedSkateWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserDAL userDAL;
        UserBLL userBLL;
        public UserController()
        {
            userDAL = new UserDAL();
            userBLL = new UserBLL(userDAL);
        }

        [HttpGet("{id}/xp")]
        public User Get(int id)
        {
            if(id != 0)
            {
                int courseToughness = userBLL.GetCourseToughness(id);

                return userBLL.AddExperience(id, 12, courseToughness);
            }
            return new User();

        }

        [HttpPost("{id}/login")]
        public User LoginUser([FromBody] LoginViewModel loginData)
        {
            User user = userBLL.LoginUser(loginData.EmailAdress, loginData.Password);

            return user;

        }

        [HttpPost("{id}/register")]
        public User RegisterUser([FromBody] RegisterViewModel registerData)
        {
            User userToRegister = new User();
            userToRegister.Address = registerData.Address;
            userToRegister.Email = registerData.EmailAdress;

            User user = userBLL.RegisterUser(userToRegister);

            return user;
        }
    }

}
