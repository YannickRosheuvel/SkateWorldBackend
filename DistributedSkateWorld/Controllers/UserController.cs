using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IUser _iUser;
        UserBLL userBLL;
        public UserController()
        {
            userBLL = new UserBLL(_iUser);
        }

        [HttpGet("{id}/xp")]
        public User Get(int id)
        {
            if(id != 0)
            {
                return userBLL.AddExperience(id, 12);
            }
            return new User();

        }

        [HttpPost("{id}/login")]
        public User LoginUser([FromBody] LoginViewModel loginData)
        {
            User user = userBLL.LoginUser(loginData.EmailAdress, loginData.Password);

            HttpContext.Session.SetInt32("UserID", user.Id);

            //HttpContext.Session.Set("XP", user.Xp);

            return user;

        }

        [HttpPost("{id}/register")]
        public User RegisterUser([FromBody] RegisterViewModel registerData)
        {
            User userToRegister = new User();
            userToRegister.Address = registerData.Address;
            userToRegister.Email = registerData.EmailAdress;

            User user = userBLL.RegisterUser(userToRegister);

            HttpContext.Session.SetInt32("UserID", user.Id);
            HttpContext.Session.SetString("Firstname", user.FirstName);
            HttpContext.Session.SetString("LastName", user.LastName);
            HttpContext.Session.SetString("Email", user.Email);
            HttpContext.Session.SetString("Adress", user.Address);
            HttpContext.Session.SetInt32("Level", user.Level);
            HttpContext.Session.SetString("Rank", user.Rank);

            return user;
        }
    }

}
