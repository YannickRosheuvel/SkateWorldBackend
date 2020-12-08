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


            Assert.AreEqual(1, 1);
            //test
        }

        [TestMethod]
        public void test2()
        {
            UserMock userMock = new UserMock();
            UserBLL userBLL = new UserBLL(userMock);

            var actual = userBLL.AddExperience(10, 1, 10);

            Assert.AreEqual(2, actual.Level);
            //test
        }
    }
}
