using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bank belinvest = new Bank();
            belinvest.AddContrWithBon("Svetlna", 1000, 500);
            Assert.AreEqual(belinvest.GetTotalAmount(), 1500);
            belinvest.AddContrWithBon("Pavel", 10000, 300);
            belinvest.AddContrWithoutBon("Alina", 100010);
            Assert.AreEqual(belinvest.GetTotalAmount(), 111810);
            belinvest.AddContrWithBon("Katya", 300, 50);
            belinvest.AddContrWithoutBon("Danic", 7654);
            Assert.AreEqual(belinvest.GetTotalAmount(), 119814);
        }
    }
}