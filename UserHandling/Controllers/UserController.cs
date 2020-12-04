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
        public User Get(int courseToughness)
        {
            return _iUser.AddExperience(courseToughness, 1);
            
        }

        [HttpPost("{id}/login")]
        public User Post([FromBody]LoginViewModel loginData)
        {
            return userBLL.LoginUser(loginData.EmailAdress, loginData.Password);
        }
    }

}
