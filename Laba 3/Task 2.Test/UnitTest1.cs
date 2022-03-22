using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task2 task = new Task2();
            task.function(5, 4);
            Assert.AreEqual(task.a, 2);
            Assert.AreEqual(System.Math.Round(task.X,5), 2.23607);
            Assert.AreEqual(System.Math.Round(task.Y, 5), -0.58044);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Task2 task = new Task2();
            task.function(-8, 3);
            Assert.AreEqual(task.a, 1);
            Assert.AreEqual(System.Math.Round(task.X, 5), -511);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Task2 task = new Task2();
            task.function(16, 1);
            Assert.AreEqual(task.a, 2);
            Assert.AreEqual(System.Math.Round(task.X, 5), 4);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Task2 task = new Task2();
            task.function(-13, -4);
            Assert.AreEqual(task.a, 1);
            Assert.AreEqual(System.Math.Round(task.X, 5), 2.00004);
            Assert.AreEqual(System.Math.Round(task.Y, 5), -1.76361);
        }
    }
}