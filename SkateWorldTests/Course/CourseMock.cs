using System;
using System.Collections.Generic;
using System.Text;
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;

namespace SkateWorldTests.CourseMock
{
    class CourseMock : ICourse
    {
        public IEnumerable<Course> AddCourse()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> ChangeCourse()
        {
            throw new NotImplementedException();
        }

        public Course CompleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public Course GetSpecificCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> RemoveCourse()
        {
            throw new NotImplementedException();
        }
    }
}
