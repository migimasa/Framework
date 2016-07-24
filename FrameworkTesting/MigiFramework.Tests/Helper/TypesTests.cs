using System;
using NUnit.Framework;
using Migi.Framework.Helper;

namespace MigiFramework.Tests.Helper
{
    [TestFixture]
    public class TypesTests
    {
        [TestCase("fc5f462d-84ba-43af-8fe7-cd036a3cfb76")]
        [TestCase("FC5F462D-84BA-43AF-8fE7-CD036A3CFB76")]
        public void IsGuid_ValidInput_ReturnsTrue(object value)
        {
            bool isValid = Types.IsGuid(value);

            Assert.True(isValid);
        }

        [TestCase("test")]
        [TestCase('c')]
        [TestCase(12)]
        [TestCase(true)]
        [TestCase(12.43)]
        public void IsGuid_InvalidInput_ReturnsFalse(object value)
        {
            bool isValid = Types.IsGuid(value);

            Assert.False(isValid);
        }
    }
}
