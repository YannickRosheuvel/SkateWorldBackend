using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Logic;
using DistributedSkateWorld.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistributedSkateWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public IUser _iUser;
        UserBLL userBLL;
        public HomeController()
        {
            userBLL = new UserBLL(_iUser);
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {

            return userBLL.GetUserByID(id);

        }

    }
}
