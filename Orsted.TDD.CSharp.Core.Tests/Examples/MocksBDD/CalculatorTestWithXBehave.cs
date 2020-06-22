using Moq;
using TDD.CSharp.Core.Examples.MocksBDD;
using Xbehave;
using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.MocksBDD
{
    public class CalculatorTestWithXBehave
    {
        private readonly Mock<IAddService> _addServiceMock;
        private readonly Calculator _calculator;
        public CalculatorTestWithXBehave()
        {
            _addServiceMock = new Mock<IAddService>();
            _calculator = new Calculator(_addServiceMock.Object);
        }
        [Scenario]
        public void TestCalculatorAddServiceWithMock()
        {
            var num1 = 10;
            var num2 = 20;
            var expected = 30;
            var actual = 0;
            "Given I have calculator with mock AddService".x(x =>
                _addServiceMock.Setup(s => s.Add(num1, num2)).Returns(expected));
            $"When I add {num1} and {num2}".x(x => actual = _calculator.Calculate(num1, num2));
            $"Then sum should be {expected}".x(x => Assert.Equal(expected, actual));
        }
    }
}
