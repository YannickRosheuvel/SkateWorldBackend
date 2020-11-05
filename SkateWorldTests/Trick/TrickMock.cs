using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkateWorldTests.TrickMock
{
    class TrickMock : ITrick
    {
        public IEnumerable<Trick> GetCourseTricks(int id)
        {
            throw new NotImplementedException();
        }
    }
}
