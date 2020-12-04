
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace DistributedSkateWorld.DAL
{
    public class CourseDAL : SkateWorldContext, ICourse
    {

        public IEnumerable<Course> GetCourses()
        {
            //Get
            return Course.ToList();
        }

        public IEnumerable<Course> AddCourse()
        {

            //add
            Course course = new Course();
            course.Name = "Pro";

            Course.Add(course);
            SaveChanges();

            return Course.ToList();

        }

        public IEnumerable<Course> RemoveCourse()
        {

            //remove
            Course course = Course.Where(course => course.Name == "Noob").FirstOrDefault();
            Course.Remove(course);
            SaveChanges();

            //return context.Course.Where(course => course.Name == "Noob").ToList();
            return Course.ToList();

        }

        public IEnumerable<Course> ChangeCourse()
        {

            //change
            Course course = Course.Where(course => course.Name == "Pro").FirstOrDefault();
            course.Name = "Noob";
            SaveChanges();

            //return context.Course.Where(course => course.Name == "Noob").ToList();
            return Course.ToList();

        }

        public Course GetSpecificCourse(int id) 
        {

            foreach (Course course in Course)
            {
                if (course.Id == id)
                {
                    return course;
                }
            }

            return null;
        }

        public Course CompleteCourse(int id)
        {

            Course course = Course.Where(course => course.Id == id).FirstOrDefault();
            course.Completed = true;
            SaveChanges();

            return course;
        }

        public int GetCourseToughness(int id)
        {
            return Course.Where(user => user.Id == id).FirstOrDefault().CourseToughness;
        }
    }
}
