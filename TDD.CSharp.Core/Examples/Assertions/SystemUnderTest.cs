using System;

namespace TDD.CSharp.Core.Examples.Assertions
{
    public class SystemUnderTest
    {
        private readonly string _name;

        public SystemUnderTest(string name)
        {
            _name = name;
        }

        public void ThrowArgumentNullException(bool throwException) {
            if (throwException) {
                throw new ArgumentNullException();
            }
        }
    }
}
