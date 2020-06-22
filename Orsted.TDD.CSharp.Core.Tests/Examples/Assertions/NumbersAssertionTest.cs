using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.Assertions
{
    public class NumberAssertsTest
    {
        private readonly int _actualValueInt = 100;
        private readonly float _actualValueFloat = 100.9999F;

        [Fact]
        public void GraterThanTest() {
            int expectedValue = 101;
            Assert.True(expectedValue > _actualValueInt, $"{expectedValue} should be > {_actualValueInt}");
        }

        [Fact]
        public void LessThanTest()
        {
            int expectedValue = 99;
            Assert.True(expectedValue < _actualValueInt, $"{expectedValue} should be < {_actualValueInt}");
        }
        [Fact]
        public void InRangeTest() {
            float low = 100.9998F;
            float high = 101.0000F;
            Assert.InRange(_actualValueFloat, low, high);
        }
        [Fact]
        public void NotInRangeTest()
        {
            float low = 100.99999F;
            float high = 101.0000F;
            Assert.NotInRange(_actualValueFloat, low, high);
        }

    }

}
