﻿using DistributedSkateWorld.Interfaces;
using DistributedSkateWorld.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkateWorldTests.TrickMock
{
    public class TrickMock : ITrick
    {
        public IEnumerable<Trick> GetCourseTricks(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trick> GetTricks()
        {
            throw new NotImplementedException();
        }
    }
}
