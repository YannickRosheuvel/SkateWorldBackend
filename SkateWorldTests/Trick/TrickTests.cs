using CourseHandling.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkateWorldTests.TrickMock;

namespace TrickTests
{
    [TestClass]
    public class TrickTests
    {
        [TestMethod]
        public void TrickMethod()
        {
            TrickMock trickMock = new TrickMock();
            TrickBLL userBLL = new TrickBLL(trickMock);


        }
    }
}
