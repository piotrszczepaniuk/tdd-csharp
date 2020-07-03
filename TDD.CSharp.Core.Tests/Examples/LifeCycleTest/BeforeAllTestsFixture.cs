using System;


namespace TDD.CSharp.Core.Tests.Examples.LifeCycleTest
{
    public class BeforeAllTestsFixture : IDisposable
    {
        public BeforeAll State;

        //2. Print to console before all tests were executed
        public BeforeAllTestsFixture()
        {
            State = new BeforeAll();
        }

        //6. Print to console after all tests were executed
        public void Dispose()
        {
            //Clean-up after all tests
        }
    }
}
