using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Result.task(67), false);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Result.task(36), true);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Result.task(75), true);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(Result.task(37), false);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(Result.task(25), false);
        }
    }
}