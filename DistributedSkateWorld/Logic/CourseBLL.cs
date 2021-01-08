using CourseHandling.Models;
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

        public CourseBLL(ICourse iCourse)
        {
            _iCourse = iCourse;
        }

        public IEnumerable<Course> AddCourse()
        {
            return _iCourse.AddCourse();
        }

        public IEnumerable<Course> ChangeCourse()
        {
            return _iCourse.ChangeCourse();
        }

        public UserCourses CompleteCourse(int userID, int courseID)
        {
            return _iCourse.CompleteCourse(userID, courseID);
        }

        public IEnumerable<UserCourses> getCompletedCourses(int userID)
        {
            return _iCourse.getCompletedCourses(userID);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _iCourse.GetCourses();
        }

        public Course GetSpecificCourse(int id)
        {
            return GetSpecificCourse(id);
        }

        public IEnumerable<Course> RemoveCourse()
        {
            return _iCourse.RemoveCourse();
        }
    }
}
