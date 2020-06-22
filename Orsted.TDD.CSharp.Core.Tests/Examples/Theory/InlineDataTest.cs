using TDD.CSharp.Core.Examples.Theory;
using Xunit;

namespace TDD.CSharp.Core.Tests.Examples.Theory
{
    public class InlineDataTest
    {

        [Theory]
        [InlineData(1, false)]
        [InlineData(8, false)]
        [InlineData(17, false)]
        [InlineData(18, true)]
        [InlineData(20, true)]
        [InlineData(21, true)]
        [InlineData(22, true)]
        [InlineData(65, true)]
        [InlineData(100, true)]
        public void ShouldValidateAdultByAge(int age, bool expectedResult) {
            //Given
            Person1 person = new Person1(age);
            //When
            bool isAdult = person.IsAdult();
            //Then
            Assert.Equal(expectedResult, isAdult);
        }
    }
}
