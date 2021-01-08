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
using CourseHandling.Models;

namespace DistributedSkateWorld.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {

        private readonly ICourse iCourse;
        private readonly ITrick iTrick;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger;
            iCourse = new CourseDAL();
            iTrick = new TrickDAL();
        }

        [HttpGet]
        public IEnumerable<Course> Get()
        {

            return iCourse.GetCourses();

        }

        [HttpGet("{id}")]
        public Course GetSpecificCourse(int id)
        {

            return iCourse.GetSpecificCourse(id);

        }

        [HttpGet("{id}/tricks")]
        public IEnumerable<Trick> GetCourseTricks(int id)
        {

            return iTrick.GetCourseTricks(id);

        }

        [HttpPut("{userID}/course/{courseID}/complete")]
        public IActionResult completeCourse(int userID, int courseID)
        {

            iCourse.CompleteCourse(userID, courseID);
            return Ok();
        }

        [HttpGet("{userID}/getcompleted")]
        public IEnumerable<UserCourses> getCompletedCourses(int userID)
        {

            return iCourse.getCompletedCourses(userID);

        }

    }
}
