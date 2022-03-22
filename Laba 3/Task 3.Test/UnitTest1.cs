using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task_3.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Date date = new Date();
            DateOnly dates = new DateOnly(2003, 10, 14);
            Assert.AreEqual(date.GetDay(dates.ToString()), "Tuesday");
            Assert.AreEqual(date.GetDaysSpan(dates.Day, dates.Month, dates.Year), 6734);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Date date = new Date();
            DateOnly dates = new DateOnly(1956, 08, 5);
            Assert.AreEqual(date.GetDay(dates.ToString()), "Sunday");
            Assert.AreEqual(date.GetDaysSpan(dates.Day, dates.Month, dates.Year), 23970);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Date date = new Date();
            DateOnly dates = new DateOnly(1875, 12, 29);
            Assert.AreEqual(date.GetDay(dates.ToString()), "Wednesday");
            Assert.AreEqual(date.GetDaysSpan(dates.Day, dates.Month, dates.Year), 53409);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Date date = new Date();
            DateOnly dates = new DateOnly(2022, 03, 22);
            Assert.AreEqual(date.GetDay(dates.ToString()), "Tuesday");
            Assert.AreEqual(date.GetDaysSpan(dates.Day, dates.Month, dates.Year), 0);
        }
    }
}