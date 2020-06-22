using TDD.CSharp.Core.Exercises.After._03;
using System;
using Xunit;
using Xunit.Abstractions;

namespace TDD.CSharp.Core.Tests.Exercises.After._03
{
    [Collection("BeforeAll collection")]
    public class LifeCycleTest : IDisposable
    {

        private readonly SystemUnderTest _sut;
        private readonly ITestOutputHelper _output;
        private readonly BeforeAllTestsFixture _beforeAllTestsFixture;
 
        //3. Print to console before each test was executed
        public LifeCycleTest(ITestOutputHelper output, BeforeAllTestsFixture beforeAllTestsFixture)
        {
            _sut = new SystemUnderTest();
            _output = output;
            _beforeAllTestsFixture = beforeAllTestsFixture;
            _output.WriteLine($"Executing before each test.");
        }


        //1. Write first dummy test which will pass
        [Fact]
        public void TestOne()
        {
            _output.WriteLine("TestOne()");
            _output.WriteLine($"BeforeAll ID={_beforeAllTestsFixture.State.Id}");
            Assert.True(true, "Should be true.");
        }

        //4. Write second dummy test which will fails
        [Fact]
        public void TestTwo()
        {
            _output.WriteLine("TestTwo()");
            _output.WriteLine($"BeforeAll ID={_beforeAllTestsFixture.State.Id}");
            Assert.True(true, "Should be true.");
        }

        //5. Print to console after each test was executed
        public void Dispose()
        {
            _sut.Dispose();
            _output.WriteLine("Executing after each test.");
        }
        

    }
}
