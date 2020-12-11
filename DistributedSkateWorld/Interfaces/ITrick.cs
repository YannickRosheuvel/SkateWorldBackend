
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistributedSkateWorld.Interfaces
{
    public interface ITrick
    {
        IEnumerable<Trick> GetCourseTricks(int id);
        IEnumerable<Trick> GetTricks();
    }
}
