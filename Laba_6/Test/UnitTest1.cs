using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cookies cookie = new Cookies(10.99); 
            Assert.AreEqual(cookie.Print(), "��������� ������� �� 1 �� - 10,99");
            Milk milk = new Milk(2, 0.78);
            Assert.AreEqual(milk.Print(), "��������� Milk - 0,78; ���������� - 2");
            milk.ChangePrice(1.67);
            Assert.AreEqual(System.Math.Round(milk.Sum(), 3), 3.34);
            Assert.AreEqual(milk.Buy(), "�� ������ ������� ������� Milk �� ���� - 1,67");
            cookie.ChangePrice(12.33); //c������ �����
            Assert.AreEqual(System.Math.Round(cookie.Sum(1.5), 3), 18.495);
            Assert.AreEqual(cookie.Buy(), "�� ������ ������� ������� ������� �� ���� - 12,33");
            Furniture table = new Furniture(1, 39.12, "����"); 
            Assert.AreEqual(table.Buy(), "�� ������ ���� �� ���� 39,12");
            
        }
    }
}