using System;
using Migi.Framework.Helper;
using NUnit.Framework;

namespace MigiFramework.Tests.Helper
{
    [TestFixture]
    public class SearchTests
    {
        [Test]
        public void GetUTCEndOfDaySearchDate_ValidInput_ReturnsTrue()
        {
            DateTime localDate = new DateTime(1988, 1, 30);

            DateTime utcDate = new DateTime(1988, 1, 30).Date.AddDays(1).AddMilliseconds(-20).ToUniversalTime();

            DateTime convertedDate = Search.GetUTCEndOfDaySearchDate(localDate);

            Assert.AreEqual(utcDate, convertedDate);
        }
    }
}
