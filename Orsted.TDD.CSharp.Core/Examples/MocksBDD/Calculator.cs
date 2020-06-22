using System;

namespace TDD.CSharp.Core.Examples.MocksBDD
{
    public class Calculator
    {
        private readonly IAddService _addService;

        public Calculator(IAddService addService)
        {
            _addService = addService;
        }

        public int Calculate(int num1, int num2)
        {
            Console.WriteLine("**--- CalcService calc executed ---**");
            return _addService.Add(num1, num2);
        }
    }
}
