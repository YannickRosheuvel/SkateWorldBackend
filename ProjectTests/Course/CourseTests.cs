using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkateWorldTests.CourseMock;
using DistributedSkateWorld.Logic;

namespace CourseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CourseMock userMock = new CourseMock();
            CourseBLL userBLL = new CourseBLL(userMock);

            var number = 1;

            Assert.AreEqual(number, 1);

        }
    }
}
