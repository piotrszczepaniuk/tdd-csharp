using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.GroupAndSkip
{
    public class GroupAndSkipTest
    {

        [Fact]
        [Trait("Dev", "Category")]
        public void DevTest1() {
            //testing
        }

        [Fact]
        [Trait("Prod", "Category")]
        public void ProdTest1()
        {
            //testing
        }

        [Fact]
        [Trait("Prod", "Category")]
        public void ProdTest2()
        {
            //testing
        }

        [Fact(Skip = "This test is skipped")]
        public void SkipTest() {
            //testing
        }

    }
}
