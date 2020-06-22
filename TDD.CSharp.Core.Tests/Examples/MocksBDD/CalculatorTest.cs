using Moq;
using TDD.CSharp.Core.Examples.MocksBDD;
using Xunit;
using Xunit.Abstractions;

namespace TDD.CSharp.Core.Tests.Examples.MocksBDD
{
    public class CalculatorTest
    {
        private readonly ITestOutputHelper _output;
        private readonly Mock<IAddService> _addServiceMock;
        private readonly Calculator _calculator;
        public CalculatorTest(ITestOutputHelper output)
        {
            _output = output;
            _addServiceMock = new Mock<IAddService>();
            _calculator = new Calculator(_addServiceMock.Object);
        }
        [Fact]
        public void TestCalculatorAddServiceWithMock()
        {
            _output.WriteLine("Scenario: Add two numbers with mock");
            //given 
            _output.WriteLine("Given I have calculator with mock AddService");
            var num1 = 10;
            var num2 = 20;
            var expected = 30;
            _addServiceMock.Setup(s => s.Add(num1, num2)).Returns(expected);
            //when
            _output.WriteLine($"When I add {num1} and {num2}");
            var actual = _calculator.Calculate(num1, num2);
            //then
            _output.WriteLine($"Then sum should be {expected}");
            Assert.Equal(expected, actual);
        }
    }
}
