using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.DAL;
using DistributedSkateWorld.Models;
using Microsoft.AspNetCore.Http;
using DistributedSkateWorld.ViewModels;
using DistributedSkateWorld.Logic;
using CourseHandling.Logic;

namespace DistributedSkateWorld.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ITrick iTrick;
        TrickDAL trickDAL = new TrickDAL();
        CourseDAL courseDAL = new CourseDAL();
        CourseBLL courseBLL;
        TrickBLL trickBLL;
        private readonly ILogger<CourseController> _logger;

        public CourseController()
        {
            trickBLL = new TrickBLL(trickDAL);
            courseBLL = new CourseBLL(courseDAL);
    }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            try
            {
                return courseBLL.GetCourses();
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Internal server error");
            }

        }

        [HttpGet("{id}")]
        public Course GetSpecificCourse(int id)
        {

            return courseBLL.GetSpecificCourse(id);

        }

        [HttpGet("{id}/tricks")]
        public IEnumerable<Trick> GetCourseTricks(int id)
        {

            return iTrick.GetCourseTricks(id);

        }

        [HttpPut("{id}/complete")]
        public Course CourseCompleted(int id)
        {
            return courseBLL.CompleteCourse(id);
        }

    }
}
