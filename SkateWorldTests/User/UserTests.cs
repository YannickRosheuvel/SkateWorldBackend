using DistributedSkateWorld.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkateWorldTests.UserMock;

namespace UserTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserMock userMock = new UserMock();
            UserBLL userBLL = new UserBLL(userMock);

            var actual = userBLL.AddExperience(10, 1);

            Assert.AreEqual(3, actual.Level);
            //test
        }
    }
}
