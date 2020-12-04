using DistributedSkateWorld.DAL;
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistributedSkateWorld.Logic
{
    public class CourseBLL : ICourse
    {
        private ICourse _iCourse;
        CourseDAL courseDAL;

        public CourseBLL(ICourse iCourse)
        {
            courseDAL = new CourseDAL();
            _iCourse = iCourse;
        }

        public IEnumerable<Course> AddCourse()
        {
            return courseDAL.AddCourse();
        }

        public IEnumerable<Course> ChangeCourse()
        {
            return courseDAL.ChangeCourse();
        }

        public Course CompleteCourse(int id)
        {
            return courseDAL.CompleteCourse(id);
        }

        public IEnumerable<Course> GetCourses()
        {
            return courseDAL.GetCourses();
        }

        public Course GetSpecificCourse(int id)
        {
            return GetSpecificCourse(id);
        }

        public IEnumerable<Course> RemoveCourse()
        {
            return courseDAL.RemoveCourse();
        }
    }
}
