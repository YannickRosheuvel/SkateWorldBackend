
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedSkateWorld.DAL
{
    public class TrickDAL : SkateWorldContext, ITrick
    {
        public IEnumerable<Trick> GetCourseTricks(int id)
        {

            return Trick.Where(trick => trick.CourseId == id).ToList();

        }

        public IEnumerable<Trick> GetTricks()
        {

            return Trick;

        }
    }
}
