﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DistributedSkateWorld.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DistributedSkateWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("{id}")]
        public User Get(int id)
        {

            return new User();

        }

    }
}
