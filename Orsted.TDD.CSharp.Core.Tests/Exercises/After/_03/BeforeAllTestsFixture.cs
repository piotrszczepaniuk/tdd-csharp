using System;

namespace TDD.CSharp.Core.Tests.Exercises.After._03
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
