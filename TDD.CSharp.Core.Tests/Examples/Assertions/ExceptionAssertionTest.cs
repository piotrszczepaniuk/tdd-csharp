using Xunit;
using System;
using TDD.CSharp.Core.Examples.Assertions;

namespace TDD.CSharp.Core.Tests.Examples.Assertions
{
    public class ExceptionAssertionTest
    {
        [Fact]
        public void ThrowsExceptionTest() 
        {
            SystemUnderTest sut = new SystemUnderTest("sut");
            Assert.Throws<ArgumentNullException>(() => sut.ThrowArgumentNullException(true));
            
        }

  
    }
}
