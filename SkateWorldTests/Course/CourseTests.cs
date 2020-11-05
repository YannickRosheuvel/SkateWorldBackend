using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var number = 1;

            Assert.AreEqual(number, 1);

        }
    }
}
