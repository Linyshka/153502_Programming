using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bank bank = new Bank();
            bank.AddClient("Masha", Type.Vip);
            bank.AddClient("Misha", Type.Usual);
            bank.AddClient("Alina", Type.Vip);
            bank.AddClient("Pasha", Type.Usual);
            List<Client> clients = bank.GetClients();
            Assert.AreEqual("Masha", clients[0].GetName());
            bank.AddContr(45, 12, "Masha");
            bank.AddContr(72, 25, "Misha");
            bank.AddContr(34, 80, "Pasha");
            Assert.AreEqual(System.Math.Round(bank.GetTotalSum(), 2), 50.6);
            Assert.AreEqual(clients[2].GetType(), Type.Vip);
            bank.ChangeContr(67, "Masha");
            Assert.AreEqual(System.Math.Round(clients[0].GetSum(),3), 8.04);
        }
    }
}