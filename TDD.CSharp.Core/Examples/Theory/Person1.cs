using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.CSharp.Core.Examples.Theory
{
    public class Person1
    {
        private readonly int _age;

        public Person1(int age)
        {
            _age = age;

        }

        public bool IsAdult()
        {
            return (_age >= 18);
        }
    }
}
