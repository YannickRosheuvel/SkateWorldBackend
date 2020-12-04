
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistributedSkateWorld.Interfaces
{
    public interface ICourse
    {

        IEnumerable<Course> GetCourses();
        IEnumerable<Course> AddCourse();
        IEnumerable<Course> RemoveCourse();
        IEnumerable<Course> ChangeCourse();
        Course GetSpecificCourse(int id);
        public Course CompleteCourse(int id);
    }
}
