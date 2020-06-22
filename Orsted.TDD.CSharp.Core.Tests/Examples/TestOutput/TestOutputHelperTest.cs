using Xunit;
using Xunit.Abstractions;

namespace TDD.CSharp.Core.Tests.Examples.TestOutput
{
    public class TestOutputHelperTest
    {
        private readonly ITestOutputHelper _output;
        public TestOutputHelperTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ShouldAddOutputToTest() {
            _output.WriteLine("Output from test");
        }
    }
}
