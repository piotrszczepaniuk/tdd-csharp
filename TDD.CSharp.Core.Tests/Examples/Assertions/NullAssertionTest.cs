using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.Assertions
{
    public class NullAssertionTest
    {
        [Fact]
        public void NullTest() {
            Assert.Null(null);
        }

        [Fact]
        public void NotNullTest()
        {
            Assert.NotNull("Not null value");
        }

    }
}
