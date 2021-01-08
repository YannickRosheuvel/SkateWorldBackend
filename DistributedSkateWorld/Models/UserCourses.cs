using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseHandling.Models
{
    public class UserCourses
    {

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

    }
}
