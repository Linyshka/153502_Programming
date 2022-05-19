using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Polinom polinom1 = new Polinom(0, 0, 0);
            Polinom polinom2 = new Polinom(1, 2, 3);
            Assert.IsFalse(polinom1 == polinom2);
            Assert.IsTrue(polinom2 != polinom1);
            Assert.AreEqual((++polinom1).ToString(), "1x + 1y + 1z");
            Assert.AreEqual((--polinom2).ToString(), "0x + 1y + 2z");
            Assert.AreEqual((polinom1 - polinom2).ToString(), "1x + 0y + -1z");
            Assert.AreEqual((polinom1 + polinom2).ToString(), "1x + 2y + 3z");
            Assert.AreEqual((polinom1 * 4).ToString(), "4x + 4y + 4z");
            Assert.AreEqual((polinom2 / 2).ToString(), "0x + 0y + 1z");
            int a = (int)polinom1;
            Assert.AreEqual(a.ToString(), "1");
            Assert.AreEqual(polinom2.A + polinom2.B + polinom2.C, 3);
            int c = 678;
            Assert.AreEqual(((Polinom)c).ToString(), "678x + 678y + 678z");
        }
    }
}