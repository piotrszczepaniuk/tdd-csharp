using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.CSharp.Core.Examples.Theory
{
    public class Person2
    {
        private readonly int _age;

        public Person2(int age)
        {
            _age = age;

        }

        public bool IsAdult()
        {
            return (_age >= 21);
        }
    }
}
