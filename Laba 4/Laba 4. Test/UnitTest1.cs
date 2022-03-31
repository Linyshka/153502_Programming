using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba_4._Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bank bank = Bank.GetBnk(size_ : 12064, amount_ : 30, bet_ : 13.5);
            Assert.AreEqual(bank.GetName(), "Какой-то");
            Assert.AreEqual(bank.GetSize(), 12064);
            Assert.AreEqual(bank.GetAmount(), 30);
            Assert.AreEqual(bank.GetBet(), 13.5);
            Assert.AreEqual(48859.20, System.Math.Round(bank.Payment(),2));
            bank.ChangeName("Блаблабла");
            Assert.AreEqual(bank.GetName(), "Блаблабла");
            bank.DecreaseAmount(8);
            Assert.AreEqual(bank.GetAmount(), 22);
            bank.IncreaseAmount(56);
            Assert.AreEqual(bank.GetAmount(), 78);
            bank.IncreaseBet(23.4);
            Assert.AreEqual(bank.GetBet(), 36.9);
            bank.DecreaseBet(11.8);
            Assert.AreEqual(System.Math.Round(bank.GetBet(), 1), 25.1);
            bank.DecreaseSize(862);
            Assert.AreEqual(bank.GetSize(), 11202);
            bank.IncreaseSize(1056);
            Assert.AreEqual(bank.GetSize(), 12258);
            Assert.AreEqual(System.Math.Round(bank.Payment(), 3), 239987.124);
            Bank bank2 = Bank.GetBnk();
            Assert.AreEqual(bank2.GetName(), "Блаблабла");
        }
    }
}