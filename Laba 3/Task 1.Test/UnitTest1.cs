using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task1 task1 = new Task1();
            Assert.AreEqual(task1.function(4), 16);
            Assert.AreEqual(task1.function(36), 1296);
            Assert.AreEqual(task1.function(0), 0);
            Assert.AreEqual(task1.function(23), 529);
            Assert.AreEqual(task1.function(125), 15625);
            Assert.AreEqual(task1.function(89), 7921);
        }
    }
}