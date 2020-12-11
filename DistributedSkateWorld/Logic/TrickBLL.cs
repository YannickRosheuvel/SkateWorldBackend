using DistributedSkateWorld.DAL;
using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseHandling.Logic
{
    public class TrickBLL : ITrick
    {
        private ITrick _iTrick;
        private double experienceNeeded;

        public TrickBLL(ITrick iTrick)
        {
            _iTrick = iTrick;
        }

        public IEnumerable<Trick> GetCourseTricks(int id)
        {
            return _iTrick.GetCourseTricks(id);
        }

        public IEnumerable<Trick> GetTricks()
        {
            return _iTrick.GetTricks();
        }
    }
}
