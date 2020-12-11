using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistributedSkateWorld.DAL;
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

        UserDAL userDAL;
        UserBLL userBLL;
        public HomeController()
        {
            userDAL = new UserDAL();
            userBLL = new UserBLL(userDAL);
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {

            return userBLL.GetUserByID(id);

        }

    }
}
