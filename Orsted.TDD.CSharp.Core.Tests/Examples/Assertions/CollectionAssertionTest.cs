using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.Assertions
{
    public class CollectionAssertionTest
    {
        private readonly int[] _actualIntValues = new int[]{
                                                    100,
                                                    200,
                                                    300};

        private readonly string[] _actualStringValues = new string[]{
                                                    "value1",
                                                    "value2",
                                                    "value3"};

        [Fact]
        public void CollectionEqualTest() { 
            int[] expectedValues = new int[]{
                                                    100,
                                                    200,
                                                    300};
            Assert.Equal(expectedValues, _actualIntValues);
        }

        [Fact]
        public void CollectionNotNullOrWhiteSpace()
        {

            Assert.All(_actualStringValues, value => Assert.False(string.IsNullOrWhiteSpace(value)));
        }

        [Fact]
        public void EmptyTest() 
        {
            string[] emptyCollection = new string[] { };
            Assert.Empty(emptyCollection);
        }

        [Fact]
        public void NotEmptyTest()
        {
            string[] notEmptyCollection = new string[] { "value1" };
            Assert.NotEmpty(notEmptyCollection);
        }

    }
}
