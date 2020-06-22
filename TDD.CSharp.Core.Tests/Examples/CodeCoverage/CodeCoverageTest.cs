using Xunit;
using TDD.CSharp.Core.Examples.CodeCoverage;

namespace TDD.CSharp.Core.Tests.Examples
{
    public class CodeCoverageTest
    {
        [Fact]
        public void LineVsBranchCodeCoverageTest()
        {
            CodeCoverage cc = new CodeCoverage();
            cc.LineVsBranchCoverage(true);
            //cc.LineVsBranchCoverage(false);
        }
    }
}
