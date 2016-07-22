using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KRSoftwareLib;
using NUnit.Framework;

namespace KRSoftwareLibUnitTest
{
    [TestFixture]
    public class DayHelperTest
    {
        [Test]
        public void GetIndonesianDayTest()
        {
            var helper = new DayHelper();

            Assert.AreEqual("Senin", helper.GetIndonesianDay(new DateTime(2016, 7, 25)));
            Assert.AreEqual("Selasa", helper.GetIndonesianDay(new DateTime(2016, 7, 26)));
            Assert.AreEqual("Rabu", helper.GetIndonesianDay(new DateTime(2016, 7, 27)));
            Assert.AreEqual("Kamis", helper.GetIndonesianDay(new DateTime(2016, 7, 28)));
            Assert.AreEqual("Jum'at", helper.GetIndonesianDay(new DateTime(2016, 7, 29)));
            Assert.AreEqual("Sabtu", helper.GetIndonesianDay(new DateTime(2016, 7, 30)));
            Assert.AreEqual("Minggu", helper.GetIndonesianDay(new DateTime(2016, 7, 31)));
        }
    }
}
