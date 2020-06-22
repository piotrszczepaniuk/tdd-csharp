using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.Assertions
{
    public class BooleanAssertTest
    {
        [Fact]
        public void AssertTrueTest()
        {
            Assert.True(true, "This value should be true");
        }

        [Fact]
        public void AssertFalseTest()
        {
            Assert.False(false, "This value should be false");
        }

    }

}
