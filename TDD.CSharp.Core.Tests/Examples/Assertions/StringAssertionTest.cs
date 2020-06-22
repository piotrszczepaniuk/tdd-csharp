using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.Assertions
{
    public class StringAssertionTest
    {

        private readonly string _actual = "value of string";

        [Fact]
        public void EqualToTest()
        {
            string expected = "value of string";
            Assert.Equal( expected, _actual );
        }

        [Fact]
        public void NotEqualTest() 
        {
            string expected = "value";
            Assert.NotEqual(expected, _actual);
        }

        [Fact]
        public void ContainsTest()
        {
            string expectedSubstring = "value";
            Assert.Contains(expectedSubstring, _actual);
        }

        [Fact]
        public void DoseNotContainTest()
        {
            string expectedSubstring = "integer";
            Assert.DoesNotContain(expectedSubstring, _actual);
        }

        [Fact]
        public void StartsWithTest()
        {
            string expectedStartString = "value";
            Assert.StartsWith(expectedStartString, _actual);
        }

        [Fact]
        public void EndsWithTest()
        {
            string expectedEndString = "string";
            Assert.EndsWith(expectedEndString, _actual);
        }

        [Fact]
        public void MatchesTest()
        {
            string expectedRegexPattern = "[a-z]+ [a-z]+ [a-z]+";
            Assert.Matches(expectedRegexPattern, _actual);
        }

        [Fact]
        public void DoesNotMatchTest()
        {
            string expectedRegexPattern = "[0-9]+ [a-z]+ [a-z]+";
            Assert.DoesNotMatch(expectedRegexPattern, _actual);
        }


    }
}
