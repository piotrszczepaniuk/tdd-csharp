using Xunit;
using TDD.CSharp.Core.Examples.Assertions;

namespace TDD.CSharp.Core.Tests.Examples.Assertions
{
    public class ObjectAssertionTest
    {
        [Fact]
        public void SameTest() 
        {
            var expected = new SystemUnderTest("sut");
            var actual = expected;
            Assert.Same(expected, actual);
        }

        [Fact]
        public void NotSameTest()
        {
            var expected = new SystemUnderTest("sut");
            var actual = new SystemUnderTest("sut");
            Assert.NotSame(expected, actual);
        }
    }
}
